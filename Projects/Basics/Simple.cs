using System;
using System.Windows.Forms;
using Basics;
using Database;
using Database.Entity;
using Entity;
using Entity.Objects;
using Objects;
using Objects.Enumerator;
using Operational;

namespace Basics
{
    public partial class SimpleF : Form
    {
        public Command CommandDb;
        public DataTables Configuration;
        public Look LookControls;
        public IdNameTuple TupleIdName;
        public RecordEnum CRUDRecord;
        public string ItemPrivilege;

        public SimpleF()
        {
            InitializeComponent();
        }

        private void SimpleF_Shown(object sender, EventArgs e)
        {
            LookControls.CRUDButton(PnlPanel1, CRUDRecord);
            LookControls.TextLabel(this, CRUDRecord, TupleIdName.FormText);
            LookControls.Form(this, Images, TTpTip);
            ControlsVisible();
        }

        private void SimpleF_KeyDown(object sender, KeyEventArgs e)
        {
            Keys KeyPressed = Key.Pressed(sender, e);

            if (KeyPressed == Keys.Enter)
            {
                if (TxBId.Visible == false)
                    BtnIUD_Click(sender, e);
            }
            else if (KeyPressed == Keys.Escape)
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
            ControlsFocus();
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            using (SearchDataListF SearchForm = new SearchDataListF())
            {
                try
                {
                    SearchForm.TxBDescription.CharacterCasing = CharacterCasing.Upper;
                    SearchForm.CommandDb = CommandDb;
                    SearchForm.Configuration = Configuration;
                    SearchForm.LookControls = LookControls;
                    SearchForm.CRUDRecord = CRUDRecord;
                    SearchForm.TableConfigSearch = TupleIdName.TableConfigSearch;
                    SearchForm.ItemPrivilege = ItemPrivilege;
                    SearchForm.BtnReport.Visible = BtnReport.Visible;
                    SearchForm.Text = TupleIdName.FormText;
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

        private void ControlsVisible()
        {
            if (TxBId.Visible == true)
            {
                TxBDescription.Left = TxBDescription.Left + TxBId.Width + 2;
                TxBDescription.Width = TxBDescription.Width - (TxBId.Width + 2);
            }
        }

        private void ControlsFocus()
        {
            if (TxBId.Visible == true)
                LookControls.ObjectFocus(TxBId);
            else
                LookControls.ObjectFocus(TxBDescription);
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
            {
                PnlPanel2.Enabled = true;
                TxBId.Enabled = false;

                if (CRUDRecord == RecordEnum.Insert)
                {
                    if (TxBId.Visible == true)
                        TxBId.Enabled = true;
                }
            }
        }
    }
}
