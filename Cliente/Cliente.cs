using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace theVault.Cliente
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
            string SQL = @"UPDATE CLIENTES
                           SET NOME = @NOME,
                               DATANASCIMENTO = @DATANASCIMENTO,
                               EMAIL = @EMAIL,
                               TELEFONE = @TELEFONE,
                               MORADA = @MORADA,
                               CP = @CP,
                               FOTO = @FOTO
                           WHERE IDCLIENTE = @IDCLIENTE";

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
                },
                new SqlParameter()
                {
                    ParameterName = "@IDCLIENTE",
                    SqlDbType = System.Data.SqlDbType.Int,
                    Value = this.idCliente,
                }
            };
            bd.executeSQL(SQL, parametros);
        }
        public void Apagar()
        {
            string SQL = "DELETE FROM CLIENTES WHERE IDCLIENTE = " + idCliente;
            bd.executeSQL(SQL);
        }
        public List<string> Validar()
        {
            List<string> error = new List<string>();

            // 1. Validar Nome
            if (string.IsNullOrEmpty(nome) || nome.Length < 3)
            {
                error.Add("O campo nome é obrigatório e deve ter pelo menos 3 caracteres.");
            }
            else if (nome.Length > 100)
            {
                error.Add("O nome não pode exceder os 100 caracteres.");
            }

            // 2. Validar Data de Nascimento
            if (dataNascimento > DateTime.Now)
            {
                error.Add("A data de nascimento não pode ser superior à data atual.");
            }

            // 3. Validar Email
            if (string.IsNullOrEmpty(email))
            {
                error.Add("O campo email é obrigatório.");
            }
            else if (email.Length > 100)
            {
                error.Add("O email não pode exceder 100 caracteres.");
            }
            else if (!email.Contains("@") || !email.Contains("."))
            {
                error.Add("Deve inserir um email válido. (ex: nome@exemplo.com)");
            }

            // 4. Validar Telefone
            if (string.IsNullOrEmpty(telefone))
            {
                error.Add("O campo telefone é obrigatório.");

                // Regras do Regex:
                // ^9      -> Tem de começar por 9
                // [1236]  -> O segundo número só pode ser 1, 2, 3 ou 6
                // \d{7}   -> Seguido de exatamente 7 outros números (0-9)
                // $       -> Fim da string (garante que não tem mais nada)

                if (!Regex.IsMatch(telefone, @"^9[1236]\d{7}$"))
                {
                    error.Add("Deve inserir um número de telefone válido.");
                }
            }

            // 5. Validar Morada
            if (!string.IsNullOrEmpty(morada) && morada.Length > 200)
            {
                error.Add("A morada não pode exceder os 200 caracteres.");
            }

            // 6. Validar Código Postal
            if (!string.IsNullOrEmpty(cp))
            {
                // Regras do Regex:
                // ^[1-9]  -> O primeiro dígito é de 1 a 9 (não pode ser 0)
                // \d{3}   -> Seguido de 3 dígitos quaisquer
                // -       -> Um hífen obrigatório
                // \d{3}   -> Seguido de 3 dígitos finais

                if (!Regex.IsMatch(cp, @"^[1-9]\d{3}-\d{3}$"))
                {
                    error.Add("O código postal deve estar no formato XXXX-XXX e não pode começar por 0.");
                }
            }

            // 7. Validar Foto (para não estourar a aplicação)
            if (!string.IsNullOrEmpty(foto) && foto.Length > 500)
            {
                error.Add("O caminho da foto é demasiado longo.");
            }

            return error;
        }
        public DataTable Listar()
        {
            return bd.returnSQL("SELECT IDCLIENTE AS [ID], NOME AS [Nome], DATEDIFF(YEAR,DATANASCIMENTO,GETDATE()) AS [Idade], EMAIL AS [Email], TELEFONE AS [Telefone] FROM CLIENTES");
        }
        public void Procurar()
        {
            string SQL = "SELECT * FROM CLIENTES WHERE IDCLIENTE = " + idCliente;
            DataTable temp = bd.returnSQL(SQL);
            if (temp != null && temp.Rows.Count > 0)
            {
                DataRow linha = temp.Rows[0];
                this.nome = linha["NOME"].ToString();
                this.dataNascimento = DateTime.Parse(linha["DATANASCIMENTO"].ToString());
                this.email = linha["EMAIL"].ToString();
                this.telefone = linha["TELEFONE"].ToString();
                this.morada = linha["MORADA"].ToString();
                this.cp = (linha["CP"].ToString());
                this.foto = linha["FOTO"].ToString();
            }
        }
        public DataTable Procurar(string v, string text)
        {
            string SQL = "SELECT IDCLIENTE AS [ID], NOME AS [Nome], DATEDIFF(YEAR,DATANASCIMENTO,GETDATE()) AS [Idade], EMAIL AS [Email], TELEFONE AS [Telefone] FROM CLIENTES WHERE " + v + " LIKE @PESQUISA";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@PESQUISA",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = "%" + text + "%"
                }
            };
            return bd.returnSQL(SQL, parametros);
        }
        public override string ToString()
        {
            return this.nome;
        }
    }
}
