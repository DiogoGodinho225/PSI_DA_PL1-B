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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listFuncionarios
            // 
            this.listFuncionarios.FormattingEnabled = true;
            this.listFuncionarios.Location = new System.Drawing.Point(21, 44);
            this.listFuncionarios.Margin = new System.Windows.Forms.Padding(2);
            this.listFuncionarios.Name = "listFuncionarios";
            this.listFuncionarios.Size = new System.Drawing.Size(233, 290);
            this.listFuncionarios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Utilizadores";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.btnFuncionarios);
            this.groupBox1.Controls.Add(this.btnmenu);
            this.groupBox1.Controls.Add(this.btnmultas);
            this.groupBox1.Controls.Add(this.btnreservas);
            this.groupBox1.Controls.Add(this.btnextras);
            this.groupBox1.Controls.Add(this.btnclientes);
            this.groupBox1.Controls.Add(this.btnpratos);
            this.groupBox1.Location = new System.Drawing.Point(540, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(127, 286);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(87)))));
            this.btnFuncionarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFuncionarios.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.Location = new System.Drawing.Point(14, 246);
            this.btnFuncionarios.Margin = new System.Windows.Forms.Padding(2);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(97, 32);
            this.btnFuncionarios.TabIndex = 9;
            this.btnFuncionarios.Text = "Funcionarios";
            this.btnFuncionarios.UseVisualStyleBackColor = false;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(87)))));
            this.btnmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmenu.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnmenu.Location = new System.Drawing.Point(14, 23);
            this.btnmenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(97, 32);
            this.btnmenu.TabIndex = 3;
            this.btnmenu.Text = "Menu";
            this.btnmenu.UseVisualStyleBackColor = false;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // btnmultas
            // 
            this.btnmultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(87)))));
            this.btnmultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmultas.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultas.Location = new System.Drawing.Point(14, 210);
            this.btnmultas.Margin = new System.Windows.Forms.Padding(2);
            this.btnmultas.Name = "btnmultas";
            this.btnmultas.Size = new System.Drawing.Size(97, 32);
            this.btnmultas.TabIndex = 6;
            this.btnmultas.Text = "Multas";
            this.btnmultas.UseVisualStyleBackColor = false;
            // 
            // btnreservas
            // 
            this.btnreservas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(87)))));
            this.btnreservas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreservas.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreservas.Location = new System.Drawing.Point(14, 134);
            this.btnreservas.Margin = new System.Windows.Forms.Padding(2);
            this.btnreservas.Name = "btnreservas";
            this.btnreservas.Size = new System.Drawing.Size(97, 32);
            this.btnreservas.TabIndex = 7;
            this.btnreservas.Text = "Reservas";
            this.btnreservas.UseVisualStyleBackColor = false;
            this.btnreservas.Click += new System.EventHandler(this.btnreservas_Click);
            // 
            // btnextras
            // 
            this.btnextras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(87)))));
            this.btnextras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnextras.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnextras.Location = new System.Drawing.Point(14, 171);
            this.btnextras.Margin = new System.Windows.Forms.Padding(2);
            this.btnextras.Name = "btnextras";
            this.btnextras.Size = new System.Drawing.Size(97, 32);
            this.btnextras.TabIndex = 5;
            this.btnextras.Text = "Extras";
            this.btnextras.UseVisualStyleBackColor = false;
            this.btnextras.Click += new System.EventHandler(this.btnextras_Click);
            // 
            // btnclientes
            // 
            this.btnclientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(87)))));
            this.btnclientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclientes.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclientes.Location = new System.Drawing.Point(14, 59);
            this.btnclientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(97, 32);
            this.btnclientes.TabIndex = 8;
            this.btnclientes.Text = "Clientes";
            this.btnclientes.UseVisualStyleBackColor = false;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // btnpratos
            // 
            this.btnpratos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(87)))));
            this.btnpratos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpratos.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpratos.Location = new System.Drawing.Point(14, 98);
            this.btnpratos.Margin = new System.Windows.Forms.Padding(2);
            this.btnpratos.Name = "btnpratos";
            this.btnpratos.Size = new System.Drawing.Size(97, 32);
            this.btnpratos.TabIndex = 4;
            this.btnpratos.Text = "Pratos";
            this.btnpratos.UseVisualStyleBackColor = false;
            this.btnpratos.Click += new System.EventHandler(this.btnpratos_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(269, 46);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // Listmenu
            // 
            this.Listmenu.FormattingEnabled = true;
            this.Listmenu.Location = new System.Drawing.Point(269, 70);
            this.Listmenu.Margin = new System.Windows.Forms.Padding(2);
            this.Listmenu.Name = "Listmenu";
            this.Listmenu.Size = new System.Drawing.Size(251, 264);
            this.Listmenu.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Menus";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_DA.Properties.Resources.Design_sem_nome__3_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(690, 369);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Menuprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 372);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Listmenu);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listFuncionarios);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menuprincipal";
            this.Text = "ReservEat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ListBox listFuncionarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

