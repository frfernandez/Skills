using System;
using System.Windows.Forms;
using Database;
using Entity.Objects;
using Objects;
using Objects.Enumerator;
using Operational;

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
            LookControls.CRUDButton(PnlPanel1, CRUDRecord);
            LookControls.TextLabel(this, CRUDRecord, TupleIdName.FormText);
        }

        private void SimpleF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnIUD_Click(sender, e);
            else if (Key.Pressed(sender, e) == Keys.Escape)
                BtnExit_Click(sender, e);
        }

        private void BtnIUD_Click(object sender, EventArgs e)
        {
            if (TupleIdName.Save(TxBId.Text, TxBDescription.Text))
            {
                CRUDConfig();
                CRUDRecord = RecordEnum.Insert;
                BtnCancel_Click(sender, e);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Values.PanelClean(PnlPanel2);

            CRUDRecord = RecordEnum.Insert;
            LookControls.CRUDButton(PnlPanel1, CRUDRecord);
            LookControls.TextLabel(this, CRUDRecord, TupleIdName.FormText);
            Enable();
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            using (SearchDataF SearchForm = new SearchDataF())
            {
                try
                {
                    SearchForm.TxBDescription.CharacterCasing = CharacterCasing.Upper;
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
                        TxBId.Text = SearchForm.IdValue;
                        TxBDescription.Text = SearchForm.NameValue;

                        CRUDRecord = SearchForm.CRUDRecord;
                        LookControls.CRUDButton(PnlPanel1, CRUDRecord);
                        LookControls.TextLabel(this, CRUDRecord, TupleIdName.FormText);
                        Enable();
                    }

                    SearchForm.Dispose();
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
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

        private void Enable()
        {
            BtnIUD.Enabled = true;

            if (CRUDRecord == RecordEnum.Delete)
                PnlPanel2.Enabled = false;
            else
                PnlPanel2.Enabled = true;
        }
    }
}
