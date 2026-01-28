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
        public decimal pago { get; set; }          

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
                               PAGO = @PAGO
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
                    ParameterName = "@PAGO", 
                    SqlDbType = System.Data.SqlDbType.Decimal, 
                    Value = (object)this.pago ?? DBNull.Value 
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
                // --- REGRAS PARA NOVO ALUGUER (ADICIONAR) ---

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
                // --- REGRAS PARA DEVOLUÇÃO/ATUALIZAÇÃO (ATUALIZAR) ---

                // Validar Data de Entrega
                // Nota: 'data' é a data original do aluguer carregada pelo método Procurar()
                if (dataReal.HasValue && dataReal.Value < data)
                {
                    error.Add("A Data Real de entrega não pode ser anterior à data do aluguer.");
                }

                // Validar Pagamento
                if (pago.HasValue && pago.Value < 0)
                {
                    error.Add("O valor pago não pode ser negativo.");
                }
            }

            return error;
        }

        public DataTable Listar()
        {
            string SQL = @"SELECT 
                            A.IDALUGUER AS [ID], 
                            C.NOME AS [Cliente], 
                            F.TITULO AS [Filme], 
                            A.DATA AS [Data Aluguer], 
                            A.DATAPREVISTA AS [Data Prevista], 
                            A.DATAREAL AS [Data Entrega], 
                            A.PAGO AS [Pago (€)]
                           FROM ALUGUER A
                           INNER JOIN CLIENTES C ON A.IDCLIENTE = C.IDCLIENTE
                           INNER JOIN FILMES F ON A.IDFILME = F.IDFILME
                           ORDER BY A.DATA DESC";

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

                if (linha["PAGO"] != DBNull.Value)
                    this.pago = decimal.Parse(linha["PAGO"].ToString());
            }
        }

        public DataTable Procurar(string texto)
        {
            string SQL = @"SELECT 
                            A.IDALUGUER AS [ID], 
                            C.NOME AS [Cliente], 
                            F.TITULO AS [Filme], 
                            A.DATA AS [Data Aluguer], 
                            A.DATAPREVISTA AS [Data Prevista], 
                            A.DATAREAL AS [Data Entrega], 
                            A.PAGO AS [Pago (€)]
                           FROM ALUGUER A
                           INNER JOIN CLIENTES C ON A.IDCLIENTE = C.IDCLIENTE
                           INNER JOIN FILMES F ON A.IDFILME = F.IDFILME
                           WHERE C.NOME LIKE @PESQUISA OR F.TITULO LIKE @PESQUISA";

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