using System;
using System.Data;
using System.Windows.Forms;
using Database;
using Entity.Map;
using Objects;
using Objects.Enumerator;

namespace Entity.People
{
    public class PessoasEnderecos : IDisposable
    {
        public string Posicao { get; set; }
        public string CEP { get; set; }
        public string Complemento { get; set; }
        public string NumeroResidencia { get; set; }
        public Pessoas Pessoa { get; private set; }
        public TitulosEnderecos TituloEndereco { get; private set; }
        public Enderecos Endereco { get; private set; }
        public Bairros Bairro { get; private set; }
        public Cidades Cidade { get; private set; }
        public Estados Estado { get; private set; }
        public Paises Pais { get; private set; }
        public Continentes Continente { get; private set; }

        public Command CommandDb;

        public PessoasEnderecos()
        {
        }

        public PessoasEnderecos(Command commandDb)
        {
            CommandDb = commandDb;
        }

        public bool Save(Pessoas pessoa, string posicao, string cEP, string complemento, TitulosEnderecos tituloEndereco,
            Enderecos endereco, string numeroResidencia, Bairros bairro, Cidades cidade)
        {
            bool Result = false;

            Pessoa = pessoa;
            Posicao = posicao;
            CEP = cEP;
            Complemento = complemento;
            TituloEndereco = tituloEndereco;
            Endereco = endereco;
            NumeroResidencia = numeroResidencia;
            Bairro = bairro;
            Cidade = cidade;

            if (String.IsNullOrEmpty(Pessoa.Id.ToString()) == true)
                MessageBox.Show("O código da pessoa deverá ser informado !");
            else if (String.IsNullOrEmpty(Posicao) == true)
                MessageBox.Show("A posição deverá ser informada !");
            else if (String.IsNullOrEmpty(TituloEndereco.Id.ToString()) == true)
                MessageBox.Show("O título do endereço deverá ser informado !");
            else if (String.IsNullOrEmpty(Endereco.Id.ToString()) == true)
                MessageBox.Show("O endereço deverá ser informado !");
            else if (String.IsNullOrEmpty(Bairro.Id.ToString()) == true)
                MessageBox.Show("O bairro deverá ser informado !");
            else if (String.IsNullOrEmpty(Cidade.Codigo.ToString()) == true)
                MessageBox.Show("A cidade deverá ser informada !");
            else
                Result = true;

            return Result;
        }

        public void Insert()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "IncPessoasEnderecos");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "CodigoPessoa", Pessoa.Id.ToString());
                CommandDb.ParameterInput(CommandIDb, "Posicao", Posicao);
                CommandDb.ParameterInput(CommandIDb, "CEP", CEP);
                CommandDb.ParameterInput(CommandIDb, "Complemento", Complemento);
                CommandDb.ParameterInput(CommandIDb, "CodigoTitulo", TituloEndereco.Id.ToString());
                CommandDb.ParameterInput(CommandIDb, "CodigoEndereco", Endereco.Id.ToString());
                CommandDb.ParameterInput(CommandIDb, "NumeroResidencia", NumeroResidencia);
                CommandDb.ParameterInput(CommandIDb, "CodigoBairro", Bairro.Id.ToString());
                CommandDb.ParameterInput(CommandIDb, "CodigoCidade", Cidade.Codigo.ToString());
                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
            }
        }

        public void Update()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "AltPessoasEnderecos");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "CodigoPessoa", Pessoa.Id.ToString());
                CommandDb.ParameterInput(CommandIDb, "Posicao", Posicao);
                CommandDb.ParameterInput(CommandIDb, "CEP", CEP);
                CommandDb.ParameterInput(CommandIDb, "Complemento", Complemento);
                CommandDb.ParameterInput(CommandIDb, "CodigoTitulo", TituloEndereco.Id.ToString());
                CommandDb.ParameterInput(CommandIDb, "CodigoEndereco", Endereco.Id.ToString());
                CommandDb.ParameterInput(CommandIDb, "NumeroResidencia", NumeroResidencia);
                CommandDb.ParameterInput(CommandIDb, "CodigoBairro", Bairro.Id.ToString());
                CommandDb.ParameterInput(CommandIDb, "CodigoCidade", Cidade.Codigo.ToString());
                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
            }
        }

        public void Delete()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "ExcPessoasEnderecos");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "CodigoPessoa", Pessoa.Id.ToString());
                CommandDb.ParameterInput(CommandIDb, "Posicao", Posicao);
                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
            }
        }

        public DataTable SelectDataTable(Pessoas pessoa)
        {
            DataTable Result;
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "PkPessoasEnderecos");

            Pessoa = pessoa;

            try
            {
                CommandDb.ParameterInput(CommandIDb, "CodigoPessoa", Pessoa.Id.ToString());
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
