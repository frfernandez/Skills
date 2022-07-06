using System;
using System.Windows.Forms;
using Database;
using Entity.Objects;
using Objects;
using Objects.Enumerator;

namespace Basics
{
    public partial class SimpleF : Form
    {
        public Command CommandDb;
        public Look LookControls;
        public IdNameTuple TupleIdName;
        public RecordEnum CRUDRecord;

        public SimpleF()
        {
            InitializeComponent();
        }

        private void SimpleF_Shown(object sender, EventArgs e)
        {
            LookControls.CRUDButton(PnlPainel1, CRUDRecord);
            LookControls.TextLabel(this, CRUDRecord, TupleIdName.FormText);
        }

        private void SimpleF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnIAE_Click(sender, e);
            else if (e.KeyCode == Keys.Escape)
                BtnSaida_Click(sender, e);
        }

        private void BtnIAE_Click(object sender, EventArgs e)
        {
            if (TupleIdName.Save(TxBCodigo.Text, TxBDescricao.Text))
            {
                CRUDConfig();
                BtnCancela_Click(sender, e);
            }
        }

        private void BtnCancela_Click(object sender, EventArgs e)
        {
            Values.PanelClean(PnlPainel2);

            CRUDRecord = RecordEnum.Insert;
            LookControls.CRUDButton(PnlPainel1, CRUDRecord);
            LookControls.TextLabel(this, CRUDRecord, TupleIdName.FormText);
        }

        private void BtnFiltro_Click(object sender, EventArgs e)
        {
            using (SearchDataF SearchForm = new SearchDataF())
            {
                try
                {
                    SearchForm.TxBDescricao.CharacterCasing = CharacterCasing.Upper;
                    SearchForm.CommandDb = CommandDb;
                    SearchForm.LookControls = LookControls;
                    SearchForm.CRUDRecord = CRUDRecord;
                    SearchForm.TableConfigSearch = TupleIdName.TableConfigSearch;
                    SearchForm.TableList = TupleIdName.SelectDataTable("");
                    SearchForm.Text = TupleIdName.FormText;
                    SearchForm.ParameterId = SearchForm.TableList.Columns[0].ColumnName;
                    SearchForm.ParameterName = SearchForm.TableList.Columns[1].ColumnName;
                    SearchForm.ShowDialog();
                }
                finally
                {
                    if (String.IsNullOrEmpty(SearchForm.IdValue) == false)
                    {
                        TxBCodigo.Text = SearchForm.IdValue;
                        TxBDescricao.Text = SearchForm.NameValue;

                        CRUDRecord = SearchForm.CRUDRecord;
                        LookControls.CRUDButton(PnlPainel1, CRUDRecord);
                        LookControls.TextLabel(this, CRUDRecord, TupleIdName.FormText);
                    }

                    SearchForm.Dispose();
                }
            }
        }

        private void BtnSaida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CRUDConfig()
        {
            if (CRUDRecord == RecordEnum.Insert)
                TupleIdName.Insert();
            else if (CRUDRecord == RecordEnum.Update)
                TupleIdName.Update();
            else if (CRUDRecord == RecordEnum.Delete)
                TupleIdName.Delete();
        }
    }
}
