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
            this.SuspendLayout();
            // 
            // listProfessores
            // 
            this.listProfessores.FormattingEnabled = true;
            this.listProfessores.ItemHeight = 16;
            this.listProfessores.Location = new System.Drawing.Point(12, 23);
            this.listProfessores.Name = "listProfessores";
            this.listProfessores.Size = new System.Drawing.Size(241, 340);
            this.listProfessores.TabIndex = 0;
            // 
            // btnEstudantes
            // 
            this.btnEstudantes.Location = new System.Drawing.Point(440, 380);
            this.btnEstudantes.Name = "btnEstudantes";
            this.btnEstudantes.Size = new System.Drawing.Size(99, 46);
            this.btnEstudantes.TabIndex = 1;
            this.btnEstudantes.Text = "Estudantes";
            this.btnEstudantes.UseVisualStyleBackColor = true;
            this.btnEstudantes.Click += new System.EventHandler(this.btnEstudantes_Click);
            // 
            // btnProfessores
            // 
            this.btnProfessores.Location = new System.Drawing.Point(63, 380);
            this.btnProfessores.Name = "btnProfessores";
            this.btnProfessores.Size = new System.Drawing.Size(95, 46);
            this.btnProfessores.TabIndex = 2;
            this.btnProfessores.Text = "Professores";
            this.btnProfessores.UseVisualStyleBackColor = true;
            this.btnProfessores.Click += new System.EventHandler(this.btnProfessores_Click);
            // 
            // listEstudantes
            // 
            this.listEstudantes.FormattingEnabled = true;
            this.listEstudantes.ItemHeight = 16;
            this.listEstudantes.Location = new System.Drawing.Point(369, 23);
            this.listEstudantes.Name = "listEstudantes";
            this.listEstudantes.Size = new System.Drawing.Size(241, 340);
            this.listEstudantes.TabIndex = 3;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(242, 380);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(110, 46);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Menuclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.listEstudantes);
            this.Controls.Add(this.btnProfessores);
            this.Controls.Add(this.btnEstudantes);
            this.Controls.Add(this.listProfessores);
            this.Name = "Menuclientes";
            this.Text = "Menuclientes";
            this.Load += new System.EventHandler(this.Menuclientes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listProfessores;
        private System.Windows.Forms.Button btnEstudantes;
        private System.Windows.Forms.Button btnProfessores;
        private System.Windows.Forms.ListBox listEstudantes;
        private System.Windows.Forms.Button btnVoltar;
    }
}