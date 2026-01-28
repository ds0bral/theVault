namespace theVault.Alugueres
{
    partial class fAlugueres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAlugueres));
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFilme = new System.Windows.Forms.Label();
            this.dtpPrevista = new System.Windows.Forms.DateTimePicker();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.cbFilme = new System.Windows.Forms.ComboBox();
            this.lblPrevista = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblErro = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lblAlugueres = new System.Windows.Forms.Label();
            this.lblEntrega = new System.Windows.Forms.Label();
            this.dtpEntrega = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProcurar
            // 
            this.txtProcurar.Location = new System.Drawing.Point(355, 104);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(539, 20);
            this.txtProcurar.TabIndex = 28;
            this.txtProcurar.Text = "Procurar";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(922, 275);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(122, 65);
            this.btnPrint.TabIndex = 27;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(922, 170);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 65);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(355, 136);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(539, 246);
            this.dgvClientes.TabIndex = 25;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(15, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(28, 26);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(98, 134);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 30;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblFilme
            // 
            this.lblFilme.AutoSize = true;
            this.lblFilme.Location = new System.Drawing.Point(98, 163);
            this.lblFilme.Name = "lblFilme";
            this.lblFilme.Size = new System.Drawing.Size(34, 13);
            this.lblFilme.TabIndex = 31;
            this.lblFilme.Text = "Filme:";
            // 
            // dtpPrevista
            // 
            this.dtpPrevista.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPrevista.Location = new System.Drawing.Point(177, 190);
            this.dtpPrevista.Name = "dtpPrevista";
            this.dtpPrevista.Size = new System.Drawing.Size(108, 20);
            this.dtpPrevista.TabIndex = 32;
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(146, 130);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(139, 21);
            this.cbCliente.TabIndex = 33;
            // 
            // cbFilme
            // 
            this.cbFilme.FormattingEnabled = true;
            this.cbFilme.Location = new System.Drawing.Point(138, 160);
            this.cbFilme.Name = "cbFilme";
            this.cbFilme.Size = new System.Drawing.Size(147, 21);
            this.cbFilme.TabIndex = 34;
            // 
            // lblPrevista
            // 
            this.lblPrevista.AutoSize = true;
            this.lblPrevista.Location = new System.Drawing.Point(98, 192);
            this.lblPrevista.Name = "lblPrevista";
            this.lblPrevista.Size = new System.Drawing.Size(74, 13);
            this.lblPrevista.TabIndex = 35;
            this.lblPrevista.Text = "Data Prevista:";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(51, 263);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(122, 37);
            this.btnEdit.TabIndex = 38;
            this.btnEdit.Text = "Devolver";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(199, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 37);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(51, 263);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 37);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Adicionar";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Location = new System.Drawing.Point(34, 395);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 13);
            this.lblErro.TabIndex = 40;
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(107, 312);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 13);
            this.lblFeedback.TabIndex = 39;
            // 
            // lblAlugueres
            // 
            this.lblAlugueres.AutoSize = true;
            this.lblAlugueres.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlugueres.Location = new System.Drawing.Point(353, 39);
            this.lblAlugueres.Name = "lblAlugueres";
            this.lblAlugueres.Size = new System.Drawing.Size(145, 31);
            this.lblAlugueres.TabIndex = 41;
            this.lblAlugueres.Text = "Alugueres";
            this.lblAlugueres.UseWaitCursor = true;
            // 
            // lblEntrega
            // 
            this.lblEntrega.AutoSize = true;
            this.lblEntrega.Location = new System.Drawing.Point(99, 218);
            this.lblEntrega.Name = "lblEntrega";
            this.lblEntrega.Size = new System.Drawing.Size(73, 13);
            this.lblEntrega.TabIndex = 42;
            this.lblEntrega.Text = "Data Entrega:";
            // 
            // dtpEntrega
            // 
            this.dtpEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrega.Location = new System.Drawing.Point(177, 216);
            this.dtpEntrega.Name = "dtpEntrega";
            this.dtpEntrega.Size = new System.Drawing.Size(108, 20);
            this.dtpEntrega.TabIndex = 43;
            // 
            // fAlugueres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 431);
            this.Controls.Add(this.dtpEntrega);
            this.Controls.Add(this.lblEntrega);
            this.Controls.Add(this.lblAlugueres);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPrevista);
            this.Controls.Add(this.cbFilme);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.dtpPrevista);
            this.Controls.Add(this.lblFilme);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtProcurar);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fAlugueres";
            this.Text = "Gestão dos alugueres";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fAlugueres_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFilme;
        private System.Windows.Forms.DateTimePicker dtpPrevista;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox cbFilme;
        private System.Windows.Forms.Label lblPrevista;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label lblAlugueres;
        private System.Windows.Forms.Label lblEntrega;
        private System.Windows.Forms.DateTimePicker dtpEntrega;
    }
}