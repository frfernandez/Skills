using System;
using System.Drawing;

namespace Objects.Enumerator
{
    public sealed class ObjectTypeEnum
    {
        public static ContentAlignment ImageAlignType(string Type)
        {
            ContentAlignment Result = new ContentAlignment();

            Enum.TryParse<ContentAlignment>(Type, true, out Result);

            return Result;
        }

        public static ContentAlignment TextAlignType(string Type)
        {
            ContentAlignment Result = new ContentAlignment();

            Enum.TryParse<ContentAlignment>(Type, true, out Result);

            return Result;
        }
    }
}
