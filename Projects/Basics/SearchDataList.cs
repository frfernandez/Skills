using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Database;
using Entity;
using Module;
using Objects;
using Objects.Enumerator;
using Operational;

namespace Basics
{
    public partial class SearchDataListF : Form
    {
        public Command CommandDb;
        public DataTables Configuration;
        public Look LookControls;
        public RecordEnum CRUDRecord;
        public string IdValue;
        public string NameValue;
        public string TableConfigSearch;
        public DataTable TableFilter;
        public string ItemPrivilege;
        public string TypeViewFilter;
        public int Current;
        public bool Initialize;

        private string FormText;
        private DataTable TableList;
        private DataEntities DataEntity;
        private List<IdNameModule> ListData;

        public SearchDataListF()
        {
            InitializeComponent();
        }

        public void SearchF_Shown(object sender, EventArgs e)
        {
            LookControls.Form(this, Images, TTpTip);

            DataEntity = new DataEntities(CommandDb, Configuration);
            DataEntity.Initialize = Initialize;

            EventConfig(false);
            PrivateConfig();
            EventConfig(true);
            FormConfig();
            PersonUserUnique();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if ((DGVSearch.CurrentRow != null) && (DGVSearch.CurrentRow.Index == 0) &&
                (String.IsNullOrEmpty(TxBDescription.Text) == true))
                TxBDescription.Text = DGVSearch.Rows[DGVSearch.CurrentRow.Index].Cells["Nome"].Value.ToString();

            if (GBxRecord.Visible == true)
            {
                if (RBtUpdate.Checked == true)
                    CRUDRecord = RecordEnum.Update;
                else if (RBtDelete.Checked == true)
                    CRUDRecord = RecordEnum.Delete;
            }
            else
                CRUDRecord = RecordEnum.Insert;

            this.Close();
        }

        public void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnSelect_Click(sender, e);
            else if (Key.Pressed(sender, e) == Keys.Escape)
                BtnExit_Click(sender, e);
        }

        private void TxBDescription_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void CkBBringAllRecords_CheckedChanged(object sender, EventArgs e)
        {
            TxBDescription_TextChanged(sender, e);
        }

        private void RBtStart_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtStart.Checked == true)
                TxBDescription_TextChanged(sender, e);
        }

        private void RBtEnd_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtEnd.Checked == true)
                TxBDescription_TextChanged(sender, e);
        }

        private void RBtContain_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtContain.Checked == true)
                TxBDescription_TextChanged(sender, e);
        }

        private void NUDMinimum_ValueChanged(object sender, EventArgs e)
        {
            TxBDescription_TextChanged(sender, e);
        }

        private void DGVSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
                LookControls.ObjectFocus(TxBDescription);
            else
                TxBDescription.Text = DGVSearch.CurrentRow.Cells["Nome"].Value.ToString();
        }

        private void DGVSearch_DoubleClick(object sender, EventArgs e)
        {
            BtnSelect_Click(sender, e);
        }

        private static List<T> ListGenerator<T>(DataTable Table) where T : new()
        {
            List<T> Return = new List<T>();
            List<string> Columns = new List<string>();

            foreach (DataColumn column in Table.Columns)
                Columns.Add(column.ColumnName);

            Return = Table.AsEnumerable().ToList().ConvertAll<T>(row => Object<T>(row, Columns));
            return Return;
        }

        private static T Object<T>(DataRow row, List<string> columns) where T : new()
        {
            T Object = new T();

            string Column = "",
                   Value = "";

            PropertyInfo[] Properties;
            Properties = typeof(T).GetProperties();

            foreach (PropertyInfo objectProperty in Properties)
            {
                Column = columns.Find(name => name.ToLower() == objectProperty.Name.ToLower());
                if (String.IsNullOrEmpty(Column) == false)
                {
                    Value = row[Column].ToString();

                    if (String.IsNullOrEmpty(Value) == false)
                    {
                        if (Nullable.GetUnderlyingType(objectProperty.PropertyType) == null)
                        {
                            Value = row[Column].ToString().Replace("%", "");
                            objectProperty.SetValue(Object, Convert.ChangeType(Value, Type.GetType(objectProperty.PropertyType.ToString())), null);
                        }
                        else
                        {
                            Value = row[Column].ToString().Replace("$", "").Replace(",", "");
                            objectProperty.SetValue(Object, Convert.ChangeType(Value, Type.GetType(Nullable.GetUnderlyingType(objectProperty.PropertyType).ToString())), null);
                        }
                    }
                }
            }

            return Object;
        }

        private void Filter()
        {
            if ((TxBDescription.Text.Length >= NUDMinimum.Value) ||
                (CkBBringAllRecords.Checked == true) ||
                (Initialize == true))
            {
                if (TableList is null)
                {
                    DataEntity.AbstractEntity(TableConfigSearch, FormText);

                    if (CkBBringAllRecords.Checked == true)
                        TableList = DataEntity.SelectDataTable(TableConfigSearch, "", "");
                }

                if (CkBBringAllRecords.Checked == false)
                    TableList = DataEntity.SelectDataTable(TableConfigSearch, "", TxBDescription.Text);

                DataColumnCollection columns = TableList.Columns;

                TableList.Columns[0].ColumnName = "Codigo";
                TableList.Columns[1].ColumnName = "Nome";

                ListData = ListGenerator<IdNameModule>(TableList);
            }

            if (!(ListData is null))
            {
                if ((TxBDescription.Text.Length < NUDMinimum.Value) &&
                    (CkBBringAllRecords.Checked == false))
                    DGVSearch.DataSource = null;
                else
                {
                    List<IdNameModule> result = ListData.ToList();

                    if (TxBDescription.Text.Length >= NUDMinimum.Value)
                    {
                        if (RBtStart.Checked == true)
                            result = ListData.Where(x => x.Nome.StartsWith(TxBDescription.Text)).OrderBy(x => x.Nome).ToList();
                        else if (RBtEnd.Checked == true)
                            result = ListData.Where(x => x.Nome.EndsWith(TxBDescription.Text)).OrderBy(x => x.Nome).ToList();
                        else if (RBtContain.Checked == true)
                            result = ListData.Where(x => x.Nome.Contains(TxBDescription.Text)).OrderBy(x => x.Nome).ToList();
                    }

                    DGVSearch.DataSource = result;

                    if (DGVSearch.Rows.Count == 0)
                        DGVSearch.CurrentCell = null;
                    else
                        DGVSearch.CurrentCell = DGVSearch.Rows[0].Cells["Nome"];

                    DataGridViewConfig();
                }
            }
        }

        private void PersonUserUnique()
        {
            if ((Initialize == true) && (ListData.Count == 1))
                this.Close();
        }

        private void PrivateConfig()
        {
            FormText = Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(CommandDb.User, "|", TableConfigSearch, "_FormText"));

            EventConfig(false);
            Values.CheckBoxPosition(CkBBringAllRecords, Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(CommandDb.User, "|", "SELECT_BRING_ALL_RECORDS_".ToUpper(), TableConfigSearch.ToUpper())));
            TypeViewFilter = Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(CommandDb.User, "|", "SELECT_LIKE_", TableConfigSearch.ToUpper()));
            LookControls.RadioButtonCheck(GBxFilter, TypeViewFilter);

            if (Configuration.TableCommand.Find(Configuration.TableConfig, String.Concat(CommandDb.User, "|", "SELECT_LIKE_MINIMUM_CHARACTERS_TYPED_", TableConfigSearch.ToUpper())) == true)
                NUDMinimum.Value = Convert.ToInt32(Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(CommandDb.User, "|", "SELECT_LIKE_MINIMUM_CHARACTERS_TYPED_".ToUpper(), TableConfigSearch.ToUpper())));
            else
                NUDMinimum.Value = 1;

            if (CkBBringAllRecords.Checked == true)
                TxBDescription_TextChanged(this, null);

            EventConfig(true);
        }

        private void FormConfig()
        {
            if (CRUDRecord == RecordEnum.Select)
                GBxRecord.Visible = false;
            else
            {
                GBxRecord.Visible = true;

                if (CommandDb.Administrator() == true)
                {
                    GBxRecord.Visible = CommandDb.Administrator();
                    RBtUpdate.Visible = CommandDb.Administrator();
                    RBtDelete.Visible = CommandDb.Administrator();
                }
            }

            if (GBxRecord.Visible == true)
            {
                if ((RBtUpdate.Visible == true) &&
                    (RBtDelete.Visible == false))
                    RBtUpdate.Checked = RBtUpdate.Visible;
                else if ((RBtUpdate.Visible == false) &&
                         (RBtDelete.Visible == true))
                    RBtDelete.Checked = RBtDelete.Visible;
                else
                    RBtUpdate.Checked = RBtUpdate.Visible;
            }

            LookControls.ObjectFocus(TxBDescription);
        }

        private void EventConfig(bool Config)
        {
            if (Config == true)
            {
                CkBBringAllRecords.CheckedChanged += CkBBringAllRecords_CheckedChanged;
                RBtStart.CheckedChanged += RBtStart_CheckedChanged;
                RBtEnd.CheckedChanged += RBtEnd_CheckedChanged;
                RBtContain.CheckedChanged += RBtContain_CheckedChanged;
                NUDMinimum.ValueChanged += NUDMinimum_ValueChanged;
            }
            else
            {
                CkBBringAllRecords.CheckedChanged -= CkBBringAllRecords_CheckedChanged;
                RBtStart.CheckedChanged -= RBtStart_CheckedChanged;
                RBtEnd.CheckedChanged -= RBtEnd_CheckedChanged;
                RBtContain.CheckedChanged -= RBtContain_CheckedChanged;
                NUDMinimum.ValueChanged -= NUDMinimum_ValueChanged;
            }
        }

        private void DataGridViewConfig()
        {
            for (int i = 0; i < DGVSearch.Columns.Count; i++)
            {
                if (DGVSearch.Columns[i].Name.ToUpper() == "Nome".ToUpper())
                {
                    DGVSearch.Columns[i].Visible = true;
                    DGVSearch.Columns[i].HeaderText = FormText;
                    DGVSearch.Columns[i].Width = TxBDescription.Width - (DGVSearch.RowHeadersWidth + 5);
                }
                else
                    DGVSearch.Columns[i].Visible = false;
            }
        }

        private void SearchF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DGVSearch.Rows.Count > 0)
            {
                Current = DGVSearch.CurrentRow.Index;
                IdValue = DGVSearch.Rows[Current].Cells["Codigo"].Value.ToString();
                NameValue = DGVSearch.Rows[Current].Cells["Nome"].Value.ToString();

                TableFilter = new DataTable();
                foreach (DataGridViewColumn column in DGVSearch.Columns)
                    TableFilter.Columns.Add(column.Name);

                DataRow row = TableFilter.NewRow();
                row["Codigo"] = IdValue;
                row["Nome"] = NameValue;
                TableFilter.Rows.Add(row);

                Current = 0;
            }
        }
    }
}
