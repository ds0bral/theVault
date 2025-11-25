using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theVault
{
    internal class Cliente : Item
    {
        public int idCliente { get; set; }
        public string nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string morada { get; set; }
        public string cp { get; set; }
        public string foto { get; set; }

        BD bd { get; set; }
        public Cliente(BD bd)
        {
            this.bd = bd;
        }

        public void Adicionar()
        {
            string SQL = @"INSERT INTO CLIENTES(NOME,DATANASCIMENTO,EMAIL,TELEFONE,MORADA,CP,FOTO)
                           VALUES (@NOME,@DATANASCIMENTO,@EMAIL,@TELEFONE,@MORADA,@CP,@FOTO)";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@NOME",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.nome,
                },
                new SqlParameter()
                {
                    ParameterName = "@DATANASCIMENTO",
                    SqlDbType = System.Data.SqlDbType.Date,
                    Value = this.dataNascimento,
                },
                new SqlParameter()
                {
                    ParameterName = "@EMAIL",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.email,
                },
                new SqlParameter()
                {
                    ParameterName = "@TELEFONE",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.telefone,
                },
                new SqlParameter()
                {
                    ParameterName = "@MORADA",
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                    Value = this.morada,
                },
                new SqlParameter()
                {
                    ParameterName = "@CP",
                    SqlDbType = System.Data.SqlDbType.Char,
                    Value = this.cp,
                },
                new SqlParameter()
                {
                    ParameterName = "@FOTO",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.foto,
                }
            };
            bd.executeSQL(SQL, parametros);
        }

        public void Atualizar()
        {
            throw new NotImplementedException();
        }
        public void Apagar()
        {
            throw new NotImplementedException();
        }
        public List<string> Validar()
        {
            List<string> erros = new List<string>();
            if (string.IsNullOrEmpty(nome))
            {
                erros.Add("O nome do cliente é obrigatório.");
            }
            if (string.IsNullOrEmpty(email))
            {
                erros.Add("O email do cliente é obrigatório.");
            }
            return erros;
        }
    }
}
