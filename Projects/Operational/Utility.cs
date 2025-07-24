using System;
using System.Data;
using System.Windows.Forms;

namespace Operational
{
    public sealed class Utility
    {
        public Utility()
        {
        }

        public void TableRows(DataTable Table)
        {
            if (Table.Rows.Count == 0)
                MessageBox.Show("No data found in table object !");
            else
            {
                foreach (DataRow Row in Table.Rows)
                {
                    foreach (DataColumn Column in Table.Columns)
                        MessageBox.Show(String.Concat(Column.ColumnName, " : ", Row[Column.ColumnName].ToString()));
                }
            }
        }
    }
}
