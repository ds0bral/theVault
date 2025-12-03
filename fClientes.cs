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

        private void btnFind_Click(object sender, EventArgs e)
        {
            OpenFileDialog ficheiro = new OpenFileDialog();
            ficheiro.InitialDirectory = "C:\\";
            ficheiro.Multiselect = false;
            ficheiro.Filter = "Imagens | *.jpg; *.jpeg; *.png; *.bmp | Todos os ficheiros | *.*";
            if (ficheiro.ShowDialog() == DialogResult.OK)
            {
                string temp = ficheiro.FileName;
                if (System.IO.File.Exists(temp))
                {
                    picFoto.Image = Image.FromFile(temp);
                    foto = temp;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(bd);

            cliente.nome = txtNome.Text;
            cliente.dataNascimento = dtpNascimento.Value;
            cliente.email = txtEmail.Text;
            cliente.telefone = txtTelefone.Text;
            cliente.morada = txtMorada.Text;
            cliente.cp = txtCP.Text;
            cliente.foto = Utils.folderProgram("The Vault") + "\\" + cliente.email;

            List<string> error = cliente.Validar();

            if(error.Count > 0)
            {
                // Mostrar os erros
                string msg = "";
                foreach (string erro in error)
                    msg += erro + "; ";
                lblErro.Text = msg;
                lblErro.ForeColor = Color.Red;
                return;
            }

            cliente.Adicionar();

            if (foto != "")
            {
                if (System.IO.File.Exists(foto))
                    System.IO.File.Copy(foto, cliente.foto, true);
            }

            LimparForm();
            ListarClientes();

            lblFeedback.Text = "Cliente adicionado com sucesso";
            lblFeedback.ForeColor = Color.Black;
        }
        private void ListarClientes()
        {
            // Configurar a dgvClientes
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.MultiSelect = false;
            dgvClientes.ReadOnly = true;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Cliente c = new Cliente(bd);
            dgvClientes.DataSource = c.Listar();
        }
        private void LimparForm()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtMorada.Text = "";
            txtCP.Text = "";
            dtpNascimento.Value = DateTime.Now;
            picFoto.Image = null;
        }

        private void fClientes_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }
    }
}
