using System;
using System.Data;
using System.Windows.Forms;
using Database;
using Database.Entity;
using Objects;
using Objects.Enumerator;
using Operational;

namespace Search
{
    public partial class DynamicSearchOrderF : Form
    {
        public Command CommandDb;
        public DataTables Configuration;
        public Look LookControls;
        public Access AccessSystem;
        public string IdProcedure;

        private DataTable TableFields;
        private DataTable TableOrders;
        private DataRow Row;

        private int Current;
        private int RowsCount;

        private DataFinder DataFind;

        public DynamicSearchOrderF()
        {
            InitializeComponent();
        }

        public void FilterOrderF_Shown(object sender, EventArgs e)
        {
            AccessSystem.AccessIns(((Form)sender).Name, SystemEnum.Form_In);
            LookControls.Form(this, Images, TTpTip);

            DataFind = new DataFinder();
            DataFind.TextBoxSearch = TxBDescription;
            DataFind.DGVSearch = DGVColumns;
            DataFind.TextChanged += TxBDescription_TextChanged;
            DataFind.TableList = Configuration.TableProcedureFields;
            DataFind.ParameterId = "Field";
            DataFind.ParameterName = "Field";
            DataFind.TypeViewFilter = "I";
            DataFind.Config();

            FormConfig();
            TableCopy();
            EnableAddRemove();
            EnableUpDown();

            LookControls.ObjectFocus(DGVColumns);
        }

        private void FilterOrderF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnConfirm_Click(sender, e);
            else if (Key.Pressed(sender, e) == Keys.Escape)
                BtnExit_Click(sender, e);
        }

        private void FilterOrderF_KeyUp(object sender, KeyEventArgs e)
        {
            if ((Key.Pressed(sender, e) == Keys.Up) || (Key.Pressed(sender, e) == Keys.Down))
                EnableUpDown();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            IDbCommand CommandIDb;
            DataTable Table;

            RowsCount = Configuration.TableOrders.Rows.Count - 1;
            CommandIDb = CommandDb.CommandConfig("P", "DelFiltersOrders");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "IdProcedure", IdProcedure);
                CommandDb.ParameterInput(CommandIDb, "Indexer", RowsCount.ToString());
                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
            }

            CommandIDb = CommandDb.CommandConfig("P", "FltFiltersOrders");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "IdProcedure", IdProcedure);
                Table = CommandDb.DataSetDb(CommandIDb, "P").Tables[0];
                RowsCount = Table.Rows.Count;
            }
            finally
            {
                CommandIDb.Dispose();
            }

            CommandIDb = CommandDb.CommandConfig("P", "UpdFiltersOrders");

            try
            {
                Current = 1;
                foreach (DataRow rowOrder in Configuration.TableOrders.Rows)
                {
                    CommandDb.ParameterInput(CommandIDb, "IdProcedimento", IdProcedure);
                    CommandDb.ParameterInput(CommandIDb, "Indexer", Current.ToString());
                    CommandDb.ParameterInput(CommandIDb, "Column", rowOrder["Field"].ToString());
                    CommandDb.ParameterInput(CommandIDb, "TypeOrder", rowOrder["Type"].ToString());
                    CommandIDb.ExecuteNonQuery();

                    Current += 1;
                    if (Current > RowsCount)
                        break;
                }
            }
            finally
            {
                CommandIDb.Dispose();
            }

            CommandIDb = CommandDb.CommandConfig("P", "InsFiltersOrders");

            try
            {
                Current = 1;
                foreach (DataRow rowOrder in Configuration.TableOrders.Rows)
                {
                    if (Current > RowsCount)
                    {
                        CommandDb.ParameterInput(CommandIDb, "IdProcedure", IdProcedure);
                        CommandDb.ParameterInput(CommandIDb, "Indexer", Current.ToString());
                        CommandDb.ParameterInput(CommandIDb, "Column", rowOrder["Field"].ToString());
                        CommandDb.ParameterInput(CommandIDb, "TypeOrder", rowOrder["Type"].ToString());
                        CommandIDb.ExecuteNonQuery();
                    }

                    Current += 1;
                }
            }
            finally
            {
                CommandIDb.Dispose();
            }

            BtnExit_Click(sender, e);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TableRetore();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (DGVColumns.CurrentRow != null)
            {
                DGVColumns_Click(sender, e);

                Row = Configuration.TableOrders.NewRow();
                Row["Field"] = TxBDescription.Text;

                if (RBtAscendent.Checked == true)
                    Row["Type"] = "A";
                else if (RBtDescendent.Checked == true)
                    Row["Type"] = "D";

                Configuration.TableOrders.Rows.Add(Row);

                DataFind.DataGridViewBind.RemoveAt(DataFind.DataGridViewBind.Position);

                EnableAddRemove();
                EnableUpDown();
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (DGVOrders.CurrentRow != null)
            {
                Row = DataFind.TableList.NewRow();
                Row["Field"] = Configuration.TableOrders.Rows[DGVOrders.CurrentRow.Index]["Field"];

                DataFind.TableList.Rows.Add(Row);

                Configuration.TableOrders.Rows.RemoveAt(DGVOrders.CurrentRow.Index);

                EnableAddRemove();
                EnableUpDown();
            }
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            Current = DGVOrders.CurrentRow.Index;

            if (Current > 0)
            {
                Row = Configuration.TableOrders.NewRow();
                Row["Field"] = Configuration.TableOrders.Rows[DGVOrders.CurrentRow.Index]["Field"];
                Row["Type"] = Configuration.TableOrders.Rows[DGVOrders.CurrentRow.Index]["Type"];

                Configuration.TableOrders.Rows.RemoveAt(DGVOrders.CurrentRow.Index);
                Configuration.TableOrders.Rows.InsertAt(Row, Current - 1);

                DGVOrders.CurrentCell = DGVOrders.Rows[Current - 1].Cells["Field"];

                EnableUpDown();
            }
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            Current = DGVOrders.CurrentRow.Index;

            if (Current < DGVOrders.Rows.Count - 1)
            {
                Row = Configuration.TableOrders.NewRow();
                Row["Field"] = Configuration.TableOrders.Rows[DGVOrders.CurrentRow.Index]["Field"];
                Row["Type"] = Configuration.TableOrders.Rows[DGVOrders.CurrentRow.Index]["Type"];

                Configuration.TableOrders.Rows.RemoveAt(DGVOrders.CurrentRow.Index);
                Configuration.TableOrders.Rows.InsertAt(Row, Current + 1);

                DGVOrders.CurrentCell = DGVOrders.Rows[Current + 1].Cells["Field"];

                EnableUpDown();
            }
        }

        public void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxBDescription_TextChanged(object sender, EventArgs e)
        {
            DataFind.FindTyping();
        }

        private void DGVColumns_Click(object sender, EventArgs e)
        {
            if (DGVColumns.CurrentRow != null)
                TxBDescription.Text = DGVColumns.Rows[DGVColumns.CurrentRow.Index].Cells["Field"].Value.ToString();
        }

        private void DGVColumns_DoubleClick(object sender, EventArgs e)
        {
            DGVColumns_Click(sender, e);
            BtnAdd_Click(sender, e);
        }

        private void DGVOrders_Click(object sender, EventArgs e)
        {
            EnableUpDown();
        }

        private void FormConfig()
        {
            DGVColumns.DataSource = DataFind.TableList;
            DGVColumns.Columns["Field"].Width = 615;

            DGVOrders.DataSource = Configuration.TableOrders;
            DGVOrders.Columns["Field"].Width = 565;
            DGVOrders.Columns["Type"].Width = 50;
        }

        private void TableCopy()
        {
            TableFields = Configuration.TableProcedureFields.Copy();
            TableOrders = Configuration.TableOrders.Copy();
        }

        private void TableRetore()
        {
            Configuration.TableProcedureFields.Clear();
            foreach (DataRow row in TableFields.Rows)
            {
                Row = Configuration.TableProcedureFields.NewRow();
                Row["Field"] = row["Field"];

                Configuration.TableProcedureFields.Rows.Add(Row);
            }

            Configuration.TableOrders.Clear();
            foreach (DataRow row in TableOrders.Rows)
            {
                Row = Configuration.TableOrders.NewRow();
                Row["Field"] = row["Field"];
                Row["Type"] = row["Type"];

                Configuration.TableOrders.Rows.Add(Row);
            }

            EnableAddRemove();
            EnableUpDown();
        }

        private void EnableAddRemove()
        {
            if (DGVColumns.Rows.Count == 0)
            {
                DataFind.TableList.Clear();

                BtnAdd.Enabled = false;
            }
            else
                BtnAdd.Enabled = true;

            if (DGVOrders.Rows.Count == 0)
            {
                Configuration.TableOrders.Clear();

                BtnRemove.Enabled = false;
            }
            else
                BtnRemove.Enabled = true;

        }

        private void EnableUpDown()
        {
            RowsCount = DGVOrders.Rows.Count;
            if (RowsCount > 1)
            {
                if (DGVOrders.CurrentRow != null)
                {
                    if (DGVOrders.CurrentRow.Index == 0)
                        BtnUp.Enabled = false;
                    else
                        BtnUp.Enabled = true;

                    if (DGVOrders.CurrentRow.Index == RowsCount - 1)
                        BtnDown.Enabled = false;
                    else
                        BtnDown.Enabled = true;
                }
            }
            else
            {
                BtnUp.Enabled = false;
                BtnDown.Enabled = BtnUp.Enabled;
            }
        }

        private void FilterOrderF_FormClosing(object sender, FormClosingEventArgs e)
        {
            AccessSystem.AccessIns(((Form)sender).Name, SystemEnum.Form_Out);
        }
    }
}
