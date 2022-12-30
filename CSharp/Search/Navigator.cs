using System;
using System.Data;
using System.Windows.Forms;
using Database.Entity;
using Entity;
using Objects;
using Objects.Enumerator;
using Search.Entity;

namespace Search
{
    public partial class NavigatorF : Form
    {
        public Look LookControls;
        public Access AccessSystem;
        public DataFilters DataFilter;
        public Form FormNavigator;
        public SystemEnum Task;
        public DataPrivilege ControlPrivilege;
        public string ItemPrivilege;
        public int Current;

        private int Quantity;

        public NavigatorF()
        {
            InitializeComponent();
        }

        private void NavigatorF_Shown(object sender, EventArgs e)
        {
            AccessSystem.AccessIns(((Form)sender).Name, SystemEnum.Form_In);
            LookControls.Form(this, Images, TTpDica);

            Quantity = DataFilter.DataTableFilter.Rows.Count;

            FormConfig();
            Enable();
            Position();
        }

        private void NavigatorF_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Up) ||
                (e.KeyCode == Keys.Left) ||
                (e.KeyCode == Keys.Right) ||
                (e.KeyCode == Keys.Down))
            {
                if (Quantity >= 1)
                {
                    if (e.KeyCode == Keys.Up)
                        BtnFirst_Click(sender, e);
                    else if (e.KeyCode == Keys.Left)
                        BtnPrior_Click(sender, e);
                    else if (e.KeyCode == Keys.Right)
                        BtnNext_Click(sender, e);
                    else if (e.KeyCode == Keys.Down)
                        BtnLast_Click(sender, e);
                }
            }
            else if (e.KeyCode == Keys.Escape)
                BtnExit_Click(sender, e);
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            Current = 0;

            Enable();
            Position();
        }

        private void BtnPrior_Click(object sender, EventArgs e)
        {
            Current--;

            Enable();
            Position();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            Current++;

            Enable();
            Position();
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            Current = Quantity - 1;

            Enable();
            Position();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Task = SystemEnum.Form_Out;

            this.Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            AccessSystem.AccessIns(DataFilter.Form, SystemEnum.Table_Update);
            Task = SystemEnum.Table_Update;

            this.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            AccessSystem.AccessIns(DataFilter.Form, SystemEnum.Table_Delete);
            Task = SystemEnum.Table_Delete;

            this.Close();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            AccessSystem.AccessIns(DataFilter.Form, SystemEnum.Table_Select);
            Task = SystemEnum.Table_Select;

            this.Close();
        }

        private void FormConfig()
        {
            Task = SystemEnum.Table_Select;

            this.Left = FormNavigator.Left;
            this.Top = FormNavigator.Top;
        }

        private void Enable()
        {
            if (Quantity == 0)
            {
                BtnFirst.Enabled = false;
                BtnPrior.Enabled = false;
                BtnNext.Enabled = false;
                BtnLast.Enabled = false;
            }
            else
            {
                if (Current < 0)
                    Current = 0;
                else if (Current >= Quantity)
                    Current = Quantity - 1;

                if (Current == 0)
                {
                    BtnFirst.Enabled = false;
                    BtnPrior.Enabled = false;
                }
                else
                {
                    BtnFirst.Enabled = true;
                    BtnPrior.Enabled = true;
                }

                if ((Current + 1) == Quantity)
                {
                    BtnNext.Enabled = false;
                    BtnLast.Enabled = false;
                }
                else
                {
                    BtnNext.Enabled = true;
                    BtnLast.Enabled = true;
                }
            }
        }

        private void Position()
        {
            DataFilter.DataTableNavigator.Clear();
            DataRow row = DataFilter.DataTableNavigator.NewRow();

            foreach (DataColumn column in DataFilter.DataTableFilter.Columns)
            {
                for (int i = 0; i < DataFilter.PrimaryKeyList.Length; i++)
                {
                    if (column.ColumnName.ToUpper() == DataFilter.PrimaryKeyList[i].ToUpper())
                        row[column.ColumnName] = DataFilter.DataTableFilter.Rows[Current][column.ColumnName];
                }
            }

            DataFilter.DataTableNavigator.Rows.Add(row);

            this.Text = String.Concat("Total records: ", Quantity.ToString(), " | Current record: ", (Current + 1).ToString());
        }

        private void PrivilegesControls()
        {
            RecordEnum CRUDRecord = RecordEnum.Select;

            ControlPrivilege.ItemPrivilege = ItemPrivilege;

            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                    CRUDRecord = RecordEnum.Insert;
                else if (i == 1)
                    CRUDRecord = RecordEnum.Update;

                ControlPrivilege.Privilege(CRUDRecord, ControlProperty.Visible);
            }

            if (BtnUpdate.Visible == false)
                BtnDelete.Left = BtnUpdate.Left;
        }

        private void NavigatorF_FormClosing(object sender, FormClosingEventArgs e)
        {
            AccessSystem.AccessIns(((Form)sender).Name, SystemEnum.Form_Out);
        }
    }
}
