using System;
using System.Data;
using Database;
using Objects;
using Objects.Enumerator;

namespace Entity
{
    public class DataFilters : IDisposable
    {
        public Command CommandDb { get; set; }
        public DataTables Configuration { get; set; }
        public string View;
        public string Form;
        public SystemEnum Task;
        public string TypeViewFilter = "N";
        public DataTable TableList;
        public DataTable DataTableFilter;
        public DataTable DataTableNavigator;
        public string[] ProcedureList = new string[0];
        public string[] PrimaryKeyList = new string[0];
        public string[] ParameterKeyList = new string[0];
        public string[] ParameterValueList = new string[0];
        public string[] ParameterKeyPublicList = new string[0];
        public string[] ParameterValuePublicList = new string[0];
        public string ProcedureOrder;

        private string CommandText;

        public DataFilters()
        {
        }

        public DataFilters(Command commandDb, DataTables configuration)
        {
            CommandDb = commandDb;
            Configuration = configuration;
        }

        public void Config()
        {
            IDbCommand CommandIDb;
            string PrimaryKey = "";
            string Procedure = "";
            string[] ViewList = new string[0];

            ViewList = Matrix.Config(";", View);

            CommandText = String.Concat("Select a.Parameter, a.Total\n",
                                        "From (Select a.Parameter, Count(*) Total\n",
                                        "      From (\n");

            for (int i = 0; i < ViewList.Length; i++)
            {
                CommandText = String.Concat(CommandText,
                                            "            Select Parameter\n",
                                            "            From ", View, "\n",
                                            "            Where PrimaryKey = 'Y'");

                if (i < ViewList.Length - 1)
                    CommandText = String.Concat(CommandText,
                                                "\n            Union All\n");
            }

            CommandText = String.Concat(CommandText,
                                        ") a\n",
                                        "      Group By a.Parameter) a\n",
                                        "Where a.Total = ", ViewList.Length.ToString(), "\n");

            CommandIDb = CommandDb.CommandConfig("S", CommandText);

            try
            {
                DataTable Table = CommandDb.DataSetDb(CommandIDb, "S").Tables[0];
                foreach (DataRow row in Table.Rows)
                    PrimaryKey = String.Concat(PrimaryKey, row["Parameter"], ";");

                PrimaryKey = PrimaryKey.Substring(0, PrimaryKey.Length - 1);
                PrimaryKeyList = Matrix.Config(";", PrimaryKey);
            }
            finally
            {
                CommandIDb.Dispose();
            }

            CommandText = "";

            for (int i = 0; i < ViewList.Length; i++)
            {
                CommandText = String.Concat(CommandText,
                                            "Select Distinct ProcedureFilter\n",
                                            "From ", View, "\n");

                if (i < ViewList.Length - 1)
                    CommandText = String.Concat(CommandText,
                                                "Union\n");
            }

            CommandIDb = CommandDb.CommandConfig("S", CommandText);

            try
            {
                DataTable Table = CommandDb.DataSetDb(CommandIDb, "S").Tables[0];
                foreach (DataRow row in Table.Rows)
                    Procedure = String.Concat(Procedure, row["ProcedureFilter"], ";");

                Procedure = Procedure.Substring(0, Procedure.Length - 1);
                ProcedureList = Matrix.Config(";", Procedure);
            }
            finally
            {
                CommandIDb.Dispose();
            }

            if (ViewList.Length == 1)
            {
                CommandText = String.Concat("Select Row_Number() Over(Order By a.Parameter) Id, a.*\n",
                                            "From (Select *\n",
                                            "      From ", View, ") a\n");
            }
            else
            {
                CommandText = String.Concat("Select Row_Number() Over(Order By a.Parameter) Id, a.*\n",
                                            "From (\n");

                for (int i = 0; i < ViewList.Length; i++)
                {
                    CommandText = String.Concat(CommandText,
                                                "      Select *\n",
                                                "      From ", View, "\n");

                    if (i < ViewList.Length - 1)
                        CommandText = String.Concat(CommandText,
                                                    "      Union\n");
                }

                CommandText = String.Concat(CommandText, "     ) a\n");
            }

            CommandText = String.Concat(CommandText,
                                        "Where a.Visible = 'Y'\n",
                                        "Order By a.LabelDataGridRow\n");

            if (Configuration.TableCommand.Find(Configuration.TableConfig, String.Concat(CommandDb.User, "|", "SELECT_LIKE")) == true)
                TypeViewFilter = Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(CommandDb.User, "|", "SELECT_LIKE".ToUpper()));
        }

        public DataTable SelectDataTable()
        {
            DataTable Result;
            IDbCommand CommandIDb = CommandDb.CommandConfig("S", CommandText);

            try
            {
                Result = CommandDb.DataSetDb(CommandIDb, "S").Tables[0];
                Configuration.TableCommand.PrimaryColumnKey(Result, "Id");
            }
            finally
            {
                CommandIDb.Dispose();
            }

            return Result;
        }

        public void DataTableNavigatorColumns()
        {
            string PrimaryColumnKey = "";

            if (DataTableNavigator != null)
                DataTableNavigator.Dispose();

            DataTableNavigator = new DataTable("Navigator");

            foreach (DataColumn column in DataTableFilter.Columns)
            {
                for (int i = 0; i < PrimaryKeyList.Length; i++)
                {
                    if (column.ColumnName.ToUpper() == PrimaryKeyList[i].ToUpper())
                    {
                        DataTableNavigator.Columns.Add(column.ColumnName);

                        PrimaryColumnKey = String.Concat(PrimaryColumnKey, column.ColumnName, ";");
                    }
                }
            }

            PrimaryColumnKey = PrimaryColumnKey.Substring(0, PrimaryColumnKey.Length - 1);
            Configuration.TableCommand.PrimaryColumnKey(DataTableNavigator, PrimaryColumnKey);
        }

        public void TableSort()
        {
            string Sort = "",
                   CodigoProcedimento = "",
                   TypeSort = "";
            DataTable Table;
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "FltProcedures");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Name", ProcedureOrder);
                CommandDb.ParameterInput(CommandIDb, "Search", "B");
                CommandDb.ParameterInputNull(CommandIDb);
                Table = CommandDb.DataSetDb(CommandIDb, "P").Tables[0];
                CodigoProcedimento = Table.Rows[0]["Id"].ToString();
            }
            finally
            {
                CommandIDb.Dispose();
            }

            CommandIDb = CommandDb.CommandConfig("P", "FltFiltersOrders");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "IdProcedure", CodigoProcedimento);
                CommandDb.ParameterInputNull(CommandIDb);
                Table = CommandDb.DataSetDb(CommandIDb, "P").Tables[0];
            }
            finally
            {
                CommandIDb.Dispose();
            }

            foreach (DataRow row in Table.Rows)
            {
                if (row["TypeOrder"].ToString() == "A")
                    TypeSort = "Asc";
                else if (row["TypeOrder"].ToString() == "D")
                    TypeSort = "Desc";

                Sort = String.Concat(Sort, row["ColumnName"], " ", TypeSort, ", ");
            }

            if (String.IsNullOrEmpty(Sort) == false)
            {
                Sort = Sort.Trim();
                Sort = Sort.Substring(0, Sort.Length - 1);
                DataTableFilter.DefaultView.Sort = Sort;
                DataTableFilter = DataTableFilter.DefaultView.ToTable();
            }
        }

        public DataTable TableResult(DataTable Table, string Procedure)
        {
            DataTable Result;

            IDbCommand CommandIDb = CommandDb.CommandConfig("P", Procedure);

            if (CommandDb.ParameterExist(CommandIDb, "Search") == true)
                CommandDb.ParameterInput(CommandIDb, "Search", "S");

            try
            {
                for (int i = 0; i < PrimaryKeyList.Length; i++)
                    CommandDb.ParameterInput(CommandIDb, PrimaryKeyList[i], Table.Rows[0][PrimaryKeyList[i]].ToString());

                CommandDb.ParameterInputNull(CommandIDb);
                Result = CommandDb.DataSetDb(CommandIDb, "P").Tables[0];
            }
            finally
            {
                CommandIDb.Dispose();
            }

            return Result;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
