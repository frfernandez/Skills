using System;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace Objects
{
    public class DataFinder
    {
        public TextBox TextBoxSearch;
        public DataGridView DGVSearch;
        public event EventHandler TextChanged;

        public DataTable TableList;
        public DataTable TableFilter;
        public BindingSource DataGridViewBind;

        public string IdValue;
        public string NameValue;
        public string ParameterId;
        public string ParameterName;

        private string Filter;
        private int SelectionStart;

        public DataFinder()
        {
        }

        public void Config()
        {
            TableFilter = TableList.Copy();

            FilterConfig();
            TableConfig();
            BindConfig();
            EntityClear();
        }

        public void SearchControlConfig(string Text)
        {
            TextBoxSearch.TextChanged -= TextChanged;
            TextBoxSearch.Text = Text;
            TextBoxSearch.TextChanged += TextChanged;
        }

        public void SearchSelectionStart(int SelectionStart)
        {
            TextBoxSearch.SelectionStart = SelectionStart;
            TextBoxSearch.SelectionLength = TextBoxSearch.Text.Length - SelectionStart;
        }

        public void FilterConfig()
        {
            Filter = String.Concat(ParameterName, " Like '{0}*'");
        }

        private void TableConfig()
        {
            TableList.DefaultView.Sort = ParameterName;
            TableFilter.DefaultView.Sort = ParameterName;
        }

        private void BindConfig()
        {
            if (DataGridViewBind == null)
                DataGridViewBind = new BindingSource();

            DataGridViewBind.DataSource = TableList;
        }

        public void ColorConfig(bool Enabled)
        {
            if (Enabled == true)
                TextBoxSearch.BackColor = Color.White;
            else
                TextBoxSearch.BackColor = Color.Red;
        }

        public void FindTyping()
        {
            TableFilter.DefaultView.RowFilter = String.Format(Filter, TextBoxSearch.Text);
            if (TableFilter.DefaultView.Count == 0)
            {
                DataGridViewBind.Position = -1;
                DGVSearch.CurrentCell = null;
                EntityClear();

                ColorConfig(false);
            }
            else
            {
                DataGridViewBind.Position = DataGridViewBind.Find(ParameterId, TableFilter.DefaultView[0][TableFilter.DefaultView[0].Row.Table.Columns[ParameterId].ToString()]);
                DGVSearch.CurrentCell = DGVSearch.Rows[DataGridViewBind.Position].Cells[ParameterName];
                IdValue = DGVSearch.CurrentRow.Cells[ParameterId].Value.ToString();
                NameValue = DGVSearch.Rows[DataGridViewBind.Position].Cells[ParameterName].Value.ToString();

                SelectionStart = TextBoxSearch.SelectionStart;
                SearchControlConfig(NameValue);
                SearchSelectionStart(SelectionStart);

                ColorConfig(true);
            }
        }

        public void FindSelecting()
        {
            if (DGVSearch.Rows.Count > 0)
            {
                IdValue = DGVSearch.Rows[DGVSearch.CurrentRow.Index].Cells[ParameterId].Value.ToString();
                Filter = String.Concat(ParameterId, " = '{0}'");
                TableFilter.DefaultView.RowFilter = String.Format(Filter, IdValue.ToString());
                NameValue = DGVSearch.Rows[DGVSearch.CurrentRow.Index].Cells[ParameterName].Value.ToString();

                SelectionStart = 0;
                SearchControlConfig(DGVSearch.CurrentRow.Cells[ParameterName].Value.ToString());
                SearchSelectionStart(SelectionStart);

                FilterConfig();
            }
        }

        public void EntityClear()
        {
            IdValue = "";
            NameValue = "";
        }
    }
}
