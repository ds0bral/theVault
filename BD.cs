using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Data;

namespace theVault
{
    public class BD
    {
        string linkBD;
        string nomeBD;
        string pathBD;
        SqlConnection linkSQL;

        // Construtor
        // Estabelece a ligação a BD, caso não exista cria a BD
        public BD(string nomeBD) 
        {
            this.nomeBD = nomeBD;
            // Ler a string ligação
            linkBD = ConfigurationManager.ConnectionStrings["SQL"].ToString();
            // Verificar a pasta do projeto
            pathBD = Utils.folderProgram("The Vault");
            pathBD += @"\" + nomeBD + ".mdf";
            // Verificar se a BD existe
            if (System.IO.File.Exists(pathBD) == false)
            {
                // Se não existir 
                // Criar a BD
                criarBD();
            }
            // Ligação à BD
            linkSQL = new SqlConnection(linkBD);
            linkSQL.Open();
            linkSQL.ChangeDatabase(this.nomeBD);
        }   
        
        // Destrutor
        ~BD() 
        { 

        }

        // Função para criar a Base de Dados
        void criarBD()
         {
            // Ligação ao servidor
            linkSQL = new SqlConnection(linkBD);
            linkSQL.Open();
            string SQL = $@"
                            IF EXISTS(SELECT * 
                                      FROM MASTER.SYS.DATABASES
                                      WHERE NAME='{this.nomeBD}')
                            BEGIN
                                USE [MASTER];
                                EXEC SP_DETACH_DB {this.nomeBD};
                            END";
            SqlCommand comando = new SqlCommand(SQL, linkSQL);
            comando.ExecuteNonQuery();

            // Criar a BD
            SQL = $"CREATE DATABASE {this.nomeBD} ON PRIMARY (NAME={this.nomeBD},FILENAME='{this.pathBD}')";
            comando = new SqlCommand(SQL,linkSQL);
            comando.ExecuteNonQuery();

            // Associação a ligação à base de dados criada
            linkSQL.ChangeDatabase(this.nomeBD);

            // Criar as tabelas
            // TABELA LIVROS
            SQL = @"CREATE TABLE CLIENTES(
                        IDCLIENTE INT IDENTITY(1,1) PRIMARY KEY,  
                        NOME NVARCHAR(100) NOT NULL,      
                        EMAIL VARCHAR(100) UNIQUE,                 
                        TELEFONE VARCHAR(15),
                        MORADA NVARCHAR(200),
                        REGISTRO DATETIME DEFAULT GETDATE(),   
                        ESTADO BIT DEFAULT 1,
                        );
                    CREATE TABLE FILMES(
                        IDFILME INT IDENTITY(1,1) PRIMARY KEY,
                        TITULO NVARCHAR(150) NOT NULL,
                        GENERO NVARCHAR(50),                       
                        ANO INT,
                        DIRETOR NVARCHAR(100),
                        DURACAO INT,                           
                        PRECO DECIMAL(5,2),                
                        STOCK INT DEFAULT 0
                            CHECK (STOCK >= 0)
                        );
                    CREATE TABLE ALUGUER(
                        IDALUGUER INT IDENTITY(1,1) PRIMARY KEY,
                        IDCLIENTE INT NOT NULL
                            FOREIGN KEY (IDCLIENTE) REFERENCES CLIENTES(IDCLIENTE),
                        IDFILME INT NOT NULL
                            FOREIGN KEY (IDFILME) REFERENCES FILMES(IDFILME),
                        DATA DATETIME DEFAULT GETDATE(),
                        DATAPREVISTA DATE NOT NULL,
                        DATAREAL DATETIME NULL,         
                        PAGO DECIMAL(5,2) NULL,
                        );";
            comando = new SqlCommand(SQL,linkSQL);
            comando.ExecuteNonQuery();
            comando.Dispose();
        }

        // Função para executar comando SQL (insert/delete/update/create/alter...)
        public void executeSQL(string SQL,List<SqlParameter> parameters = null)
        {
            SqlCommand comando = new SqlCommand(SQL, linkSQL);
            if (parameters != null)
                comando.Parameters.AddRange(parameters.ToArray());
            comando.ExecuteNonQuery();
            comando.Dispose();
        }

        // Função para executar um SELECT e devolver os regstros da BD
        public DataTable returnSQL (string SQL, List<SqlParameter> parameters = null) 
        { 
            DataTable dados = new DataTable();
            SqlCommand comando = new SqlCommand(SQL, linkSQL);
            if (parameters != null)
                comando.Parameters.AddRange(parameters.ToArray());
            SqlDataReader registros = comando.ExecuteReader();
            dados.Load(registros);
            registros.Close();
            comando.Dispose();
            return dados;
        }
    }
}