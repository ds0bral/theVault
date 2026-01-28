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
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.cbFilme = new System.Windows.Forms.ComboBox();
            this.dtpAquisicao = new System.Windows.Forms.DateTimePicker();
            this.dtpPrevista = new System.Windows.Forms.DateTimePicker();
            this.dtpEntrega = new System.Windows.Forms.DateTimePicker();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAlugueres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(110, 119);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(155, 21);
            this.cbCliente.TabIndex = 0;
            // 
            // cbFilme
            // 
            this.cbFilme.FormattingEnabled = true;
            this.cbFilme.Location = new System.Drawing.Point(110, 146);
            this.cbFilme.Name = "cbFilme";
            this.cbFilme.Size = new System.Drawing.Size(155, 21);
            this.cbFilme.TabIndex = 1;
            // 
            // dtpAquisicao
            // 
            this.dtpAquisicao.Location = new System.Drawing.Point(152, 203);
            this.dtpAquisicao.Name = "dtpAquisicao";
            this.dtpAquisicao.Size = new System.Drawing.Size(144, 20);
            this.dtpAquisicao.TabIndex = 18;
            // 
            // dtpPrevista
            // 
            this.dtpPrevista.Location = new System.Drawing.Point(192, 235);
            this.dtpPrevista.Name = "dtpPrevista";
            this.dtpPrevista.Size = new System.Drawing.Size(144, 20);
            this.dtpPrevista.TabIndex = 19;
            // 
            // dtpEntrega
            // 
            this.dtpEntrega.Location = new System.Drawing.Point(143, 261);
            this.dtpEntrega.Name = "dtpEntrega";
            this.dtpEntrega.Size = new System.Drawing.Size(144, 20);
            this.dtpEntrega.TabIndex = 20;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(52, 119);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 21;
            this.lblCliente.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Filme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Data de aquisição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Data prevista para entrega:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Data de entrega:";
            // 
            // lblAlugueres
            // 
            this.lblAlugueres.AutoSize = true;
            this.lblAlugueres.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlugueres.Location = new System.Drawing.Point(306, 37);
            this.lblAlugueres.Name = "lblAlugueres";
            this.lblAlugueres.Size = new System.Drawing.Size(145, 31);
            this.lblAlugueres.TabIndex = 26;
            this.lblAlugueres.Text = "Alugueres";
            this.lblAlugueres.UseWaitCursor = true;
            // 
            // fAlugueres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAlugueres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.dtpEntrega);
            this.Controls.Add(this.dtpPrevista);
            this.Controls.Add(this.dtpAquisicao);
            this.Controls.Add(this.cbFilme);
            this.Controls.Add(this.cbCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fAlugueres";
            this.Text = "Gestão dos alugueres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox cbFilme;
        private System.Windows.Forms.DateTimePicker dtpAquisicao;
        private System.Windows.Forms.DateTimePicker dtpPrevista;
        private System.Windows.Forms.DateTimePicker dtpEntrega;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAlugueres;
    }
}