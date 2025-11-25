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
    public partial class fClientes : Form
    {
        string foto = "";
        BD bd;

        public fClientes(BD bd)
        {
            InitializeComponent();
            this.bd = bd;
        }
    }
}
