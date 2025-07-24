using System;
using System.Data;
using System.Drawing;
using Objects.Enumerator;

namespace Objects
{
    public sealed class DataTableCommand
    {
        public DataTableCommand()
        {
        }

        private void PrimaryKey(DataTable Table, string[] MatrixColumn)
        {
            DataColumn[] Key = new DataColumn[MatrixColumn.Length];
            for (int i = 0; i < Key.Length; i++)
                Key[i] = Table.Columns[MatrixColumn[i]];

            Table.PrimaryKey = Key;
        }

        public void PrimaryColumnKey(DataTable Table, string Column)
        {
            string[] MatrixColumn = Matrix.Config(";", Column);

            PrimaryKey(Table, MatrixColumn);
        }

        public void PrimaryColumnKey(DataTable Table, string[] MatrixColumn)
        {
            PrimaryKey(Table, MatrixColumn);
        }

        public void Register(DataTable Table, DataRow DataRecord, RecordEnum TableRecord)
        {
            if (TableRecord == RecordEnum.Insert)
                Table.Rows.Add(DataRecord);
            else if (TableRecord == RecordEnum.Update)
                Table.AcceptChanges();
        }

        public DataRow Posicion(DataTable Table, string Search)
        {
            DataRow Result = null;
            string[] MatrixSearch = Matrix.Config("|", Search);

            Object[] CompoundSearch = new Object[Table.PrimaryKey.Length];
            for (int i = 0; i < CompoundSearch.Length; i++)
                CompoundSearch[i] = MatrixSearch[i];

            Result = Table.Rows.Find(CompoundSearch);

            return Result;
        }

        public bool Find(DataTable Table, string Search)
        {
            bool Result = false;

            if (Posicion(Table, Search) != null)
                Result = true;

            return Result;
        }

        public string UniqueValueColumn(DataRow DataRecord)
        {
            string Result = "";

            try
            {
                string[] Value = (string[])DataRecord["Value"];
                Result = Value[0];
            }
            catch
            {
                try
                {
                    string Value = (string)DataRecord["Value"];
                    Result = Value;
                }
                catch
                {
                    string Value = Convert.ToString(DataRecord["Value"]);
                    Result = Value;
                }
            }

            return Result;
        }

        public string UniqueValue(DataTable Table, string Search)
        {
            string Result = "";

            DataRow DataRecord = Posicion(Table, Search);
            if (DataRecord != null)
                Result = UniqueValueColumn(DataRecord);

            return Result;
        }

        public Color ColorValue(DataTable Table, string Search)
        {
            Color Result = Color.White;

            DataRow DataRecord = Posicion(Table, Search);
            if (DataRecord != null)
                Result = (Color)DataRecord["Color"];

            return Result;
        }

        public string[] MatrixValueColumn(DataRow DataRecord)
        {
            string[] Result = null;

            Result = (string[])DataRecord["Value"];

            return Result;
        }

        public string[] MatrixValue(DataTable Table, string Search)
        {
            string[] Result = null;

            DataRow DataRecord = Posicion(Table, Search);
            if (DataRecord != null)
                Result = MatrixValueColumn(DataRecord);

            return Result;
        }

        public void UniqueRegister(DataTable Table, string Value)
        {
            string[] MatrixInsert = Matrix.Config("|", Value);
            RecordEnum TableRecord = new RecordEnum();

            if (MatrixInsert.Length <= Table.Columns.Count)
            {
                TableRecord = RecordEnum.Update;

                DataRow DataRecord = Posicion(Table, Value);
                if (DataRecord == null)
                {
                    DataRecord = Table.NewRow();
                    TableRecord = RecordEnum.Insert;
                }

                for (int i = 0; i < MatrixInsert.Length; i++)
                {
                    if (DataRecord[i].ToString() != MatrixInsert[i].ToString())
                        DataRecord[i] = MatrixInsert[i];
                }

                Register(Table, DataRecord, TableRecord);
            }
        }

        public void MatrixRegister(DataTable Table, string Value)
        {
            string[] MatrixInsert = Matrix.Config("|", Value);
            RecordEnum TableRecord = new RecordEnum();

            if (MatrixInsert.Length <= Table.Columns.Count)
            {
                TableRecord = RecordEnum.Update;

                DataRow DataRecord = Posicion(Table, Value);
                if (DataRecord == null)
                {
                    DataRecord = Table.NewRow();
                    TableRecord = RecordEnum.Insert;
                }

                for (int i = 0; i < MatrixInsert.Length; i++)
                {
                    if (i <= MatrixInsert.Length - 2)
                    {
                        if (DataRecord[i].ToString() != MatrixInsert[i].ToString())
                            DataRecord[i] = MatrixInsert[i];
                    }
                    else
                    {
                        string[] RegisterRead = null;
                        string[] RegisterDataRecord = new string[1] { MatrixInsert[i] };

                        if (String.IsNullOrEmpty(DataRecord[i].ToString()) == false)
                            RegisterRead = (string[])DataRecord[i];

                        if (RegisterRead == null)
                            DataRecord[i] = RegisterDataRecord;
                        else
                        {
                            if (RegisterRead[0].ToString() != MatrixInsert[i].ToString())
                                DataRecord[i] = RegisterDataRecord;
                        }
                    }
                }

                Register(Table, DataRecord, TableRecord);
            }
        }

        public void MatrixRegister(DataTable Table, string CharacterValue, string[] MatrixValue)
        {
            string[] MatrixInsert = Matrix.Config("|", CharacterValue);
            string ColumnValue = Table.Columns[Table.Columns.Count - 1].ColumnName;
            RecordEnum TableRecord = new RecordEnum();

            if (MatrixInsert.Length <= Table.Columns.Count)
            {
                TableRecord = RecordEnum.Update;

                DataRow DataRecord = Posicion(Table, CharacterValue);
                if (DataRecord == null)
                {
                    DataRecord = Table.NewRow();
                    TableRecord = RecordEnum.Insert;
                }

                if (TableRecord == RecordEnum.Update)
                {
                    for (int i = 0; i < MatrixInsert.Length; i++)
                    {
                        if (DataRecord[i].ToString() != MatrixInsert[i].ToString())
                            DataRecord[i] = MatrixInsert[i];
                    }

                    string[] RegisterRead = null;

                    if (String.IsNullOrEmpty(DataRecord[ColumnValue].ToString()) == true)
                        RegisterRead = new string[MatrixValue.Length];
                    else
                        RegisterRead = (string[])DataRecord[ColumnValue];

                    if (RegisterRead.Length == MatrixValue.Length)
                    {
                        for (int ii = 0; ii < RegisterRead.Length; ii++)
                            DataRecord[ColumnValue] = MatrixValue;
                    }
                    else
                        DataRecord[ColumnValue] = MatrixValue;
                }

                Register(Table, DataRecord, TableRecord);
            }
        }

        public string KeyValue(DataTable Table, string User, string Key)
        {
            string Result = "";

            if (Find(Table, String.Concat(User, "|", Key.ToUpper())) == true)
                Result = UniqueValue(Table, String.Concat(User, "|", Key.ToUpper()));

            return Result;
        }

        public string ColumnsName(DataTable Table)
        {
            string Result = "";

            foreach (DataColumn column in Table.Columns)
                Result = String.Concat(Result, "\r\n", column);

            return Result;
        }
    }
}
