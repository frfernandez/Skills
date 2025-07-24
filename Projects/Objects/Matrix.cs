using System;

namespace Objects
{
    public class Matrix
    {
        public static string[] Config(string Separator, string ParameterValue)
        {
            string[] Result = new string[0];
            string Item, ValueParameter;

            if (ParameterValue != null)
            {
                ValueParameter = ParameterValue.Trim();

                int Count = 0,
                    Position = 0;
                bool Find = true;
                while (Find == true)
                {
                    Position = ValueParameter.IndexOf(Separator, 0);

                    if (Position == -1)
                    {
                        Find = false;
                        Item = ValueParameter.Substring(0, ValueParameter.Length);
                        ValueParameter = "";
                    }
                    else
                    {
                        Item = ValueParameter.Substring(0, Position);
                        ValueParameter = ValueParameter.Substring(Position + 1);
                    }

                    Count++;
                    Array.Resize(ref Result, Count);
                    Result[Count - 1] = Item;
                }
            }

            return Result;
        }

        public static string[] Add(string[] ArrayValue, string Value)
        {
            Array.Resize(ref ArrayValue, ArrayValue.Length + 1);
            ArrayValue[ArrayValue.Length - 1] = Value;

            return ArrayValue;
        }
    }
}
