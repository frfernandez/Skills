using System;
using System.Text;
using System.Globalization;

namespace Operational
{
    public sealed class Character
    {
        public class Insert
        {
            public static string Single_Quotation_Mark(string Value)
            {
                string Result = "";

                Result = String.Concat("\'", Value, "\'");

                return Result;
            }

            public static string Double_Quotation_Mark(string Value)
            {
                string Result = "";

                Result = String.Concat("\"", Value, "\"");

                return Result;
            }

            public static string Gap(string Text, int Quantity, Boolean Complete, Boolean Right)
            {
                int Largura = 1;

                if (Complete == true)
                    Largura = Text.ToString().Length + 1;

                for (int i = Largura; i < Quantity; i++)
                {
                    if (Right == true)
                        Text = String.Concat(Text, " ");
                    else
                        Text = String.Concat(" ", Text);
                }

                return Text;
            }
        }

        public class Remove
        {
            public static string Stress(string Value)
            {
                StringBuilder Result = new StringBuilder();

                if (String.IsNullOrEmpty(Value) == false)
                {
                    var Text = Value.Normalize(NormalizationForm.FormD).ToCharArray();

                    foreach (char Letter in Text)
                    {
                        if (CharUnicodeInfo.GetUnicodeCategory(Letter) != UnicodeCategory.NonSpacingMark)
                            Result.Append(Letter);
                    }
                }

                return Result.ToString();
            }

            public static string Currency_Symbol(string Value)
            {
                StringBuilder Result = new StringBuilder();
                var Text = Value.Normalize(NormalizationForm.FormD).ToCharArray();

                foreach (char Letter in Text)
                {
                    if (Letter.ToString() != "$")
                        Result.Append(Letter);
                }

                return Result.ToString();
            }
        }
    }
}
