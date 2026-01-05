namespace theVault.Filmes
{
    partial class fFilmes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fFilmes));
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblDiretor = new System.Windows.Forms.Label();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblStck = new System.Windows.Forms.Label();
            this.txtDiretor = new System.Windows.Forms.TextBox();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtStck = new System.Windows.Forms.TextBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblClientes = new System.Windows.Forms.Label();
            this.dgvFilmes = new System.Windows.Forms.DataGridView();
            this.lblErro = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblCapa = new System.Windows.Forms.Label();
            this.picCapa = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCapa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(95, 99);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(173, 20);
            this.txtTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(45, 102);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(38, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Título:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(45, 128);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 13);
            this.lblGenero.TabIndex = 2;
            this.lblGenero.Text = "Género:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(45, 153);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(29, 13);
            this.lblAno.TabIndex = 3;
            this.lblAno.Text = "Ano:";
            // 
            // lblDiretor
            // 
            this.lblDiretor.AutoSize = true;
            this.lblDiretor.Location = new System.Drawing.Point(45, 180);
            this.lblDiretor.Name = "lblDiretor";
            this.lblDiretor.Size = new System.Drawing.Size(41, 13);
            this.lblDiretor.TabIndex = 4;
            this.lblDiretor.Text = "Diretor:";
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Location = new System.Drawing.Point(45, 206);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(51, 13);
            this.lblDuracao.TabIndex = 5;
            this.lblDuracao.Text = "Duração:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(45, 233);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 6;
            this.lblPreco.Text = "Preço:";
            // 
            // lblStck
            // 
            this.lblStck.AutoSize = true;
            this.lblStck.Location = new System.Drawing.Point(45, 261);
            this.lblStck.Name = "lblStck";
            this.lblStck.Size = new System.Drawing.Size(38, 13);
            this.lblStck.TabIndex = 7;
            this.lblStck.Text = "Stock:";
            // 
            // txtDiretor
            // 
            this.txtDiretor.Location = new System.Drawing.Point(95, 177);
            this.txtDiretor.Name = "txtDiretor";
            this.txtDiretor.Size = new System.Drawing.Size(152, 20);
            this.txtDiretor.TabIndex = 10;
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(95, 206);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(66, 20);
            this.txtDuracao.TabIndex = 11;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(95, 233);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(66, 20);
            this.txtPreco.TabIndex = 12;
            // 
            // txtStck
            // 
            this.txtStck.Location = new System.Drawing.Point(95, 258);
            this.txtStck.Name = "txtStck";
            this.txtStck.Size = new System.Drawing.Size(66, 20);
            this.txtStck.TabIndex = 13;
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Ação",
            "Comédia",
            "Drama",
            "Terror ",
            "Sci-Fi"});
            this.cbGenero.Location = new System.Drawing.Point(95, 123);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(109, 21);
            this.cbGenero.TabIndex = 14;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(14, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(28, 26);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(109, 302);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(122, 37);
            this.btnEdit.TabIndex = 31;
            this.btnEdit.Text = "Atualizar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(165, 347);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 13);
            this.lblFeedback.TabIndex = 30;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(257, 301);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 37);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(109, 301);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 37);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Adicionar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtProcurar
            // 
            this.txtProcurar.Location = new System.Drawing.Point(486, 87);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(539, 20);
            this.txtProcurar.TabIndex = 35;
            this.txtProcurar.Text = "Procurar";
            this.txtProcurar.Click += new System.EventHandler(this.txtProcurar_Click);
            this.txtProcurar.TextChanged += new System.EventHandler(this.txtProcurar_TextChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1055, 262);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(122, 65);
            this.btnPrint.TabIndex = 34;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1055, 144);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 65);
            this.btnEliminar.TabIndex = 33;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(451, 29);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(100, 31);
            this.lblClientes.TabIndex = 32;
            this.lblClientes.Text = "Filmes";
            this.lblClientes.UseWaitCursor = true;
            // 
            // dgvFilmes
            // 
            this.dgvFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmes.Location = new System.Drawing.Point(486, 113);
            this.dgvFilmes.Name = "dgvFilmes";
            this.dgvFilmes.Size = new System.Drawing.Size(539, 246);
            this.dgvFilmes.TabIndex = 36;
            this.dgvFilmes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilmes_CellClick);
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Location = new System.Drawing.Point(26, 375);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 13);
            this.lblErro.TabIndex = 37;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(80, 150);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(57, 20);
            this.txtAno.TabIndex = 38;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(322, 248);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 41;
            this.btnFind.Text = "Inserir";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblCapa
            // 
            this.lblCapa.AutoSize = true;
            this.lblCapa.Location = new System.Drawing.Point(345, 96);
            this.lblCapa.Name = "lblCapa";
            this.lblCapa.Size = new System.Drawing.Size(35, 13);
            this.lblCapa.TabIndex = 40;
            this.lblCapa.Text = "Capa:";
            // 
            // picCapa
            // 
            this.picCapa.Image = ((System.Drawing.Image)(resources.GetObject("picCapa.Image")));
            this.picCapa.InitialImage = null;
            this.picCapa.Location = new System.Drawing.Point(310, 112);
            this.picCapa.Name = "picCapa";
            this.picCapa.Size = new System.Drawing.Size(100, 131);
            this.picCapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCapa.TabIndex = 39;
            this.picCapa.TabStop = false;
            this.toolTip1.SetToolTip(this.picCapa, "Clica para introduzires uma nova imagem.");
            this.picCapa.Click += new System.EventHandler(this.picCapa_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // fFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 416);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblCapa);
            this.Controls.Add(this.picCapa);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.dgvFilmes);
            this.Controls.Add(this.txtProcurar);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.txtStck);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtDuracao);
            this.Controls.Add(this.txtDiretor);
            this.Controls.Add(this.lblStck);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblDuracao);
            this.Controls.Add(this.lblDiretor);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fFilmes";
            this.Text = "Gestão dos filmes";
            this.Load += new System.EventHandler(this.fFilmes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblDiretor;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblStck;
        private System.Windows.Forms.TextBox txtDiretor;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtStck;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.DataGridView dgvFilmes;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblCapa;
        private System.Windows.Forms.PictureBox picCapa;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}