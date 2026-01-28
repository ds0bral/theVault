using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using theVault.Cliente;
using theVault.Alugueres;
using theVault.Filmes;

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
            fClientes f = new fClientes(bd, this);
            f.ShowDialog();
        }
        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fFilmes f = new fFilmes(bd, this);
            f.ShowDialog();
        }
        private void alugueresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fAlugueres f = new fAlugueres(bd, this);
            f.ShowDialog();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void fMain_Load(object sender, EventArgs e)
        {
            dgvFilmes.AllowUserToAddRows = false;
            dgvFilmes.AllowUserToDeleteRows = false;
            dgvFilmes.MultiSelect = false;
            dgvFilmes.ReadOnly = true;
            dgvFilmes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Filmes.Filmes f = new Filmes.Filmes(bd);
            dgvFilmes.DataSource = f.ListarNovosFilmes();
        }

    }
}
