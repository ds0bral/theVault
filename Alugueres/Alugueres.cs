using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace theVault.Alugueres
{
    internal class Alugueres : Item
    {
        public int idAluguer { get; set; }
        public int idCliente { get; set; }
        public int idFilme { get; set; }
        public DateTime data { get; set; }          
        public DateTime dataPrevista { get; set; }  
        public DateTime dataReal { get; set; }            

        BD bd;

        public Alugueres(BD bd)
        {
            this.bd = bd;
        }

        public void Adicionar()
        {
            string SQL = @"INSERT INTO ALUGUER(IDCLIENTE, IDFILME, DATAPREVISTA)
                           VALUES (@IDCLIENTE, @IDFILME, @DATAPREVISTA);
                           
                           UPDATE FILMES SET STOCK = STOCK - 1 WHERE IDFILME = @IDFILME;";

            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter 
                { ParameterName = "@IDCLIENTE", 
                    SqlDbType = System.Data.SqlDbType.Int, 
                    Value = this.idCliente 
                },
                new SqlParameter 
                { ParameterName = "@IDFILME",
                    SqlDbType = System.Data.SqlDbType.Int,
                    Value = this.idFilme 
                },
                new SqlParameter 
                { ParameterName = "@DATAPREVISTA", 
                    SqlDbType = System.Data.SqlDbType.Date, 
                    Value = this.dataPrevista 
                }
            };

            bd.executeSQL(SQL, parametros);
        }

        public void Atualizar()
        {
            string SQL = @"UPDATE ALUGUER
                           SET DATAREAL = @DATAREAL,
                           WHERE IDALUGUER = @IDALUGUER;

                           UPDATE FILMES SET STOCK = STOCK + 1 WHERE IDFILME = @IDFILME;";

            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter 
                { 
                    ParameterName = "@DATAREAL", 
                    SqlDbType = System.Data.SqlDbType.DateTime, 
                    Value = (object)this.dataReal ?? DBNull.Value 
                },
                new SqlParameter 
                { 
                    ParameterName = "@IDALUGUER", 
                    SqlDbType = System.Data.SqlDbType.Int, 
                    Value = this.idAluguer 
                },
                new SqlParameter 
                { 
                    ParameterName = "@IDFILME", 
                    SqlDbType = System.Data.SqlDbType.Int, 
                    Value = this.idFilme 
                }
            };

            bd.executeSQL(SQL, parametros);
        }

        public void Apagar()
        {
            string SQL = "DELETE FROM ALUGUER WHERE IDALUGUER = " + idAluguer;
            bd.executeSQL(SQL);
        }

        public List<string> Validar()
        {
            List<string> error = new List<string>();

            // 1. Validação Comum (Obrigatório ter cliente e filme)
            if (idCliente <= 0) error.Add("Obrigatório selecionar um Cliente.");
            if (idFilme <= 0) error.Add("Obrigatório selecionar um Filme.");

            // 2. Lógica Condicional baseada no ID (Novo vs Existente)
            if (idAluguer == 0)
            {
                // Validar Data Prevista
                if (dataPrevista < DateTime.Today)
                {
                    error.Add("A Data Prevista não pode ser anterior à data de hoje.");
                }

                // Validar Stock Disponível na BD
                string sqlStock = "SELECT STOCK FROM FILMES WHERE IDFILME = " + idFilme;
                DataTable dt = bd.returnSQL(sqlStock);
                if (dt != null && dt.Rows.Count > 0)
                {
                    int stockAtual = int.Parse(dt.Rows[0]["STOCK"].ToString());
                    if (stockAtual <= 0) error.Add("Este filme não tem stock disponível.");
                }
            }
            else
            {
                // Validar Data de Entrega
                // Nota: 'data' é a data original do aluguer carregada pelo método Procurar()
                if (dataReal.Date > data.Date)
                {
                    error.Add("A Data Real de entrega não pode ser anterior à data do aluguer.");
                }
            }

            return error;
        }

        public DataTable Listar()
        {
            string SQL = @"SELECT 
                            IDALUGUER AS [ID], 
                            CLIENTE.NOME AS [Cliente], 
                            FILMES.TITULO AS [Filme], 
                            DATA AS [Data Aluguer], 
                            DATAPREVISTA AS [Data Prevista], 
                            DATAREAL AS [Data Entrega], 
                           FROM ALUGUER
                           INNER JOIN CLIENTES ON ALUGUER.IDCLIENTE = CLIENTE.IDCLIENTE
                           INNER JOIN FILMES ON ALUGUER.IDFILME = FILMES.IDFILME
                           ORDER BY DATA DESC";

            return bd.returnSQL(SQL);
        }

        public void Procurar()
        {
            string SQL = "SELECT * FROM ALUGUER WHERE IDALUGUER = " + idAluguer;
            DataTable temp = bd.returnSQL(SQL);
            if (temp != null && temp.Rows.Count > 0)
            {
                DataRow linha = temp.Rows[0];
                this.idCliente = int.Parse(linha["IDCLIENTE"].ToString());
                this.idFilme = int.Parse(linha["IDFILME"].ToString());
                this.data = DateTime.Parse(linha["DATA"].ToString());
                this.dataPrevista = DateTime.Parse(linha["DATAPREVISTA"].ToString());

                if (linha["DATAREAL"] != DBNull.Value)
                    this.dataReal = DateTime.Parse(linha["DATAREAL"].ToString());
            }
        }

        public DataTable Procurar(string texto)
        {
            string SQL = @"SELECT 
                            IDALUGUER AS [ID], 
                            CLIENTE.NOME AS [Cliente], 
                            FILMES.TITULO AS [Filme], 
                            DATA AS [Data Aluguer], 
                            DATAPREVISTA AS [Data Prevista], 
                            DATAREAL AS [Data Entrega], 
                           FROM ALUGUER
                           INNER JOIN CLIENTES ON ALUGUER.IDCLIENTE = CLIENTES.IDCLIENTE
                           INNER JOIN FILMES ON ALUGUER.IDFILME = FILMES.IDFILME
                           WHERE CLIENTES.NOME LIKE @PESQUISA OR FILMES.TITULO LIKE @PESQUISA";

            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter
                {
                    ParameterName = "@PESQUISA",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = "%" + texto + "%"
                }
            };

            return bd.returnSQL(SQL, parametros);
        }
    }
}