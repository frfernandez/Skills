using System;
using System.Text;
using System.Security.Cryptography;

namespace Operational
{
    public sealed class Cryptography
    {
        public static string Crypto(string Text, bool Encryption, string Date, string Time)
        {
            byte[] Result, Key, Value;
            string Frase = String.Concat(Date, Time);

            UTF8Encoding UTF8 = new UTF8Encoding();
            MD5CryptoServiceProvider Service = new MD5CryptoServiceProvider();

            if (Encryption == true)
                Value = UTF8.GetBytes(Text);
            else
                Value = Convert.FromBase64String(Text);

            Key = Service.ComputeHash(UTF8.GetBytes(Frase));

            TripleDESCryptoServiceProvider Algorithm = new TripleDESCryptoServiceProvider();
            Algorithm.Key = Key;
            Algorithm.Mode = CipherMode.ECB;
            Algorithm.Padding = PaddingMode.PKCS7;

            try
            {
                ICryptoTransform Transformer;

                if (Encryption == true)
                    Transformer = Algorithm.CreateEncryptor();
                else
                    Transformer = Algorithm.CreateDecryptor();

                Result = Transformer.TransformFinalBlock(Value, 0, Value.Length);
            }
            finally
            {
                Algorithm.Clear();
                Service.Clear();
            }

            if (Encryption == true)
                return Convert.ToBase64String(Result);
            else
                return UTF8.GetString(Result);
        }
    }
}
