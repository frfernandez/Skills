using System;
using System.Data;
using System.Windows.Forms;
using Database;
using Objects;
using Objects.Enumerator;

namespace Basics
{
    public partial class SearchDataF : Form
    {
        public Command CommandDb;
        public Look LookControls;
        public RecordEnum CRUDRecord;
        public string ParameterId;
        public string ParameterName;
        public string IdValue;
        public string NameValue;
        public string TableConfigSearch;
        public DataTable TableList;
        public DataTable TableFilter;
        public BindingSource DataGridViewBind;
        public int Current;

        public string FormText;

        public SearchDataF()
        {
            InitializeComponent();
        }

        public void SearchF_Shown(object sender, EventArgs e)
        {
            TableFilter = TableList.Copy();

            BindConfig();
            DataGridViewConfig();
            FormConfig();
            EntityClear();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
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
            if (String.IsNullOrEmpty(TxBDescription.Text) == true)
            {
                TableFilter.DefaultView.RowFilter = "";
                EntityClear();
            }
            else
            {
                TableFilter.DefaultView.RowFilter = String.Format(String.Concat(ParameterName, " Like '*{0}*'"), TxBDescription.Text);
                if (DGVSearch.CurrentRow != null)
                {
                    IdValue = DGVSearch.Rows[DGVSearch.CurrentRow.Index].Cells[ParameterId].Value.ToString();

                    DataGridViewBind.Position = DataGridViewBind.Find(ParameterId, IdValue);
                    TableFilter.DefaultView.RowFilter = "";
                    DGVSearch.CurrentCell = DGVSearch.Rows[DataGridViewBind.Position].Cells[ParameterName];
                    IdValue = DGVSearch.CurrentRow.Cells[ParameterId].Value.ToString();
                    NameValue = DGVSearch.Rows[DataGridViewBind.Position].Cells[ParameterName].Value.ToString();
                }
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
            else if (e.KeyCode == Keys.Escape)
                BtnExit_Click(sender, e);
        }

        private void DGVSearch_Click(object sender, EventArgs e)
        {
            if (DGVSearch.CurrentRow != null)
            {
                NameValue = DGVSearch.Rows[DGVSearch.CurrentRow.Index].Cells[ParameterName].Value.ToString();
                TxBDescription.Text = NameValue;
                BtnFilter_Click(sender, e);
            }
        }

        private void DGVSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
                LookControls.ObjectFocus(TxBDescription);
            else
                TxBDescription.Text = DGVSearch.CurrentRow.Cells[ParameterName].Value.ToString();
        }

        private void DGVSearch_DoubleClick(object sender, EventArgs e)
        {
            DGVSearch_Click(sender, e);
            BtnSelect_Click(sender, e);
        }

        private void FormConfig()
        {
            if (CRUDRecord == RecordEnum.Select)
                GBxRecord.Visible = false;
            else
                GBxRecord.Visible = true;

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

        private void BindConfig()
        {
            if (DataGridViewBind == null)
                DataGridViewBind = new BindingSource();

            DataGridViewBind.DataSource = TableList;
        }

        private void DataGridViewConfig()
        {
            DGVSearch.DataSource = TableFilter;
            DGVSearch.Columns[0].Visible = false;
            DGVSearch.Columns[1].HeaderText = FormText;
            DGVSearch.Columns[1].Width = TxBDescription.Width - (DGVSearch.RowHeadersWidth + 5);

            for (int i = 0; i < DGVSearch.Columns.Count; i++)
            {
                if (DGVSearch.Columns[i].Name.ToUpper() != ParameterName.ToUpper())
                    DGVSearch.Columns[i].Visible = false;
            }
        }

        public void EntityClear()
        {
            IdValue = "";
            NameValue = "";
        }

        private void SearchF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DGVSearch.CurrentRow != null)
                Current = DataGridViewBind.Position;
        }
    }
}
