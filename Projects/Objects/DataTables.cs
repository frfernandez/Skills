using System.Data;
using System.Drawing;

namespace Objects
{
    public sealed class DataTables : DataTable
    {
        public DataTableCommand TableCommand { get; set; }
        public DataTable TableConfig;
        public DataTable TableControl;

        public DataTables()
        {
        }

        public DataTables(DataTableCommand tableCommand)
        {
            TableCommand = tableCommand;

            TableConfig = DataTableConfig();
            TableControl = null;
        }

        private DataTable DataTableConfig()
        {
            DataTable Result = new DataTable("Configurations");

            DataColumn User = new DataColumn("User", typeof(string));
            User.MaxLength = 255;
            User.AllowDBNull = false;
            User.Caption = "Users";

            DataColumn Key = new DataColumn("Key", typeof(string));
            Key.MaxLength = 255;
            Key.AllowDBNull = false;
            Key.Caption = "Keys";

            DataColumn Value = new DataColumn("Value", typeof(string));
            Value.MaxLength = 255;
            Value.AllowDBNull = true;
            Value.Caption = "Values";

            DataColumn ControlName = new DataColumn("ControlName", typeof(string));
            ControlName.MaxLength = 255;
            ControlName.AllowDBNull = true;
            ControlName.Caption = "ControlsNames";

            Result.Columns.Add(User);
            Result.Columns.Add(Key);
            Result.Columns.Add(Value);
            Result.Columns.Add(ControlName);

            TableCommand.PrimaryColumnKey(Result, "User;Key");

            return Result;
        }
    }
}
