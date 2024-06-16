namespace Projeto_DA
{
    partial class Menuprincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listFuncionarios = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnmenu = new System.Windows.Forms.Button();
            this.btnmultas = new System.Windows.Forms.Button();
            this.btnreservas = new System.Windows.Forms.Button();
            this.btnextras = new System.Windows.Forms.Button();
            this.btnclientes = new System.Windows.Forms.Button();
            this.btnpratos = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Listmenu = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listFuncionarios
            // 
            this.listFuncionarios.FormattingEnabled = true;
            this.listFuncionarios.ItemHeight = 16;
            this.listFuncionarios.Location = new System.Drawing.Point(12, 40);
            this.listFuncionarios.Name = "listFuncionarios";
            this.listFuncionarios.Size = new System.Drawing.Size(288, 324);
            this.listFuncionarios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Utilizadores";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFuncionarios);
            this.groupBox1.Controls.Add(this.btnmenu);
            this.groupBox1.Controls.Add(this.btnmultas);
            this.groupBox1.Controls.Add(this.btnreservas);
            this.groupBox1.Controls.Add(this.btnextras);
            this.groupBox1.Controls.Add(this.btnclientes);
            this.groupBox1.Controls.Add(this.btnpratos);
            this.groupBox1.Location = new System.Drawing.Point(650, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 352);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Location = new System.Drawing.Point(38, 304);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(97, 40);
            this.btnFuncionarios.TabIndex = 9;
            this.btnFuncionarios.Text = "Funcionarios";
            this.btnFuncionarios.UseVisualStyleBackColor = true;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.Location = new System.Drawing.Point(38, 28);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(97, 40);
            this.btnmenu.TabIndex = 3;
            this.btnmenu.Text = "Menu";
            this.btnmenu.UseVisualStyleBackColor = true;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // btnmultas
            // 
            this.btnmultas.Location = new System.Drawing.Point(38, 258);
            this.btnmultas.Name = "btnmultas";
            this.btnmultas.Size = new System.Drawing.Size(97, 40);
            this.btnmultas.TabIndex = 6;
            this.btnmultas.Text = "Multas";
            this.btnmultas.UseVisualStyleBackColor = true;
            // 
            // btnreservas
            // 
            this.btnreservas.Location = new System.Drawing.Point(38, 166);
            this.btnreservas.Name = "btnreservas";
            this.btnreservas.Size = new System.Drawing.Size(97, 40);
            this.btnreservas.TabIndex = 7;
            this.btnreservas.Text = "Reservas";
            this.btnreservas.UseVisualStyleBackColor = true;
            // 
            // btnextras
            // 
            this.btnextras.Location = new System.Drawing.Point(38, 212);
            this.btnextras.Name = "btnextras";
            this.btnextras.Size = new System.Drawing.Size(97, 40);
            this.btnextras.TabIndex = 5;
            this.btnextras.Text = "Extras";
            this.btnextras.UseVisualStyleBackColor = true;
            this.btnextras.Click += new System.EventHandler(this.btnextras_Click);
            // 
            // btnclientes
            // 
            this.btnclientes.Location = new System.Drawing.Point(38, 74);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(97, 40);
            this.btnclientes.TabIndex = 8;
            this.btnclientes.Text = "Clientes";
            this.btnclientes.UseVisualStyleBackColor = true;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // btnpratos
            // 
            this.btnpratos.Location = new System.Drawing.Point(38, 120);
            this.btnpratos.Name = "btnpratos";
            this.btnpratos.Size = new System.Drawing.Size(97, 40);
            this.btnpratos.TabIndex = 4;
            this.btnpratos.Text = "Pratos";
            this.btnpratos.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(345, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // Listmenu
            // 
            this.Listmenu.FormattingEnabled = true;
            this.Listmenu.ItemHeight = 16;
            this.Listmenu.Location = new System.Drawing.Point(345, 72);
            this.Listmenu.Name = "Listmenu";
            this.Listmenu.Size = new System.Drawing.Size(227, 292);
            this.Listmenu.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Menus";
            // 
            // Menuprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 382);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Listmenu);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listFuncionarios);
            this.Name = "Menuprincipal";
            this.Text = ".";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Button btnpratos;
        private System.Windows.Forms.Button btnextras;
        private System.Windows.Forms.Button btnmultas;
        private System.Windows.Forms.Button btnreservas;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox Listmenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listFuncionarios;
    }
}

