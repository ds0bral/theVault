using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theVault.Alugueres
{
    public partial class fAlugueres : Form
    {
        BD bd;
        fMain main;
        int aluguerEscolhido;

        public fAlugueres(BD bd, fMain main)
        {
            InitializeComponent();
            this.bd = bd;
            this.main = main;
        }

        private void fAlugueres_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utils.closeForm(this, main);
        }
    }
}
