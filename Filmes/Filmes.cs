using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace theVault.Filmes
{
    internal class Filmes : Item
    {
        public int idFilme { get; set; }
        public string titulo { get; set; }
        public string genero { get; set; }
        public int ano { get; set; }
        public string diretor { get; set; }
        public int duracao { get; set; }
        public decimal preco { get; set; }
        public int stock { get; set; }
        public string capa { get; set; }

        BD bd { get; set; }

        public Filmes(BD bd)
        {
            this.bd = bd;
        }
        /*
        public string statisticsGenero()
        {
            string SQL = @"SELECT GENERO, COUNT(IDFILME) AS QTD 
                           FROM FILMES 
                           GROUP BY GENERO";

            DataTable dt = bd.returnSQL(SQL);

            string resultado = "Contagem de Filmes por Género:\n\n";

            foreach (DataRow row in dt.Rows)
            {
                resultado += $"{row["GENERO"]}: {row["STOCK"]} filmes\n";
            }

            return resultado;
        }
        */

       
        public void Adicionar()
        {
            string SQL = @"INSERT INTO FILMES(TITULO, GENERO, ANO, DIRETOR, DURACAO, PRECO, STOCK, CAPA)
                           VALUES (@TITULO, @GENERO, @ANO, @DIRETOR, @DURACAO, @PRECO, @STOCK, @CAPA)";

            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter 
                { 
                    ParameterName = "@TITULO", 
                    SqlDbType = System.Data.SqlDbType.NVarChar, 
                    Value = this.titulo 
                },
                new SqlParameter 
                { 
                    ParameterName = "@GENERO", 
                    SqlDbType = System.Data.SqlDbType.NVarChar, 
                    Value = this.genero 
                },
                new SqlParameter 
                { 
                    ParameterName = "@ANO", 
                    SqlDbType = System.Data.SqlDbType.Int, 
                    Value = this.ano 
                },
                new SqlParameter 
                { 
                    ParameterName = "@DIRETOR", 
                    SqlDbType = System.Data.SqlDbType.NVarChar, 
                    Value = (object)this.diretor ?? DBNull.Value // Diretor pode ser null
                },
                new SqlParameter 
                { 
                    ParameterName = "@DURACAO", 
                    SqlDbType = System.Data.SqlDbType.Int, 
                    Value = this.duracao 
                },
                new SqlParameter 
                { 
                    ParameterName = "@PRECO", 
                    SqlDbType = System.Data.SqlDbType.Decimal, 
                    Value = this.preco 
                },
                new SqlParameter 
                { 
                    ParameterName = "@STOCK", 
                    SqlDbType = System.Data.SqlDbType.Int, 
                    Value = this.stock 
                },
                new SqlParameter()
                {
                    ParameterName = "@CAPA",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.capa,
                },
            };

            bd.executeSQL(SQL, parametros);
        }
        public void Atualizar()
        {
            string SQL = @"UPDATE FILMES
                           SET TITULO = @TITULO,
                               GENERO = @GENERO,
                               ANO = @ANO,
                               DIRETOR = @DIRETOR,
                               DURACAO = @DURACAO,
                               PRECO = @PRECO,
                               STOCK = @STOCK,
                               CAPA = @CAPA       
                           WHERE IDFILME = @IDFILME";

            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter
                {
                    ParameterName = "@TITULO",
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                    Value = this.titulo
                },
                new SqlParameter
                {
                    ParameterName = "@GENERO",
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                    Value = this.genero
                },
                new SqlParameter
                {
                    ParameterName = "@ANO",
                    SqlDbType = System.Data.SqlDbType.Int,
                    Value = this.ano
                },
                new SqlParameter
                {
                    ParameterName = "@DIRETOR",
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                    Value = (object)this.diretor ?? DBNull.Value // Diretor pode ser null
                }, 
                new SqlParameter
                {
                    ParameterName = "@DURACAO",
                    SqlDbType = System.Data.SqlDbType.Int,
                    Value = this.duracao
                },
                new SqlParameter
                {
                    ParameterName = "@PRECO",
                    SqlDbType = System.Data.SqlDbType.Decimal,
                    Value = this.preco
                },
                new SqlParameter
                {
                    ParameterName = "@STOCK",
                    SqlDbType = System.Data.SqlDbType.Int,
                    Value = this.stock
                },
                new SqlParameter()
                {
                    ParameterName = "@CAPA",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.capa,
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
            string SQL = "DELETE FROM FILMES WHERE IDFILME = " + idFilme;
            bd.executeSQL(SQL);
        }
        public List<string> Validar()
        {
            List<string> error = new List<string>();

            // 1. Validar Título
            if (string.IsNullOrEmpty(titulo))
            {
                error.Add("O título do filme é obrigatório.");
            }
            else if (titulo.Length > 150)
            {
                error.Add("O título não pode exceder os 150 caracteres.");
            }

            // 2. Validar Género
            // A BD restringe a: 'Ação', 'Comédia', 'Drama', 'Terror', 'Sci-Fi'
            string[] generosValidos = { "Ação", "Comédia", "Drama", "Terror", "Sci-Fi" };
            if (string.IsNullOrEmpty(genero) || !generosValidos.Contains(genero))
            {
                error.Add("Género inválido. Selecione: Ação, Comédia, Drama, Terror ou Sci-Fi.");
            }

            // 3. Validar Ano (>= 1890)
            if (ano < 1890)
            {
                error.Add("O ano deve ser igual ou superior a 1890.");
            }
            if (ano > DateTime.Now.Year + 1) // Margem para filmes do próximo ano
            {
                error.Add("O ano não pode ser muito superior ao atual.");
            }

            // 4. Validar Diretor
            if (!string.IsNullOrEmpty(diretor) && diretor.Length > 100)
            {
                error.Add("O nome do diretor não pode exceder 100 caracteres.");
            }

            // 5. Validar Duração (> 0)
            if (duracao <= 0)
            {
                error.Add("A duração deve ser maior que 0 minutos.");
            }

            // 6. Validar Preço (>= 0)
            if (preco < 0)
            {
                error.Add("O preço não pode ser negativo.");
            }

            // 7. Validar Stock (>= 0)
            if (stock < 0)
            {
                error.Add("O stock não pode ser negativo.");
            }

            // 8. Validar Foto (para não estourar a aplicação)
            if (!string.IsNullOrEmpty(capa) && capa.Length > 500)
            {
                error.Add("O caminho da capa é demasiado longo.");
            }

            return error;
        }
        public DataTable Listar()
        {
            return bd.returnSQL("SELECT IDFILME AS [ID], TITULO AS [Título], GENERO AS [Género], ANO AS [Ano], DIRETOR AS [Diretor], DURACAO AS [Duração (Min)], PRECO AS [Preço (€)], STOCK AS [Stock] FROM FILMES");
        }

        public DataTable ListarNovosFilmes()
        {
            return bd.returnSQL("SELECT TOP 10 * FROM FILMES ORDER BY IDFILME DESC");
        }

        public DataTable AgruparGenero()
        {
            return bd.returnSQL("SELECT COUNT(*) FROM FILMES GROUP BY GENERO");
        }

        public void Procurar()
        {
            string SQL = "SELECT * FROM FILMES WHERE IDFILME = " + idFilme;
            DataTable temp = bd.returnSQL(SQL);
            if (temp != null && temp.Rows.Count > 0)
            {
                DataRow linha = temp.Rows[0];
                this.titulo = linha["TITULO"].ToString();
                this.genero = linha["GENERO"].ToString();
                this.ano = int.Parse(linha["ANO"].ToString());
                this.diretor = linha["DIRETOR"].ToString();
                this.duracao = int.Parse(linha["DURACAO"].ToString());
                this.preco = decimal.Parse(linha["PRECO"].ToString());
                this.stock = int.Parse(linha["STOCK"].ToString());
            }
        }
        public DataTable Procurar(string v, string text)
        {
            // Permite pesquisar por Título, Diretor ou Género
            string SQL = "SELECT IDFILME AS [ID], TITULO AS [Título], GENERO AS [Género], ANO AS [Ano], DIRETOR AS [Diretor], DURACAO AS [Duração (Min)], PRECO AS [Preço (€)], STOCK AS [Stock] FROM FILMES WHERE " + v + " LIKE @PESQUISA";

            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter 
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
            return this.titulo;
        }
    }
}