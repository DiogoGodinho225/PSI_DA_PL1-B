namespace Projeto_DA.vistas
{
    partial class MenuPratos
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnapagar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btncriar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listPratos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Tipo";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(196, 88);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(144, 20);
            this.txtTipo.TabIndex = 59;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(239, 318);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(56, 25);
            this.btnVoltar.TabIndex = 58;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(239, 281);
            this.btneditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(56, 25);
            this.btneditar.TabIndex = 57;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnapagar
            // 
            this.btnapagar.Location = new System.Drawing.Point(239, 241);
            this.btnapagar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnapagar.Name = "btnapagar";
            this.btnapagar.Size = new System.Drawing.Size(56, 25);
            this.btnapagar.TabIndex = 56;
            this.btnapagar.Text = "Apagar";
            this.btnapagar.UseVisualStyleBackColor = true;
            this.btnapagar.Click += new System.EventHandler(this.btnapagar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Descricao";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(196, 42);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(144, 20);
            this.txtDescricao.TabIndex = 54;
            // 
            // btncriar
            // 
            this.btncriar.Location = new System.Drawing.Point(239, 202);
            this.btncriar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncriar.Name = "btncriar";
            this.btncriar.Size = new System.Drawing.Size(56, 25);
            this.btncriar.TabIndex = 53;
            this.btncriar.Text = "Criar";
            this.btncriar.UseVisualStyleBackColor = true;
            this.btncriar.Click += new System.EventHandler(this.btncriar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Pratos";
            // 
            // listPratos
            // 
            this.listPratos.FormattingEnabled = true;
            this.listPratos.Location = new System.Drawing.Point(9, 28);
            this.listPratos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listPratos.Name = "listPratos";
            this.listPratos.Size = new System.Drawing.Size(169, 316);
            this.listPratos.TabIndex = 51;
            this.listPratos.DoubleClick += new System.EventHandler(this.PratosDoubleClick);
            // 
            // MenuPratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnapagar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btncriar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listPratos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MenuPratos";
            this.Text = "MenuPratos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnapagar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btncriar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listPratos;
    }
}