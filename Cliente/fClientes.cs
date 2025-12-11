using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theVault.Cliente
{
    public partial class fClientes : Form
    {
        BD bd;
        fMain main;
        int clienteEscolhido;
        string foto = "";

        public fClientes(BD bd, fMain main)
        {
            InitializeComponent();
            this.bd = bd;
            this.main = main;
        }
        public void findFoto() 
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
        private void btnFind_Click(object sender, EventArgs e)
        {
            findFoto();
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
            picFoto.Image = (Image)picFoto.Tag;
            lblErro.Text = "";
            lblFeedback.Text = "";
        }
        private void fClientes_Load(object sender, EventArgs e)
        {
            ListarClientes();
            picFoto.Tag = picFoto.Image;
        }
        private void EliminarCliente()
        {
            if (clienteEscolhido == 0)
            {
                MessageBox.Show("Tem de selecionar um cliente primeiro.");
                return;
            }
            if (MessageBox.Show("Tem a certeza que pretende eliminar o cliente selecionado?",
                "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Cliente apagar = new Cliente(bd);
                apagar.idCliente = clienteEscolhido;
                apagar.Apagar();
                clienteEscolhido = 0;
                ListarClientes();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarCliente();
        }
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Guarda o Cliente selecionado
            if (dgvClientes.CurrentCell == null)
                return;
            int linha = dgvClientes.CurrentCell.RowIndex;
            if (linha < 0)
                return;
            clienteEscolhido = int.Parse(dgvClientes.Rows[linha].Cells[0].Value.ToString());

            // Esconder o botão de adiconar novo
            btnSave.Visible = false;

            // Preencher os FORM com os dados do Cliente selecionado
            Cliente l = new Cliente(bd);
            l.idCliente = clienteEscolhido;
            l.Procurar();
            txtNome.Text = l.nome;
            txtEmail.Text = l.email;
            txtTelefone.Text = l.telefone;
            txtMorada.Text = l.morada;
            txtCP.Text = l.cp;
            dtpNascimento.Value = l.dataNascimento;
            if (System.IO.File.Exists(l.foto))
                picFoto.Image = Image.FromFile(l.foto);

            // Mostrar os botões editar/eliminar/cancelar
            btnEdit.Visible = true;
            btnEliminar.Visible = true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            LimparForm();
            clienteEscolhido = 0;
            btnSave.Visible = true;
            btnEdit.Visible = false;
            btnEliminar.Visible = false;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Criar um objeto
            Cliente cliente = new Cliente(bd);

            // Preencher os dados
            cliente.idCliente = clienteEscolhido;
            cliente.nome = txtNome.Text;
            cliente.dataNascimento = dtpNascimento.Value;
            cliente.email = txtEmail.Text;
            cliente.telefone = txtTelefone.Text;
            cliente.morada = txtMorada.Text;
            cliente.cp = txtCP.Text;
            cliente.foto = Utils.folderProgram("The Vault") + "\\" + cliente.email;

            // Validar os dados
            List<string> error = cliente.Validar();

            // Se não tiver erros nos dados
            if (error.Count > 0)
            {
                // Mostrar os erros
                string msg = "";
                foreach (string erro in error)
                    msg += erro + "; ";
                lblErro.Text = msg;
                lblErro.ForeColor = Color.Red;
                return;
            }

            // Guardar na base de dados
            cliente.Atualizar();

            // Copiar a foto para a pasta do programa
            if (foto != "")
            {
                if (System.IO.File.Exists(foto))
                    System.IO.File.Copy(foto, cliente.foto, true);
            }

            // Limpar o FORM
            LimparForm();
            // Atualizar a lista na DataGridView
            ListarClientes();
            // Feedback USER
            lblFeedback.Text = "Cliente atualizado com sucesso";
            lblFeedback.ForeColor = Color.Black;
            btnEdit.Visible = false;
            btnEliminar.Visible = false;
            btnSave.Visible = true;
        }
        private void txtProcurar_TextChanged(object sender, EventArgs e)
        {
            Cliente c = new Cliente(bd);
            dgvClientes.DataSource = c.Procurar("NOME", txtProcurar.Text);
        }
        private void txtProcurar_Click(object sender, EventArgs e)
        {
            if (txtProcurar.Text == "Procurar")
            {
                txtProcurar.Text = "";
                txtProcurar.ForeColor = Color.Black;
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Impressora imp = new Impressora();
            imp.imprimeGrelha(printDocument1, e, dgvClientes);
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.Landscape = true;
            printPreviewDialog1.ShowDialog();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Utils.closeForm(this, main);
        }
        private void picFoto_Click(object sender, EventArgs e)
        {
            findFoto();
        }
    }
}
