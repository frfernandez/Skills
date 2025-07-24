using System;
using Objects;

namespace Database.Entity
{
    public class AppConfigs
    {
        public DataTables Configuration { get; set; }
        public Command CommandDb { get; set; }

        public AppConfigs()
        {
        }

        public AppConfigs(Command commandDb, DataTables configuration)
        {
            CommandDb = commandDb;
            Configuration = configuration;
        }

        public void Save(string TableName, string Key, string Value)
        {
            Configuration.TableCommand.UniqueRegister(Configuration.TableConfig, String.Concat(CommandDb.User, "|", TableName, "_", Key, "|", Value));
        }
    }
}
