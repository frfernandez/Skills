using System;
using System.Data;
using Database;
using Entity.Map;
using Entity.Identification;
using Entity.Person;
using Objects;
using Objects.Enumerator;
using Operational;

namespace Search.Entity
{
    public class DataEntities : IDisposable
    {
        public Command CommandDb { get; set; }
        public Messages MessagesDb { get; set; }
        public DataTables Configuration { get; set; }

        private Cities City;
        private Countries Country;
        private States State;
        private Continents Continent;
        private Districts District;
        private Addresses Address;
        private Neighborhoods Neighborhood;
        private Documents Documento;
        private DocumentsTypes DocumentType;
        private Verifiers Verifier;
        private Persons Person;
        private CommunicationsTypes CommunicationType;

        public DataEntities()
        {
        }

        public DataEntities(Command commandDb, Messages messagesDb, DataTables configuration)
        {
            CommandDb = commandDb;
            MessagesDb = messagesDb;
            Configuration = configuration;
        }

        public void AbstractEntity(string DataClass, string Form)
        {
            DataClass = DataClass.ToUpper();

            if (DataClass == "Cities".ToUpper())
            {
                City = new Cities(CommandDb, MessagesDb, Configuration);
                City.Form = Form;
                City.Equipment = Hardware.Label().Trim().ToUpper();
                City.Task = SystemEnum.Table_Select;
            }
            else if (DataClass == "Countries".ToUpper())
            {
                Country = new Countries(CommandDb, MessagesDb, Configuration);
                Country.Form = Form;
                Country.Equipment = Hardware.Label().Trim().ToUpper();
                Country.Task = SystemEnum.Table_Select;
            }
            else if (DataClass == "States".ToUpper())
            {
                State = new States(CommandDb, MessagesDb, Configuration);
                State.Form = Form;
                State.Equipment = Hardware.Label().Trim().ToUpper();
                State.Task = SystemEnum.Table_Select;
            }
            else if (DataClass == "Continents".ToUpper())
            {
                Continent = new Continents(CommandDb, MessagesDb, Configuration);
                Continent.Form = Form;
                Continent.Equipment = Hardware.Label().Trim().ToUpper();
                Continent.Task = SystemEnum.Table_Select;
            }
            else if (DataClass == "Districts".ToUpper())
            {
                District = new Districts(CommandDb, MessagesDb, Configuration);
                District.Form = Form;
                District.Equipment = Hardware.Label().Trim().ToUpper();
                District.Task = SystemEnum.Table_Select;
            }
            else if (DataClass == "Addresses".ToUpper())
            {
                Address = new Addresses(CommandDb, MessagesDb, Configuration);
                Address.Form = Form;
                Address.Equipment = Hardware.Label().Trim().ToUpper();
                Address.Task = SystemEnum.Table_Select;
            }
            else if (DataClass == "Neighborhoods".ToUpper())
            {
                Neighborhood = new Neighborhoods(CommandDb, MessagesDb, Configuration);
                Neighborhood.Form = Form;
                Neighborhood.Equipment = Hardware.Label().Trim().ToUpper();
                Neighborhood.Task = SystemEnum.Table_Select;
            }
            else if (DataClass == "Documents".ToUpper())
            {
                Documento = new Documents(CommandDb, MessagesDb, Configuration);
                Documento.Form = Form;
                Documento.Equipment = Hardware.Label().Trim().ToUpper();
                Documento.Task = SystemEnum.Table_Insert;
            }
            else if (DataClass == "DocumentsTypes".ToUpper())
            {
                DocumentType = new DocumentsTypes(CommandDb, MessagesDb, Configuration);
                DocumentType.Form = Form;
                DocumentType.Equipment = Hardware.Label().Trim().ToUpper();
                DocumentType.Task = SystemEnum.Table_Insert;
            }
            else if (DataClass == "Verifiers".ToUpper())
            {
                Verifier = new Verifiers(CommandDb, MessagesDb, Configuration);
                Verifier.Form = Form;
                Verifier.Equipment = Hardware.Label().Trim().ToUpper();
                Verifier.Task = SystemEnum.Table_Select;
            }
            else if (DataClass == "Persons".ToUpper())
            {
                Person = new Persons(CommandDb, MessagesDb, Configuration);
                Person.Form = Form;
                Person.Equipment = Hardware.Label().Trim().ToUpper();
                Person.Task = SystemEnum.Table_Insert;
            }
            else if (DataClass == "CommunicationsTypes".ToUpper())
            {
                CommunicationType = new CommunicationsTypes(CommandDb, MessagesDb, Configuration);
                CommunicationType.Form = Form;
                CommunicationType.Equipment = Hardware.Label().Trim().ToUpper();
                CommunicationType.Task = SystemEnum.Table_Insert;
            }
        }

        public DataTable SelectDataTable(string DataClass)
        {
            DataTable Result = null;

            DataClass = DataClass.ToUpper();

            if (DataClass == "Cities".ToUpper())
                Result = City.SelectDataTable("", "", null, null, null);
            else if (DataClass == "Countries".ToUpper())
                Result = Country.SelectDataTable("", "", "", null);
            else if (DataClass == "States".ToUpper())
                Result = State.SelectDataTable("", "", "", null);
            else if (DataClass == "Continents".ToUpper())
                Result = Continent.SelectDataTable("");
            else if (DataClass == "Districts".ToUpper())
                Result = District.SelectDataTable("");
            else if (DataClass == "Addresses".ToUpper())
                Result = Address.SelectDataTable("");
            else if (DataClass == "Neighborhoods".ToUpper())
                Result = Neighborhood.SelectDataTable("");
            else if (DataClass == "Documents".ToUpper())
                Result = Documento.SelectDataTable("", "", "", "", "", null, null);
            else if (DataClass == "DocumentsTypes".ToUpper())
                Result = DocumentType.SelectDataTable("");
            else if (DataClass == "Verifiers".ToUpper())
                Result = Verifier.SelectDataTable("");
            else if (DataClass == "Persons".ToUpper())
                Result = Person.SelectDataTable("");
            else if (DataClass == "CommunicationsTypes".ToUpper())
                Result = CommunicationType.SelectDataTable("");

            return Result;
        }

        public string SelectName(string DataClass, string codigo)
        {
            string Result = "";

            DataClass = DataClass.ToUpper();

            if (DataClass == "Cities".ToUpper())
                Result = City.SelectName(codigo);
            else if (DataClass == "Countries".ToUpper())
                Result = Country.SelectName(codigo);
            else if (DataClass == "States".ToUpper())
                Result = State.SelectName(codigo, null);
            else if (DataClass == "Continents".ToUpper())
                Result = Continent.SelectName(codigo);
            else if (DataClass == "Districts".ToUpper())
                Result = District.SelectName(codigo);
            else if (DataClass == "Addresses".ToUpper())
                Result = Address.SelectName(codigo);
            else if (DataClass == "Neighborhoods".ToUpper())
                Result = Neighborhood.SelectName(codigo);
            else if (DataClass == "Documents".ToUpper())
                Result = Documento.SelectName(codigo);
            else if (DataClass == "DocumentsTypes".ToUpper())
                Result = DocumentType.SelectName(codigo);
            else if (DataClass == "Verifiers".ToUpper())
                Result = Verifier.SelectName(codigo);
            else if (DataClass == "Persons".ToUpper())
                Result = Person.SelectName(codigo);
            else if (DataClass == "CommunicationsTypes".ToUpper())
                Result = CommunicationType.SelectName(codigo);

            return Result;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
