namespace Projeto_DA.vistas
{
    partial class MenuProfessores
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnapagar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnif = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btncriar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listProfessores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(290, 380);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 31);
            this.btnVoltar.TabIndex = 35;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(290, 314);
            this.btneditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 31);
            this.btneditar.TabIndex = 34;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnapagar
            // 
            this.btnapagar.Location = new System.Drawing.Point(290, 260);
            this.btnapagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnapagar.Name = "btnapagar";
            this.btnapagar.Size = new System.Drawing.Size(75, 31);
            this.btnapagar.TabIndex = 33;
            this.btnapagar.Text = "Apagar";
            this.btnapagar.UseVisualStyleBackColor = true;
            this.btnapagar.Click += new System.EventHandler(this.btnapagar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "NIF";
            // 
            // txtnif
            // 
            this.txtnif.Location = new System.Drawing.Point(281, 157);
            this.txtnif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnif.Name = "txtnif";
            this.txtnif.Size = new System.Drawing.Size(100, 22);
            this.txtnif.TabIndex = 29;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(281, 109);
            this.txtnome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 22);
            this.txtnome.TabIndex = 28;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(281, 61);
            this.txtemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 22);
            this.txtemail.TabIndex = 27;
            // 
            // btncriar
            // 
            this.btncriar.Location = new System.Drawing.Point(290, 210);
            this.btncriar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncriar.Name = "btncriar";
            this.btncriar.Size = new System.Drawing.Size(75, 31);
            this.btncriar.TabIndex = 26;
            this.btncriar.Text = "Criar";
            this.btncriar.UseVisualStyleBackColor = true;
            this.btncriar.Click += new System.EventHandler(this.btncriar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Professores";
            // 
            // listProfessores
            // 
            this.listProfessores.FormattingEnabled = true;
            this.listProfessores.ItemHeight = 16;
            this.listProfessores.Location = new System.Drawing.Point(28, 40);
            this.listProfessores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listProfessores.Name = "listProfessores";
            this.listProfessores.Size = new System.Drawing.Size(224, 388);
            this.listProfessores.TabIndex = 24;
            this.listProfessores.DoubleClick += new System.EventHandler(this.ProfessoresDoubleClick);
            // 
            // MenuProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnapagar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnif);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.btncriar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listProfessores);
            this.Name = "MenuProfessores";
            this.Text = "MenuProfessores";
            this.Load += new System.EventHandler(this.MenuProfessores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnapagar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnif;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btncriar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listProfessores;
    }
}