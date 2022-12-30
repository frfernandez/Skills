using System;
using System.Data;
using System.Windows.Forms;
using Database;
using Database.Entity;
using Basics;
using Entity.Config;
using Objects;
using Objects.Enumerator;
using Operational;
using Search.Entity;

namespace Search
{
    public partial class DynamicSearchF : Form
    {
        public Command CommandDb;
        public Messages MessagesDb;
        public DataTables Configuration;
        public Look LookControls;
        public ControlConfig FormControlConfig;
        public RecordEnum CRUDRecord;
        public Access AccessSystem;
        public string View;
        public string ProcedureOrder;
        public DataFilters DataFilter;
        public event EventHandler ItemMenuClick;

        private DataEntities DataEntity;
        private AppConfigs AppConfig;

        private DataFinder DataFind;

        private int Quantity = 0;

        private string ControlType;
        private string IdProcedure;

        public DynamicSearchF()
        {
            InitializeComponent();
        }

        public void FilterF_Shown(object sender, EventArgs e)
        {
            AccessSystem.AccessIns(((Form)sender).Name, SystemEnum.Form_In);
            LookControls.Form(this, Images, TTpTip);

            DataFilter.View = View;
            DataFilter.Form = ((Form)sender).Name;
            DataFilter.ProcedureOrder = ProcedureOrder;
            DataFilter.Config();

            DataEntity = new DataEntities(CommandDb, MessagesDb, Configuration);
            AppConfig = new AppConfigs(CommandDb, Configuration);

            DataFind = new DataFinder();
            DataFind.TextBoxSearch = TxBDescription;
            DataFind.DGVSearch = DGVSearch;
            DataFind.TextChanged += TxBDescription_TextChanged;
            DataFind.TableList = DataFilter.SelectDataTable();
            DataFind.ParameterId = "Id";
            DataFind.ParameterName = "LabelDataGridRow";
            DataFind.TypeViewFilter = DataFilter.TypeViewFilter;

            ColumnsCreate();
            PrivateConfig();
            DataFind.Config();
            DataGridViewConfig();
            ColumnsVisible();
            DataFind.SearchControlConfig("");
            DGVSearch_Enter(sender, e);
            Data();
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            bool IdValueFilter = false,
                 FilterFilled = false;
            string ProcedureList;
            int CountRecord = 0;

            Configuration.TableFilter.Clear();

            for (int i = 0; i < DataFilter.ProcedureList.Length; i++)
            {
                IDbCommand CommandIDb = CommandDb.CommandConfig("P", DataFilter.ProcedureList[i]);
                IdValueFilter = false;
                ProcedureList = "";

                try
                {
                    foreach (DataGridViewRow row in DGVSearch.Rows)
                    {
                        if (DataFilter.ProcedureList[i] == row.Cells["ProcedureFilter"].Value.ToString())
                        {
                            if (row.Cells["IdValue"].Value == null)
                                CommandDb.ParameterInput(CommandIDb, row.Cells["Parameter"].Value.ToString(), "");
                            else
                            {
                                if (row.Cells["Active"].Value.ToString() == "Y")
                                {
                                    CommandDb.ParameterInput(CommandIDb, row.Cells["Parameter"].Value.ToString(), row.Cells["IdValue"].Value.ToString());
                                    ProcedureList = row.Cells["ProcedureList"].Value.ToString();
                                    IdValueFilter = true;
                                    FilterFilled = IdValueFilter;
                                }
                                else
                                    CommandDb.ParameterInput(CommandIDb, row.Cells["Parameter"].Value.ToString(), "");
                            }

                            ParameterKeyValue(row);
                        }
                    }

                    if (IdValueFilter == true)
                    {
                        CommandDb.ParameterInputNull(CommandIDb);
                        if (CommandDb.ParameterExist(CommandIDb, "Search") == true)
                            CommandDb.ParameterInput(CommandIDb, "Search", "B");

                        DataFilter.DataTableFilter = CommandDb.DataSetDb(CommandIDb, "P").Tables[0];

                        if (CountRecord == 0)
                            CountRecord = DataFilter.DataTableFilter.Rows.Count;

                        if ((CountRecord > 0) && (ProcedureList.ToUpper() == ProcedureOrder.ToUpper()))
                            DataFilter.TableSort();
                    }
                }
                finally
                {
                    CommandIDb.Dispose();
                }
            }

            if (FilterFilled == true)
            {
                if (CountRecord == 0)
                    MessagesDb.GetMessage(DataFilter.Form, Hardware.Label().Trim().ToUpper(), SystemEnum.Table_Select, 1, 26);
                else
                {
                    AccessSystem.AccessIns(DataFilter.Form, SystemEnum.Filter);

                    foreach (DataRow row in Configuration.TableFilter.Rows)
                    {
                        if (row["Active"].ToString() == "Y")
                            AccessSystem.AccessProcedureIns(Convert.ToInt32(CommandDb.IdUser), Convert.ToInt32(CommandDb.IdDate),
                                                            Convert.ToInt32(CommandDb.IdTime),
                                                            row["Procedure"].ToString(), row["Parameter"].ToString(), row["Value"].ToString());
                    }

                    ItemMenuClick(searchMenu2, e);
                }
            }
            else
                MessagesDb.GetMessage(DataFilter.Form, Hardware.Label().Trim().ToUpper(), SystemEnum.Table_Select, 1, 25);
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            Values.PanelClean(PnlPanel1);
            Values.PanelClean(PnlPanel2);
            Values.PanelClean(PnlPanel3);
            Values.PanelClean(PnlPanel4);

            foreach (DataGridViewRow row in DGVSearch.Rows)
            {
                row.Cells["Active"].Value = "N";
                row.Cells["IdValue"].Value = "";
                row.Cells["NameValue"].Value = "";
            }
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            using (DynamicSearchOrderF FilterOrderForm = new DynamicSearchOrderF())
            {
                try
                {
                    FilterOrderForm.CommandDb = CommandDb;
                    FilterOrderForm.Configuration = Configuration;
                    FilterOrderForm.LookControls = LookControls;
                    FilterOrderForm.AccessSystem = AccessSystem;
                    FilterOrderForm.IdProcedure = IdProcedure;
                    FilterOrderForm.ShowDialog();
                }
                finally
                {
                    FilterOrderForm.Dispose();
                }
            }
        }

        public void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FilterF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (((Form)sender).ActiveControl != TxBDescription)
                    Key.Pressed(sender, e);
            }
            else if (Key.Pressed(sender, e) == Keys.Escape)
                BtnExit_Click(sender, e);
        }

        private void TxBDescription_KeyDown(object sender, KeyEventArgs e)
        {
            int Atual = DataFind.DataGridViewBind.Position;

            if (e.KeyCode == Keys.Enter)
            {
                DGVSearch_Enter(sender, e);
                DGVSearch_Leave(sender, e);
            }
            else if (e.KeyCode == Keys.PageUp)
                DataFind.DataGridViewBind.Position = 0;
            else if (e.KeyCode == Keys.Up)
            {
                if (DataFind.DataGridViewBind.Position + 1 >= 0)
                    DataFind.DataGridViewBind.Position--;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (DataFind.DataGridViewBind.Position + 1 < Quantity)
                    DataFind.DataGridViewBind.Position++;
            }
            else if (e.KeyCode == Keys.PageDown)
                DataFind.DataGridViewBind.Position = Quantity - 1;

            if (Atual != DataFind.DataGridViewBind.Position)
            {
                DGVSearch_Enter(sender, e);

                TxBDescription.Text = DGVSearch.CurrentRow.Cells[DataFind.ParameterName].Value.ToString();

                DataFind.FindTyping();
            }
        }

        private void TxBDescription_TextChanged(object sender, EventArgs e)
        {
            DataFind.FindTyping();
        }

        private void DGVSearch_Enter(object sender, EventArgs e)
        {
            EventConfig(false);

            LblLabelStart.Text = "";
            LblLabelStart.Visible = false;
            TxBIdWanted.Text = "";
            TxBIdWanted.MaxLength = 10;
            TxBIdWanted.Visible = false;

            LblLabelEnd.Text = "";
            LblLabelEnd.Visible = false;
            TxBWanted.CharacterCasing = CharacterCasing.Upper;
            TxBWanted.Text = "";
            TxBWanted.MaxLength = 50;
            TxBWanted.ReadOnly = false;
            TxBWanted.Visible = false;

            BtnWanted.Visible = false;
            BtnIndeterminate.Visible = false;

            NUDValue.Text = "";
            NUDValue.Visible = false;

            MkBMask.Text = "";
            MkBMask.Visible = false;

            CkBCheckBox.Checked = false;
            CkBCheckBox.Visible = false;
        }

        private void DGVSearch_Click(object sender, EventArgs e)
        {
            TxBDescription.Text = DGVSearch.CurrentRow.Cells["LabelDataGridRow"].Value.ToString();

            DataFind.FindSelecting();

            DGVSearch_Leave(sender, e);
        }

        private void DGVSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                TxBDescription_TextChanged(sender, e);
                DGVSearch_Leave(sender, e);
            }
            else if (e.KeyCode == Keys.Space)
                ActiveColumnData();
        }

        private void DGVSearch_DoubleClick(object sender, EventArgs e)
        {
            ActiveColumnData();
        }

        private void DGVSearch_Leave(object sender, EventArgs e)
        {
            ControlType = DGVSearch.CurrentRow.Cells["ControlType"].Value.ToString().ToUpper();

            LblLabelStart.Text = DGVSearch.CurrentRow.Cells["Label1"].Value.ToString();
            LblLabelStart.Visible = true;

            if ((ControlType == "DateTime".ToUpper()) ||
                (ControlType == "Number".ToUpper()))
            {
                LblLabelEnd.Text = DGVSearch.CurrentRow.Cells["Label2"].Value.ToString();
                LblLabelEnd.Visible = true;
            }

            if (ControlType == "IdName".ToUpper())
            {
                TxBIdWanted.Width = Convert.ToInt32(DGVSearch.CurrentRow.Cells["SizeWidth1"].Value);
                TxBIdWanted.Visible = LblLabelStart.Visible;
                TTpTip.SetToolTip(TxBIdWanted, DGVSearch.CurrentRow.Cells["Tip1"].Value.ToString());

                BtnWanted.Left = TxBIdWanted.Left + TxBIdWanted.Width + 1;
                BtnWanted.Visible = LblLabelStart.Visible;
                TTpTip.SetToolTip(BtnWanted, DGVSearch.CurrentRow.Cells["Tip2"].Value.ToString());

                if (DGVSearch.CurrentRow.Cells["CharacterCasing"].Value.ToString().ToUpper() == "Upper".ToUpper())
                    TxBWanted.CharacterCasing = CharacterCasing.Upper;
                else if (DGVSearch.CurrentRow.Cells["CharacterCasing"].Value.ToString().ToUpper() == "Lower".ToUpper())
                    TxBWanted.CharacterCasing = CharacterCasing.Lower;
                else if (DGVSearch.CurrentRow.Cells["CharacterCasing"].Value.ToString().ToUpper() == "Normal".ToUpper())
                    TxBWanted.CharacterCasing = CharacterCasing.Normal;

                TxBWanted.Left = BtnWanted.Left + BtnWanted.Width + 1;
                TxBWanted.Width = Convert.ToInt32(DGVSearch.CurrentRow.Cells["SizeWidth2"].Value);
                TxBWanted.ReadOnly = true;
                TxBWanted.Visible = LblLabelStart.Visible;
                TTpTip.SetToolTip(TxBWanted, DGVSearch.CurrentRow.Cells["Tip3"].Value.ToString());

                LblLabelStart.Left = TxBIdWanted.Left;
                LblLabelEnd.Left = TxBWanted.Left;
                LblLabelEnd.Text = DGVSearch.CurrentRow.Cells["Label2"].Value.ToString();
                LblLabelEnd.Visible = LblLabelStart.Visible;

                if (DGVSearch.CurrentRow.Cells["IdValue"].Value != null)
                    TxBIdWanted.Text = DGVSearch.CurrentRow.Cells["IdValue"].Value.ToString();

                if (DGVSearch.CurrentRow.Cells["NameValue"].Value != null)
                    TxBWanted.Text = DGVSearch.CurrentRow.Cells["NameValue"].Value.ToString();

                LookControls.ObjectFocus(TxBIdWanted);

                if (String.IsNullOrEmpty(TxBIdWanted.Text) == false)
                    TxBIdWanted_Leave(sender, e);
            }
            else if (ControlType == "Name".ToUpper())
            {
                if (DGVSearch.CurrentRow.Cells["CharacterCasing"].Value.ToString().ToUpper() == "Upper".ToUpper())
                    TxBWanted.CharacterCasing = CharacterCasing.Upper;
                else if (DGVSearch.CurrentRow.Cells["CharacterCasing"].Value.ToString().ToUpper() == "Lower".ToUpper())
                    TxBWanted.CharacterCasing = CharacterCasing.Lower;
                else if (DGVSearch.CurrentRow.Cells["CharacterCasing"].Value.ToString().ToUpper() == "Normal".ToUpper())
                    TxBWanted.CharacterCasing = CharacterCasing.Normal;

                TxBIdWanted.Visible = false;

                TxBWanted.Left = TxBIdWanted.Left;
                TxBWanted.MaxLength = Convert.ToInt32(DGVSearch.CurrentRow.Cells["SizeParameter"].Value);
                TxBWanted.Width = Convert.ToInt32(DGVSearch.CurrentRow.Cells["SizeWidth1"].Value);
                TxBWanted.ReadOnly = TxBIdWanted.Visible;
                TxBWanted.Visible = LblLabelStart.Visible;

                if (DGVSearch.CurrentRow.Cells["IdValue"].Value != null)
                    TxBWanted.Text = DGVSearch.CurrentRow.Cells["IdValue"].Value.ToString();

                LookControls.ObjectFocus(TxBWanted);
            }
            else if (ControlType == "Mask".ToUpper())
            {
                MkBMask.MaxLength = Convert.ToInt32(DGVSearch.CurrentRow.Cells["SizeParameter"].Value);
                MkBMask.Width = Convert.ToInt32(DGVSearch.CurrentRow.Cells["SizeWidth1"].Value);
                MkBMask.Mask = DGVSearch.CurrentRow.Cells["Mask"].Value.ToString();
                MkBMask.Visible = LblLabelStart.Visible;

                if (DGVSearch.CurrentRow.Cells["IdValue"].Value != null)
                    MkBMask.Text = DGVSearch.CurrentRow.Cells["IdValue"].Value.ToString();

                LookControls.ObjectFocus(MkBMask);
            }
            else if (ControlType == "Number".ToUpper())
            {
                NUDValue.Width = Convert.ToInt32(DGVSearch.CurrentRow.Cells["SizeWidth1"].Value);
                NUDValue.Visible = LblLabelStart.Visible;

                if (String.IsNullOrEmpty(DGVSearch.CurrentRow.Cells["Minimum"].Value.ToString()) == true)
                {
                    NUDValue.Minimum = 1;
                    NUDValue.Maximum = 999999999;
                }
                else
                {
                    NUDValue.Minimum = Convert.ToInt32(DGVSearch.CurrentRow.Cells["Minimum"].Value);
                    NUDValue.Maximum = Convert.ToInt32(DGVSearch.CurrentRow.Cells["Maximum"].Value);
                }

                if (DGVSearch.CurrentRow.Cells["IdValue"].Value != null)
                    NUDValue.Value = Convert.ToInt32(DGVSearch.CurrentRow.Cells["IdValue"].Value);

                LblLabelStart.Left = NUDValue.Left;

                LookControls.ObjectFocus(NUDValue);
            }
            else if (ControlType == "Check".ToUpper())
            {
                CkBCheckBox.Text = DGVSearch.CurrentRow.Cells["Label1"].Value.ToString();
                CkBCheckBox.Visible = LblLabelStart.Visible;

                BtnIndeterminate.Left = CkBCheckBox.Left + CkBCheckBox.Width + 1;
                BtnIndeterminate.Visible = CkBCheckBox.Visible;
                TTpTip.SetToolTip(BtnIndeterminate, DGVSearch.CurrentRow.Cells["Tip2"].Value.ToString());

                LblLabelStart.Visible = false;

                CheckColumn();

                LookControls.ObjectFocus(CkBCheckBox);
            }

            EventConfig(true);
        }

        private void TxBIdWanted_Leave(object sender, EventArgs e)
        {
            DataEntity.AbstractEntity(DGVSearch.CurrentRow.Cells["DataClass"].Value.ToString(), DataFilter.Form);
            TxBWanted.Text = DataEntity.SelectName(DGVSearch.CurrentRow.Cells["DataClass"].Value.ToString(), TxBIdWanted.Text);
            if (String.IsNullOrEmpty(TxBWanted.Text) == true)
            {
                TxBIdWanted.Text = TxBWanted.Text;
                BtnWanted_Click(sender, e);
            }

            ValuesColumnsData(TxBIdWanted.Text, TxBWanted.Text);
        }

        private void BtnWanted_Click(object sender, EventArgs e)
        {
            AppConfig.Save(DGVSearch.CurrentRow.Cells["TableName"].Value.ToString(), "FormText", DGVSearch.CurrentRow.Cells["SearchFormText"].Value.ToString());
            AppConfig.Save(DGVSearch.CurrentRow.Cells["TableName"].Value.ToString(), "ParameterId", DGVSearch.CurrentRow.Cells["ParameterId"].Value.ToString());
            AppConfig.Save(DGVSearch.CurrentRow.Cells["TableName"].Value.ToString(), "DataGridField", DGVSearch.CurrentRow.Cells["ParameterName"].Value.ToString());
            AppConfig.Save(DGVSearch.CurrentRow.Cells["TableName"].Value.ToString(), "TypeViewFilter", DataFilter.TypeViewFilter);

            using (SearchDataF SearchForm = new SearchDataF())
            {
                try
                {
                    SearchForm.TxBDescription.CharacterCasing = CharacterCasing.Upper;
                    SearchForm.CommandDb = CommandDb;
                    SearchForm.MessagesDb = MessagesDb;
                    SearchForm.Configuration = Configuration;
                    SearchForm.LookControls = LookControls;
                    SearchForm.FormControlConfig = FormControlConfig;
                    SearchForm.CRUDRecord = RecordEnum.Select;
                    SearchForm.AccessSystem = AccessSystem;
                    SearchForm.TableConfigSearch = DGVSearch.CurrentRow.Cells["TableName"].Value.ToString();
                    SearchForm.TableList = DataEntity.SelectDataTable(DGVSearch.CurrentRow.Cells["DataClass"].Value.ToString());
                    SearchForm.Text = DGVSearch.CurrentRow.Cells["SearchFormText"].Value.ToString();
                    SearchForm.ShowDialog();
                }
                finally
                {
                    if (String.IsNullOrEmpty(SearchForm.IdValue) == false)
                    {
                        TxBIdWanted.Text = SearchForm.IdValue;
                        TxBWanted.Text = SearchForm.NameValue;

                        ValuesColumnsData(SearchForm.IdValue, SearchForm.NameValue);
                    }

                    SearchForm.Dispose();
                }
            }
        }

        private void TxBWanted_Leave(object sender, EventArgs e)
        {
            if (ControlType == "Name".ToUpper())
                ValuesColumnsData(TxBWanted.Text, "");
        }

        private void NUDValueStart_Leave(object sender, EventArgs e)
        {
            ValuesColumnsData(NUDValue.Value.ToString(), "");
        }

        private void MkBMaskStart_Leave(object sender, EventArgs e)
        {
            DateTimeCheck();
        }

        private void MkBMaskEnd_Leave(object sender, EventArgs e)
        {
            DateTimeCheck();
        }

        private void CkBCheckBox_Enter(object sender, EventArgs e)
        {
            CheckColumn();
        }

        private void CkBCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CkBCheckBox.CheckState == CheckState.Checked)
                ValuesColumnsData("Y", "");
            else if (CkBCheckBox.CheckState == CheckState.Unchecked)
                ValuesColumnsData("N", "");
            else if (CkBCheckBox.CheckState == CheckState.Indeterminate)
                ValuesColumnsData("", "");
        }

        private void BtnIndeterminate_Click(object sender, EventArgs e)
        {
            CkBCheckBox.CheckState = CheckState.Indeterminate;
            DGVSearch.CurrentRow.Cells["Active"].Value = "N";
            ValuesColumnsData("", "");
        }

        private void ActiveColumnData()
        {
            if (DGVSearch.CurrentRow.Cells["Active"].Value == null)
                DGVSearch.CurrentRow.Cells["Active"].Value = "N";
            else
            {
                if (String.IsNullOrEmpty(DGVSearch.CurrentRow.Cells["IdValue"].Value.ToString()) == true)
                    DGVSearch.CurrentRow.Cells["Active"].Value = "N";
                else
                {
                    if (DGVSearch.CurrentRow.Cells["Active"].Value.ToString() == "Y")
                        DGVSearch.CurrentRow.Cells["Active"].Value = "N";
                    else
                        DGVSearch.CurrentRow.Cells["Active"].Value = "Y";
                }
            }
        }

        private void CheckColumn()
        {
            if ((DGVSearch.CurrentRow.Cells["IdValue"].Value == null) || (String.IsNullOrEmpty(DGVSearch.CurrentRow.Cells["IdValue"].Value.ToString()) == true))
                CkBCheckBox.CheckState = CheckState.Indeterminate;
            else
            {
                if (DGVSearch.CurrentRow.Cells["IdValue"].Value.ToString() == "Y")
                    CkBCheckBox.CheckState = CheckState.Checked;
                else if (DGVSearch.CurrentRow.Cells["IdValue"].Value.ToString() == "N")
                    CkBCheckBox.CheckState = CheckState.Unchecked;
                else
                    CkBCheckBox.CheckState = CheckState.Indeterminate;
            }
        }

        private void ValuesColumnsData(string IdValue, string NameValue)
        {
            if (DGVSearch.CurrentRow != null)
            {
                DGVSearch.CurrentRow.Cells["IdValue"].Value = IdValue;
                DGVSearch.CurrentRow.Cells["NameValue"].Value = NameValue;

                if (String.IsNullOrEmpty(DGVSearch.CurrentRow.Cells["IdValue"].Value.ToString()) == true)
                    DGVSearch.CurrentRow.Cells["Active"].Value = "N";
                else
                    DGVSearch.CurrentRow.Cells["Active"].Value = "Y";
            }
        }

        private void PrivateConfig()
        {
            searchMenu2.Click += ItemMenuClick;
        }

        private void ColumnsCreate()
        {
            DataGridViewCheckBoxColumn Active = new DataGridViewCheckBoxColumn();
            Active.Name = "Active";
            Active.HeaderText = "";
            Active.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Active.Width = 20;
            Active.TrueValue = "Y";
            Active.FalseValue = "N";
            Active.IndeterminateValue = Active.FalseValue;
            Active.Visible = true;
            DGVSearch.Columns.Add(Active);
            DGVSearch.Columns["Active"].DisplayIndex = 0;

            DataGridViewTextBoxColumn IdValue = new DataGridViewTextBoxColumn();
            IdValue.Name = "IdValue";
            IdValue.HeaderText = "Id Value";
            IdValue.Width = 100;
            IdValue.Visible = false;
            DGVSearch.Columns.Add(IdValue);

            DataGridViewTextBoxColumn NameValue = new DataGridViewTextBoxColumn();
            NameValue.Name = "NameValue";
            NameValue.HeaderText = "Name Value";
            NameValue.Width = 100;
            NameValue.Visible = false;
            DGVSearch.Columns.Add(NameValue);

            BtnClean_Click(BtnClean, null);
        }

        private void ParameterKeyValue(DataGridViewRow rowDataGrid)
        {
            DataRow rowTable = Configuration.TableFilter.NewRow();

            rowTable["Procedure"] = rowDataGrid.Cells["ProcedureFilter"].Value.ToString();
            rowTable["Parameter"] = rowDataGrid.Cells["Parameter"].Value.ToString();

            if ((rowDataGrid.Cells["IdValue"].Value != null) && (rowDataGrid.Cells["Active"].Value.ToString() == "Y"))
                rowTable["Value"] = rowDataGrid.Cells["IdValue"].Value.ToString();
            else
                rowTable["Value"] = "";

            if (rowDataGrid.Cells["Active"].Value == null)
                rowTable["Active"] = "N";
            else
                rowTable["Active"] = rowDataGrid.Cells["Active"].Value.ToString();

            Configuration.TableFilter.Rows.Add(rowTable);
        }

        private void ColumnsVisible()
        {
            for (int i = 0; i < DGVSearch.Columns.Count; i++)
            {
                if (DGVSearch.Columns[i].Name.Trim().ToUpper() == "LabelDataGridRow".ToUpper())
                {
                    DGVSearch.Columns[i].HeaderText = "Filters";
                    DGVSearch.Columns[i].Width = TxBDescription.Width - (DGVSearch.RowHeadersWidth + 25);
                }
                else if (DGVSearch.Columns[i].Name.Trim().ToUpper() == "Active".ToUpper())
                    DGVSearch.Columns[i].Visible = true;
                else
                    DGVSearch.Columns[i].Visible = false;
            }
        }

        public void Data()
        {
            DataTable Table = null;
            IDbCommand CommandIDb;
            IdProcedure = "";

            Configuration.TableProcedureFields.Clear();
            Configuration.TableOrders.Clear();

            CommandIDb = CommandDb.CommandConfig("P", ProcedureOrder);

            try
            {
                Table = CommandDb.DataSetDb(CommandIDb, "P").Tables[0];

                foreach (DataColumn columnOrder in Table.Columns)
                {
                    DataRow rowFields = Configuration.TableProcedureFields.NewRow();
                    rowFields["Field"] = columnOrder.ColumnName.ToUpper();
                    Configuration.TableProcedureFields.Rows.Add(rowFields);
                }
            }
            finally
            {
                CommandIDb.Dispose();
                Table.Dispose();
            }

            if (Configuration.TableProcedureFields.Rows.Count > 0)
            {
                try
                {
                    CommandIDb = CommandDb.CommandConfig("P", "InsProceduresId");
                    CommandDb.ParameterInput(CommandIDb, "Name", ProcedureOrder);
                    CommandDb.ParameterInput(CommandIDb, "Id", "");
                    CommandIDb.ExecuteNonQuery();
                    IdProcedure = CommandDb.ParameterOutput(CommandIDb, "Id");
                }
                finally
                {
                    CommandIDb.Dispose();

                    try
                    {
                        CommandIDb = CommandDb.CommandConfig("P", "FltFiltersOrders");
                        CommandDb.ParameterInput(CommandIDb, "IdProcedure", IdProcedure);
                        Table = CommandDb.DataSetDb(CommandIDb, "P").Tables[0];

                        if (Table.Rows.Count > 0)
                        {
                            DataRow rowFields;

                            foreach (DataRow rowOrder in Table.Rows)
                            {
                                rowFields = Configuration.TableOrders.NewRow();
                                rowFields["Field"] = rowOrder["ColumnName"].ToString().ToUpper();
                                rowFields["Type"] = rowOrder["TypeOrder"];
                                Configuration.TableOrders.Rows.Add(rowFields);
                            }

                            foreach (DataRow rowOrder in Configuration.TableOrders.Rows)
                            {
                                rowFields = Configuration.TableProcedureFields.Rows.Find(rowOrder["Field"]);
                                if (rowFields != null)
                                    Configuration.TableProcedureFields.Rows.Remove(rowFields);
                            }
                        }
                    }
                    finally
                    {
                        CommandIDb.Dispose();
                        Table.Dispose();
                    }
                }
            }
        }

        private void DateTimeCheck()
        {
            if (ControlType == "Date".ToUpper())
            {
                if (TimeDate.Date.Check(MkBMask) == true)
                    ValuesColumnsData(MkBMask.Text, "");
            }
            else if (ControlType == "Time".ToUpper())
            {
                if (TimeDate.Time.Check(MkBMask) == true)
                    ValuesColumnsData(MkBMask.Text, "");
            }
            else
                ValuesColumnsData(MkBMask.Text, "");
        }

        private void DataGridViewConfig()
        {
            DGVSearch.DataSource = DataFind.TableList;
        }

        private void FindConfig(bool Enabled)
        {
            DataFind.ColorConfig(Enabled);
        }

        private void EventConfig(bool Config)
        {
            if (Config == true)
            {
                DGVSearch.Leave += DGVSearch_Leave;
                TxBIdWanted.Leave += TxBIdWanted_Leave;
                CkBCheckBox.CheckedChanged += CkBCheckBox_CheckedChanged;
            }
            else
            {
                DGVSearch.Leave -= DGVSearch_Leave;
                TxBIdWanted.Leave -= TxBIdWanted_Leave;
                CkBCheckBox.CheckedChanged -= CkBCheckBox_CheckedChanged;
            }
        }

        private void FilterF_FormClosing(object sender, FormClosingEventArgs e)
        {
            AccessSystem.AccessIns(((Form)sender).Name, SystemEnum.Form_Out);

            DataFilter.DataTableFilter = null;
            DataEntity.Dispose();
        }
    }
}
