using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace theVault
{
    /// <summary>
    /// Funções static para saber a pasta do programa
    /// </summary>
    internal class Utils
    {
        /// <summary>
        /// Verifica se a pasta existe e se necessario cria a pasta
        /// </summary>
        /// <param name="nome">Nome da pasta</param>
        /// <returns>Devolve o caminho da pasta</returns>
        public static string folderProgram(string nome)
        {
            // Caminho completo para a pasta appdata/local
            string pastaInicial = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pastaInicial += @"\" + nome;
            if (System.IO.Directory.Exists(pastaInicial) == false)
                System.IO.Directory.CreateDirectory(pastaInicial);
            return pastaInicial;
        }
        public static void closeForm(Form f,fMain main) 
        {
            f.Close();
            main.Show();
        }
    }
}
