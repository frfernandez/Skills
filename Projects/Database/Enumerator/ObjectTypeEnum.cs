using System;

namespace Database.Enumerator
{
    public sealed class ObjectTypeEnum
    {
        public static DatabaseEnum DatabaseType(string Type)
        {
            DatabaseEnum Result = new DatabaseEnum();

            Enum.TryParse<DatabaseEnum>(Type, true, out Result);

            return Result;
        }

        public static ProtocolEnum ProtocolType(string Type)
        {
            ProtocolEnum Result = new ProtocolEnum();

            Enum.TryParse<ProtocolEnum>(Type, true, out Result);

            return Result;
        }
    }
}
