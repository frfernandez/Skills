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

        private void BtnEscreve_Click(object sender, EventArgs e)
        {
            DGVSearch_Click(sender, e);

            if (GBxCadastro.Visible == true)
            {
                if (RBtAlterar.Checked == true)
                    CRUDRecord = RecordEnum.Update;
                else if (RBtExcluir.Checked == true)
                    CRUDRecord = RecordEnum.Delete;
            }
            else
                CRUDRecord = RecordEnum.Insert;

            this.Close();
        }

        private void BtnFiltro_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxBDescricao.Text) == true)
            {
                TableFilter.DefaultView.RowFilter = "";
                EntityClear();
            }
            else
            {
                TableFilter.DefaultView.RowFilter = String.Format(String.Concat(ParameterName, " Like '*{0}*'"), TxBDescricao.Text);
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

        public void BtnSaida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnEscreve_Click(sender, e);
            else if (e.KeyCode == Keys.Escape)
                BtnSaida_Click(sender, e);
        }

        private void DGVSearch_Click(object sender, EventArgs e)
        {
            if (DGVSearch.CurrentRow != null)
            {
                NameValue = DGVSearch.Rows[DGVSearch.CurrentRow.Index].Cells[ParameterName].Value.ToString();
                TxBDescricao.Text = NameValue;
                BtnFiltro_Click(sender, e);
            }
        }

        private void DGVSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
                LookControls.ObjectFocus(TxBDescricao);
            else
                TxBDescricao.Text = DGVSearch.CurrentRow.Cells[ParameterName].Value.ToString();
        }

        private void DGVSearch_DoubleClick(object sender, EventArgs e)
        {
            DGVSearch_Click(sender, e);

            BtnEscreve_Click(sender, e);
        }

        private void FormConfig()
        {
            if (CRUDRecord == RecordEnum.Select)
                GBxCadastro.Visible = false;
            else
                GBxCadastro.Visible = true;

            if (GBxCadastro.Visible == true)
            {
                if ((RBtAlterar.Visible == true) &&
                    (RBtExcluir.Visible == false))
                    RBtAlterar.Checked = RBtAlterar.Visible;
                else if ((RBtAlterar.Visible == false) &&
                         (RBtExcluir.Visible == true))
                    RBtExcluir.Checked = RBtExcluir.Visible;
                else
                    RBtAlterar.Checked = RBtAlterar.Visible;
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
            DGVSearch.Columns[1].HeaderText = Text;
            DGVSearch.Columns[1].Width = TxBDescricao.Width - (DGVSearch.RowHeadersWidth + 5);

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

        private void SearchDataF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DGVSearch.CurrentRow != null)
                Current = DataGridViewBind.Position;
        }
    }
}
