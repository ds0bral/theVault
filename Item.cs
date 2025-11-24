using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theVault
{
    /// <summary>
    /// Interface para as classes do projeto
    /// </summary>

    internal interface Item
    {
        // ADICIONAR
        void Adicionar();
        // ATUALIZAR
        void Atualizar();
        // APAGAR
        void Apagar();
        // VALIDAR
        List<string> Validar();
    }
}
