namespace Projeto_DA.vistas
{
    partial class Saldo
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxsaldo = new System.Windows.Forms.TextBox();
            this.btnAddSaldo = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserir Saldo:";
            // 
            // textBoxsaldo
            // 
            this.textBoxsaldo.Location = new System.Drawing.Point(86, 28);
            this.textBoxsaldo.Name = "textBoxsaldo";
            this.textBoxsaldo.Size = new System.Drawing.Size(100, 20);
            this.textBoxsaldo.TabIndex = 1;
            // 
            // btnAddSaldo
            // 
            this.btnAddSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(87)))));
            this.btnAddSaldo.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold);
            this.btnAddSaldo.Location = new System.Drawing.Point(57, 75);
            this.btnAddSaldo.Name = "btnAddSaldo";
            this.btnAddSaldo.Size = new System.Drawing.Size(97, 32);
            this.btnAddSaldo.TabIndex = 2;
            this.btnAddSaldo.Text = "Adicionar";
            this.btnAddSaldo.UseVisualStyleBackColor = false;
            this.btnAddSaldo.Click += new System.EventHandler(this.btnAddSaldo_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(87)))));
            this.btnVoltar.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.Location = new System.Drawing.Point(57, 147);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(97, 32);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_DA.Properties.Resources.Design_sem_nome__3_;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Saldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 191);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAddSaldo);
            this.Controls.Add(this.textBoxsaldo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Saldo";
            this.Text = "Saldo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxsaldo;
        private System.Windows.Forms.Button btnAddSaldo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}