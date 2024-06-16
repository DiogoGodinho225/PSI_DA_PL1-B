namespace Projeto_DA.vistas
{
    partial class Menuclientes
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
            this.listProfessores = new System.Windows.Forms.ListBox();
            this.btnEstudantes = new System.Windows.Forms.Button();
            this.btnProfessores = new System.Windows.Forms.Button();
            this.listEstudantes = new System.Windows.Forms.ListBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listProfessores
            // 
            this.listProfessores.FormattingEnabled = true;
            this.listProfessores.Location = new System.Drawing.Point(27, 54);
            this.listProfessores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listProfessores.Name = "listProfessores";
            this.listProfessores.Size = new System.Drawing.Size(182, 277);
            this.listProfessores.TabIndex = 0;
            // 
            // btnEstudantes
            // 
            this.btnEstudantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(87)))));
            this.btnEstudantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstudantes.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold);
            this.btnEstudantes.Location = new System.Drawing.Point(371, 333);
            this.btnEstudantes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEstudantes.Name = "btnEstudantes";
            this.btnEstudantes.Size = new System.Drawing.Size(97, 32);
            this.btnEstudantes.TabIndex = 1;
            this.btnEstudantes.Text = "Estudantes";
            this.btnEstudantes.UseVisualStyleBackColor = false;
            this.btnEstudantes.Click += new System.EventHandler(this.btnEstudantes_Click);
            // 
            // btnProfessores
            // 
            this.btnProfessores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(87)))));
            this.btnProfessores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfessores.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold);
            this.btnProfessores.Location = new System.Drawing.Point(62, 335);
            this.btnProfessores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProfessores.Name = "btnProfessores";
            this.btnProfessores.Size = new System.Drawing.Size(97, 32);
            this.btnProfessores.TabIndex = 2;
            this.btnProfessores.Text = "Professores";
            this.btnProfessores.UseVisualStyleBackColor = false;
            this.btnProfessores.Click += new System.EventHandler(this.btnProfessores_Click);
            // 
            // listEstudantes
            // 
            this.listEstudantes.FormattingEnabled = true;
            this.listEstudantes.Location = new System.Drawing.Point(318, 52);
            this.listEstudantes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listEstudantes.Name = "listEstudantes";
            this.listEstudantes.Size = new System.Drawing.Size(182, 277);
            this.listEstudantes.TabIndex = 3;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Location = new System.Drawing.Point(207, 356);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(97, 32);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_DA.Properties.Resources.Design_sem_nome__3_;
            this.pictureBox1.Location = new System.Drawing.Point(-63, -40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(593, 446);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(367, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 19);
            this.label5.TabIndex = 39;
            this.label5.Text = "Estudantes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "Professores";
            // 
            // Menuclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 408);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.listEstudantes);
            this.Controls.Add(this.btnProfessores);
            this.Controls.Add(this.btnEstudantes);
            this.Controls.Add(this.listProfessores);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menuclientes";
            this.Text = "Menuclientes";
            this.Load += new System.EventHandler(this.Menuclientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listProfessores;
        private System.Windows.Forms.Button btnEstudantes;
        private System.Windows.Forms.Button btnProfessores;
        private System.Windows.Forms.ListBox listEstudantes;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}