namespace Projeto_DA.vistas
{
    partial class AdicionarQuantidadeExtras
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
            this.listExtras = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.Adicionar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtAdicionar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listExtras
            // 
            this.listExtras.FormattingEnabled = true;
            this.listExtras.Location = new System.Drawing.Point(10, 31);
            this.listExtras.Margin = new System.Windows.Forms.Padding(2);
            this.listExtras.Name = "listExtras";
            this.listExtras.Size = new System.Drawing.Size(141, 290);
            this.listExtras.TabIndex = 0;
            this.listExtras.DoubleClick += new System.EventHandler(this.QuantidadeExtraDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Extras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade atual";
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(159, 46);
            this.textBoxQuantidade.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(104, 20);
            this.textBoxQuantidade.TabIndex = 3;
            // 
            // Adicionar
            // 
            this.Adicionar.Location = new System.Drawing.Point(158, 121);
            this.Adicionar.Margin = new System.Windows.Forms.Padding(2);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(104, 35);
            this.Adicionar.TabIndex = 5;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.UseVisualStyleBackColor = true;
            this.Adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(158, 298);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(104, 23);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtAdicionar
            // 
            this.txtAdicionar.Location = new System.Drawing.Point(158, 96);
            this.txtAdicionar.Name = "txtAdicionar";
            this.txtAdicionar.Size = new System.Drawing.Size(104, 20);
            this.txtAdicionar.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantidade a adicionar";
            // 
            // AdicionarQuantidadeExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 342);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdicionar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listExtras);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdicionarQuantidadeExtras";
            this.Text = "AdicionarQuantidadeExtras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listExtras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtAdicionar;
        private System.Windows.Forms.Label label3;
    }
}