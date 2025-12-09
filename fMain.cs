using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theVault
{
    public partial class fMain : Form
    {
        BD bd;
        public fMain()
        {
            InitializeComponent();
            bd = new BD("theVault");
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fClientes f = new fClientes(bd);
            f.Show();
        }
    }
}
