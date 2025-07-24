using System;
using System.Data;
using System.Windows.Forms;
using Database;
using Basics;
using Entity;
using Objects;
using Objects.Enumerator;
using Operational;
using Entity.Rodonaves;

namespace Identification
{
    public partial class UsuariosF : Form
    {
        public Command CommandDb;
        public DataTables Configuration;
        public Look LookControls;
        public string ItemPrivilege;
        public DataFilters DataFilter;

        private RecordEnum CRUDRecord = RecordEnum.Insert;
        private Usuarios Usuario;
        private int Current = 0;

        public UsuariosF()
        {
            InitializeComponent();
        }

        private void UsuariosF_Shown(object sender, EventArgs e)
        {
            LookControls.CRUDButton(PnlPanel1, CRUDRecord);
            LookControls.TextLabel(this, CRUDRecord, "Usuarios");
            LookControls.Form(this, Images, TTpTip);

            Usuario = new Usuarios(CommandDb, Configuration);
            Usuario.Form = ((Form)sender).Name;
            Usuario.Task = SystemEnum.Table_Insert;

            FormConfig();
            EntityClear();
        }

        private void UsuariosF_KeyDown(object sender, KeyEventArgs e)
        {
            Keys KeyPressed = Key.Pressed(sender, e);

            if (KeyPressed == Keys.Escape)
                BtnExit_Click(sender, e);
            else if (KeyPressed == Keys.Cancel)
                MessageBox.Show("Sem privilégios de acesso ao item de menu.");
        }

        private void BtnIUD_Click(object sender, EventArgs e)
        {
            if (CRUDRecord == RecordEnum.Delete)
            {
                CRUDConfig();
                BtnCancel_Click(sender, e);
            }
            else
            {
                if (Usuario.Save(TxBCodigo.Text, TxBLogin.Text, TxBSenha.Text, Values.CheckBoxValue(CkBStatus)) == true)
                {
                    CRUDConfig();
                    BtnCancel_Click(sender, e);
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Values.PanelClean(PnlPanel2);

            CRUDRecord = RecordEnum.Insert;
            LookControls.CRUDButton(PnlPanel1, CRUDRecord);
            LookControls.TextLabel(this, CRUDRecord, "Usuarios");
            LookControls.ObjectFocus(TxBLogin);

            EntityClear();
            Enable();
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            EntityClear();

            using (SearchDataListF SearchForm = new SearchDataListF())
            {
                try
                {
                    SearchForm.TxBDescription.CharacterCasing = CharacterCasing.Upper;
                    SearchForm.CommandDb = CommandDb;
                    SearchForm.Configuration = Configuration;
                    SearchForm.LookControls = LookControls;
                    SearchForm.CRUDRecord = CRUDRecord;
                    SearchForm.TableConfigSearch = "Usuarios";
                    SearchForm.ItemPrivilege = ItemPrivilege;
                    SearchForm.Text = "Usuarios";
                    SearchForm.ShowDialog();
                }
                finally
                {
                    if (String.IsNullOrEmpty(SearchForm.IdValue) == false)
                    {
                        Current = SearchForm.Current;
                        Data(SearchForm.TableFilter);

                        CRUDRecord = SearchForm.CRUDRecord;
                        LookControls.CRUDButton(PnlPanel1, CRUDRecord);
                        LookControls.TextLabel(this, CRUDRecord, "Usuarios");
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

        private void FormConfig()
        {
            if (DataFilter.DataTableFilter != null)
            {
                BtnCancel.Visible = false;
                BtnFilter.Visible = false;

                BtnExit.Left = BtnCancel.Left;
            }
        }

        private void CRUDConfig()
        {
            if (CRUDRecord == RecordEnum.Insert)
                Usuario.Insert();
            else if (CRUDRecord == RecordEnum.Update)
                Usuario.Update();
            else if (CRUDRecord == RecordEnum.Delete)
                Usuario.Delete();
        }

        private void EntityClear()
        {
            Usuario.Codigo = "";
            Usuario.Login = "";
        }

        private void Enable()
        {
            BtnIUD.Enabled = true;

            if (CRUDRecord == RecordEnum.Delete)
                PnlPanel2.Enabled = false;
            else
                PnlPanel2.Enabled = true;
        }

        private void Data(DataTable Table)
        {
            if (Table.TableName.ToUpper() == "Navigator".ToUpper())
                Current = 0;

            DataFilter.View = "VwUsuarios";
            DataFilter.Form = ((Form)this).Name;
            DataFilter.Config();
            Table = DataFilter.TableResult(Table, "FltUsuarios");

            TxBCodigo.Text = Table.Rows[Current]["Codigo"].ToString();
            TxBLogin.Text = Table.Rows[Current]["Login"].ToString();
            TxBSenha.Text = Table.Rows[Current]["Senha"].ToString();
            Values.CheckBoxPosition(CkBStatus, Table.Rows[0]["Status"].ToString());

            Usuario.Codigo = TxBCodigo.Text;
        }

        private void RowChanged(object sender, DataRowChangeEventArgs e)
        {
            Data(DataFilter.DataTableNavigator);
        }

        private void Usuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            Usuario.Dispose();
        }
    }
}
