using System;

namespace Files
{
    public sealed class SystemFile
    {
        public static string Slack(string Diretorio)
        {
            string Retorno = "";

            if (String.IsNullOrEmpty(Diretorio) == false)
            {
                if (String.Compare(Diretorio.ToString().Substring(Diretorio.ToString().Length - 1, 1), @"\", StringComparison.OrdinalIgnoreCase) != 0)
                    Retorno = String.Concat(Diretorio, @"\");
            }

            return Retorno;
        }

        public static string Date()
        {
            string Retorno;

            int Dia = DateTime.Now.Day,
                Mes = DateTime.Now.Month,
                Ano = DateTime.Now.Year;

            Retorno = Ano.ToString();

            if (Mes < 10)
                Retorno = String.Concat(Retorno, "0", Mes.ToString());
            else
                Retorno = String.Concat(Retorno, Mes.ToString());

            if (Dia < 10)
                Retorno = String.Concat(Retorno, "0", Dia.ToString());
            else
                Retorno = String.Concat(Retorno, Dia.ToString());

            return Retorno;
        }

        public static string Time()
        {
            string Retorno = "";

            int Hora = DateTime.Now.Hour,
                Minuto = DateTime.Now.Minute,
                Segundo = DateTime.Now.Second;

            if (Hora < 10)
                Retorno = String.Concat(Retorno, "0", Hora.ToString());
            else
                Retorno = String.Concat(Retorno, Hora.ToString());

            if (Minuto < 10)
                Retorno = String.Concat(Retorno, "0", Minuto.ToString());
            else
                Retorno = String.Concat(Retorno, Minuto.ToString());

            if (Segundo < 10)
                Retorno = String.Concat(Retorno, "0", Segundo.ToString());
            else
                Retorno = String.Concat(Retorno, Segundo.ToString());

            return Retorno;
        }
    }
}
