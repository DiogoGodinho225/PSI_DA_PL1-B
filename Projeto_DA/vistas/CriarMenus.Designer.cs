namespace Projeto_DA.vistas
{
    partial class CriarMenus
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
            this.dateTimeMenu = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btncriar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listPratos = new System.Windows.Forms.ListBox();
            this.listMenu = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeMenu
            // 
            this.dateTimeMenu.Checked = false;
            this.dateTimeMenu.Location = new System.Drawing.Point(188, 367);
            this.dateTimeMenu.Name = "dateTimeMenu";
            this.dateTimeMenu.Size = new System.Drawing.Size(200, 20);
            this.dateTimeMenu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(53, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 67;
            this.label2.Text = "Pratos";
            // 
            // btncriar
            // 
            this.btncriar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(87)))));
            this.btncriar.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold);
            this.btncriar.ForeColor = System.Drawing.Color.Black;
            this.btncriar.Location = new System.Drawing.Point(243, 429);
            this.btncriar.Name = "btncriar";
            this.btncriar.Size = new System.Drawing.Size(97, 32);
            this.btncriar.TabIndex = 68;
            this.btncriar.Text = "Criar";
            this.btncriar.UseVisualStyleBackColor = false;
            this.btncriar.Click += new System.EventHandler(this.btncriar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(312, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 69;
            this.label3.Text = "Menu";
            // 
            // listPratos
            // 
            this.listPratos.FormattingEnabled = true;
            this.listPratos.Location = new System.Drawing.Point(12, 32);
            this.listPratos.Name = "listPratos";
            this.listPratos.Size = new System.Drawing.Size(249, 329);
            this.listPratos.TabIndex = 70;
            this.listPratos.DoubleClick += new System.EventHandler(this.pratosDoubleClick);
            // 
            // listMenu
            // 
            this.listMenu.FormattingEnabled = true;
            this.listMenu.Location = new System.Drawing.Point(315, 32);
            this.listMenu.Name = "listMenu";
            this.listMenu.Size = new System.Drawing.Size(250, 329);
            this.listMenu.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(185, 404);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 73;
            this.label4.Text = "Hora";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(243, 403);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 20);
            this.txtHora.TabIndex = 3;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(87)))));
            this.btnVoltar.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.Location = new System.Drawing.Point(243, 467);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(97, 32);
            this.btnVoltar.TabIndex = 74;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_DA.Properties.Resources.Design_sem_nome__3_;
            this.pictureBox1.Location = new System.Drawing.Point(1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(574, 536);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // CriarMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 530);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listMenu);
            this.Controls.Add(this.listPratos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncriar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.dateTimeMenu);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CriarMenus";
            this.Text = "CriarMenus";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimeMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncriar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listPratos;
        private System.Windows.Forms.ListBox listMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}