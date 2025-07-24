using System;
using System.Data;
using System.Windows.Forms;
using Database;
using Database.Entity;
using Entity;
using Objects;
using Objects.Enumerator;
using Operational;

namespace Basics
{
    public partial class SearchDataF : Form
    {
        public Command CommandDb;
        public DataTables Configuration;
        public Look LookControls;
        public RecordEnum CRUDRecord;
        public string IdValue;
        public string NameValue;
        public string TableConfigSearch;
        public DataTable TableList;
        public DataTable TableFilter;
        public string ItemPrivilege;
        public string TypeViewFilter;
        public int Current;

        private string FormText;

        private DataEntities DataEntity;
        private DataFinder DataFind;

        public SearchDataF()
        {
            InitializeComponent();
        }

        public void SearchF_Shown(object sender, EventArgs e)
        {
            LookControls.Form(this, Images, TTpTip);

            DataEntity = new DataEntities(CommandDb, Configuration);
            DataEntity.Initialize = false;

            DataFind = new DataFinder();
            DataFind.TextBoxSearch = TxBDescription;
            DataFind.DGVSearch = DGVSearch;
            DataFind.TextChanged += TxBDescription_TextChanged;
            DataFind.TableList = TableList;

            PrivateConfig();
            DataFind.Config();
            DataGridViewConfig();
            DataFind.SearchControlConfig("");
            FormConfig();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if ((DataFind.DataGridViewBind.Position == 0) && (String.IsNullOrEmpty(TxBDescription.Text) == true))
            {
                DataFind.EntityClear();
                TxBDescription.Text = DGVSearch.Rows[DataFind.DataGridViewBind.Position].Cells[DataFind.ParameterName].Value.ToString();
            }

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

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            DataEntity.AbstractEntity(TableConfigSearch, this.Name);
            DGVSearch.DataSource = DataEntity.SelectDataTable(TableConfigSearch, "", TxBDescription.Text);

            if (DGVSearch.Rows.Count == 0)
            {
                BtnFilter.Visible = true;
                BtnSelect.Visible = false;
            }
            else
            {
                BtnFilter.Visible = false;
                BtnSelect.Visible = true;
            }
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
            if ((TypeViewFilter == "N") ||
                (TypeViewFilter == "S"))
                DataFind.FindTyping();
        }

        private void DGVSearch_Click(object sender, EventArgs e)
        {
            if (DGVSearch.CurrentRow != null)
                DataFind.FindSelecting();
        }

        private void DGVSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
                LookControls.ObjectFocus(TxBDescription);
            else
                TxBDescription.Text = DGVSearch.CurrentRow.Cells[DataFind.ParameterName].Value.ToString();
        }

        private void DGVSearch_DoubleClick(object sender, EventArgs e)
        {
            DGVSearch_Click(sender, e);
            BtnSelect_Click(sender, e);
        }

        private void PrivateConfig()
        {
            FormText = Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(CommandDb.User, "|", TableConfigSearch, "_FormText"));
            DataFind.ParameterId = Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(CommandDb.User, "|", TableConfigSearch, "_ParameterId"));
            DataFind.ParameterName = Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(CommandDb.User, "|", TableConfigSearch, "_DataGridField"));

            TypeViewFilter = Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(CommandDb.User, "|", TableConfigSearch, "_TypeViewFilter"));
        }

        private void FormConfig()
        {
            if (TypeViewFilter == "N")
            {
                BtnSelect.Visible = true;
                BtnFilter.Visible = false;
            }
            else
            {
                BtnSelect.Visible = false;
                BtnFilter.Visible = true;
            }

            if (CRUDRecord == RecordEnum.Select)
                GBxRecord.Visible = false;
            else
            {
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
        }

        private void DataGridViewConfig()
        {
            DGVSearch.DataSource = TableList;

            for (int i = 0; i < DGVSearch.Columns.Count; i++)
            {
                if (DGVSearch.Columns[i].Name.ToUpper() == DataFind.ParameterName.ToUpper())
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
            if ((BtnSelect.Visible == true) && (DGVSearch.CurrentRow != null))
            {
                Current = DGVSearch.CurrentRow.Index;

                if (TypeViewFilter == "N")
                {
                    IdValue = DataFind.IdValue;
                    NameValue = DataFind.NameValue;
                }
                else
                {
                    IdValue = DGVSearch.Rows[DGVSearch.CurrentRow.Index].Cells[DataFind.ParameterId].Value.ToString();
                    NameValue = DGVSearch.Rows[DGVSearch.CurrentRow.Index].Cells[DataFind.ParameterName].Value.ToString();
                }

                TableFilter = DataFind.TableFilter;
            }
        }
    }
}
