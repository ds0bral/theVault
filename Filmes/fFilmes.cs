using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using theVault;

namespace theVault.Filmes
{
    public partial class fFilmes : Form
    {
        BD bd;
        fMain main;
        int filmeEscolhido;
        string capa = "";

        public fFilmes(BD bd, fMain main)
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
                    picCapa.Image = Image.FromFile(temp);
                    capa = temp;
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Filmes filmes = new Filmes(bd);

            filmes.titulo = txtTitulo.Text;
            filmes.genero = cbGenero.Text;
            filmes.ano = int.Parse(txtAno.Text);
            filmes.diretor = txtDiretor.Text;
            filmes.duracao = int.Parse(txtDuracao.Text);
            filmes.preco = Decimal.Parse(txtPreco.Text);
            filmes.stock = int.Parse(txtStck.Text);
            filmes.capa = Utils.folderProgram("The Vault") + "\\" + filmes.idFilme;

            List<string> error = filmes.Validar();

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

            filmes.Adicionar();

            if (capa != "")
            {
                if (System.IO.File.Exists(capa))
                    System.IO.File.Copy(capa, filmes.capa, true);
            }

            LimparForm();
            ListarFilmes();

            lblFeedback.Text = "Filmes adicionado com sucesso";
            lblFeedback.ForeColor = Color.Black;
        }
        private void ListarFilmes()
        {
            dgvFilmes.AllowUserToAddRows = false;
            dgvFilmes.AllowUserToDeleteRows = false;
            dgvFilmes.MultiSelect = false;
            dgvFilmes.ReadOnly = true;
            dgvFilmes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Filmes f = new Filmes(bd);
            dgvFilmes.DataSource = f.Listar();
        }
        private void LimparForm()
        {
            txtTitulo.Text = "";
            cbGenero.Text = "";
            txtAno.Text = "";
            txtDiretor.Text = "";
            txtDuracao.Text = "";
            txtPreco.Text = "";
            txtStck.Text = "";
            picCapa.Image = (Image)picCapa.Tag;
        }
        private void EliminarLivro()
        {
            if (filmeEscolhido == 0)
            {
                MessageBox.Show("Tem de selecionar um filme primeiro.");
                return;
            }
            if (MessageBox.Show("Tem a certeza que pretende eliminar o filme selecionado?",
                "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Filmes apagar = new Filmes(bd);
                apagar.idFilme = filmeEscolhido;
                apagar.Apagar();
                filmeEscolhido = 0;
                ListarFilmes();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarLivro();
        }
        private void dgvFilmes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Guarda o Cliente selecionado
            if (dgvFilmes.CurrentCell == null)
                return;
            int linha = dgvFilmes.CurrentCell.RowIndex;
            if (linha < 0)
                return;
            filmeEscolhido = int.Parse(dgvFilmes.Rows[linha].Cells[0].Value.ToString());

            // Esconder o botão de adiconar novo
            btnSave.Visible = false;

            // Preencher os FORM com os dados do Filme selecionado
            Filmes l = new Filmes(bd);
            l.idFilme = filmeEscolhido;
            l.Procurar();
            txtTitulo.Text = l.titulo;
            cbGenero.Text = l.genero;
            txtAno.Text = l.ano.ToString();
            txtDiretor.Text = l.diretor;
            txtDuracao.Text = l.duracao.ToString();
            txtPreco.Text = l.preco.ToString();
            txtStck.Text = l.stock.ToString();
            if (System.IO.File.Exists(l.capa))
                picCapa.Image = Image.FromFile(l.capa);

            // Mostrar os botões editar/eliminar/cancelar
            btnEdit.Visible = true;
            btnEliminar.Visible = true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            LimparForm();
            filmeEscolhido = 0;
            btnSave.Visible = true;
            btnEdit.Visible = false;
            btnEliminar.Visible = false;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Filmes filmes = new Filmes(bd);

            filmes.titulo = txtTitulo.Text;
            filmes.genero = cbGenero.Text;
            filmes.ano = int.Parse(txtAno.Text);
            filmes.diretor = txtDiretor.Text;
            filmes.duracao = int.Parse(txtDuracao.Text);
            filmes.preco = Decimal.Parse(txtPreco.Text);
            filmes.stock = int.Parse(txtStck.Text);
            filmes.capa = Utils.folderProgram("The Vault") + "\\" + filmes.titulo;

            List<string> error = filmes.Validar();

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

            filmes.Atualizar();

            if (capa != "")
            {
                if (System.IO.File.Exists(capa))
                    System.IO.File.Copy(capa, filmes.capa, true);
            }

            LimparForm();
            ListarFilmes();

            lblFeedback.Text = "Filmes atualizado com sucesso";
            lblFeedback.ForeColor = Color.Black;
        }
        private void txtProcurar_TextChanged(object sender, EventArgs e)
        {
            Filmes c = new Filmes(bd);
            dgvFilmes.DataSource = c.Procurar("TITULO", txtProcurar.Text);
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
            imp.imprimeGrelha(printDocument1, e, dgvFilmes);
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
        private void picCapa_Click(object sender, EventArgs e)
        {
            findFoto();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            findFoto();
        }
        private void fFilmes_Load(object sender, EventArgs e)
        {
            ListarFilmes();
            picCapa.Tag = picCapa.Image;
        }

        private void btnGenero_Click(object sender, EventArgs e)
        {
            dgvFilmes.AllowUserToAddRows = false;
            dgvFilmes.AllowUserToDeleteRows = false;
            dgvFilmes.MultiSelect = false;
            dgvFilmes.ReadOnly = true;
            dgvFilmes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Filmes f = new Filmes(bd);
            dgvFilmes.DataSource = f.AgruparGenero();
            btnDesagrupar.Visible = true;
            btnGenero.Visible = false;
        }

        private void btnDesagrupar_Click(object sender, EventArgs e)
        {
            ListarFilmes();
            btnDesagrupar.Visible = false;
            btnGenero.Visible = true;
        }

        private void fFilmes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utils.closeForm(this, main);
        }
    }
}
