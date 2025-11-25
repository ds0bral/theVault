namespace theVault
{
    partial class fClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fClientes));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblMorada = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lblFoto = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblNascimento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(93, 107);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(94, 163);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(93, 189);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblMorada
            // 
            this.lblMorada.AutoSize = true;
            this.lblMorada.Location = new System.Drawing.Point(94, 216);
            this.lblMorada.Name = "lblMorada";
            this.lblMorada.Size = new System.Drawing.Size(46, 13);
            this.lblMorada.TabIndex = 3;
            this.lblMorada.Text = "Morada:";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(94, 243);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(75, 13);
            this.lblCP.TabIndex = 4;
            this.lblCP.Text = "Código Postal:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(137, 104);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(144, 20);
            this.txtNome.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtNome, "Introduza um nome");
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(135, 160);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(147, 20);
            this.txtEmail.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtEmail, "Introduza um email");
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(151, 186);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(131, 20);
            this.txtTelefone.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtTelefone, "Introduza um telefone válido");
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(146, 212);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(136, 20);
            this.txtMorada.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtMorada, "Introduza uma morada");
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(179, 240);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(103, 20);
            this.txtCP.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtCP, "Introduza um código postal válido (0000-000)");
            // 
            // picFoto
            // 
            this.picFoto.Image = ((System.Drawing.Image)(resources.GetObject("picFoto.Image")));
            this.picFoto.InitialImage = null;
            this.picFoto.Location = new System.Drawing.Point(326, 104);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(100, 126);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 10;
            this.picFoto.TabStop = false;
            this.toolTip1.SetToolTip(this.picFoto, "Clica para introduzires uma nova imagem.");
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(124, 293);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 37);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(272, 293);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 37);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(208, 38);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(99, 26);
            this.lblClientes.TabIndex = 13;
            this.lblClientes.Text = "Clientes";
            this.lblClientes.UseWaitCursor = true;
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(138, 337);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 13);
            this.lblFeedback.TabIndex = 14;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(361, 88);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(31, 13);
            this.lblFoto.TabIndex = 15;
            this.lblFoto.Text = "Foto:";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(338, 236);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 16;
            this.btnFind.Text = "Procurar:";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Location = new System.Drawing.Point(137, 134);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(144, 20);
            this.dtpNascimento.TabIndex = 17;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(25, 136);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(107, 13);
            this.lblNascimento.TabIndex = 18;
            this.lblNascimento.Text = "Data de Nascimento:";
            // 
            // fClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 376);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.lblMorada);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fClientes";
            this.Text = "Gestão dos clientes";
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblMorada;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label lblNascimento;
    }
}