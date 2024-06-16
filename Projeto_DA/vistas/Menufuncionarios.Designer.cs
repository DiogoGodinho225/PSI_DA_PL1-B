namespace Projeto_DA
{
    partial class Menufuncionarios
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
            this.listFuncionario = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncriar = new System.Windows.Forms.Button();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtnif = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnapagar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listFuncionario
            // 
            this.listFuncionario.FormattingEnabled = true;
            this.listFuncionario.ItemHeight = 16;
            this.listFuncionario.Location = new System.Drawing.Point(12, 28);
            this.listFuncionario.Name = "listFuncionario";
            this.listFuncionario.Size = new System.Drawing.Size(224, 388);
            this.listFuncionario.TabIndex = 0;
            this.listFuncionario.DoubleClick += new System.EventHandler(this.listFuncionariosDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Funcionarios";
            // 
            // btncriar
            // 
            this.btncriar.Location = new System.Drawing.Point(272, 213);
            this.btncriar.Name = "btncriar";
            this.btncriar.Size = new System.Drawing.Size(75, 23);
            this.btncriar.TabIndex = 2;
            this.btncriar.Text = "Criar";
            this.btncriar.UseVisualStyleBackColor = true;
            this.btncriar.Click += new System.EventHandler(this.btncriar_Click);
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(266, 56);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(100, 22);
            this.txtuser.TabIndex = 3;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(266, 104);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 22);
            this.txtnome.TabIndex = 4;
            // 
            // txtnif
            // 
            this.txtnif.Location = new System.Drawing.Point(266, 148);
            this.txtnif.Name = "txtnif";
            this.txtnif.Size = new System.Drawing.Size(100, 22);
            this.txtnif.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "NIF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Username";
            // 
            // btnapagar
            // 
            this.btnapagar.Location = new System.Drawing.Point(272, 263);
            this.btnapagar.Name = "btnapagar";
            this.btnapagar.Size = new System.Drawing.Size(75, 28);
            this.btnapagar.TabIndex = 9;
            this.btnapagar.Text = "Apagar";
            this.btnapagar.UseVisualStyleBackColor = true;
            this.btnapagar.Click += new System.EventHandler(this.btnapagar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(272, 318);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 29);
            this.btneditar.TabIndex = 10;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(272, 369);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 29);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnapagar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnif);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.btncriar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listFuncionario);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncriar;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtnif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnapagar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnVoltar;
    }
}