namespace Projeto_DA.vistas
{
    partial class MenuReservas
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
            this.listMenu = new System.Windows.Forms.ListBox();
            this.listExtras = new System.Windows.Forms.ListBox();
            this.btnCriar = new System.Windows.Forms.Button();
            this.labelPrecoTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeDia = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.listProfessores = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listEstudantes = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listReservas = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFatura = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVerificarReservas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listMenu
            // 
            this.listMenu.FormattingEnabled = true;
            this.listMenu.Location = new System.Drawing.Point(15, 245);
            this.listMenu.Name = "listMenu";
            this.listMenu.Size = new System.Drawing.Size(205, 186);
            this.listMenu.TabIndex = 0;
            // 
            // listExtras
            // 
            this.listExtras.FormattingEnabled = true;
            this.listExtras.Location = new System.Drawing.Point(249, 245);
            this.listExtras.Name = "listExtras";
            this.listExtras.Size = new System.Drawing.Size(205, 186);
            this.listExtras.TabIndex = 1;
            this.listExtras.DoubleClick += new System.EventHandler(this.ReservaExtrasDoubleClick);
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(87)))));
            this.btnCriar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriar.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold);
            this.btnCriar.Location = new System.Drawing.Point(593, 461);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCriar.Size = new System.Drawing.Size(97, 32);
            this.btnCriar.TabIndex = 4;
            this.btnCriar.Text = "Criar Reserva";
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // labelPrecoTotal
            // 
            this.labelPrecoTotal.AutoSize = true;
            this.labelPrecoTotal.BackColor = System.Drawing.SystemColors.Window;
            this.labelPrecoTotal.Location = new System.Drawing.Point(652, 445);
            this.labelPrecoTotal.Name = "labelPrecoTotal";
            this.labelPrecoTotal.Size = new System.Drawing.Size(28, 13);
            this.labelPrecoTotal.TabIndex = 5;
            this.labelPrecoTotal.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(608, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Preço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Menus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Extras";
            // 
            // dateTimeDia
            // 
            this.dateTimeDia.Location = new System.Drawing.Point(12, 43);
            this.dateTimeDia.Name = "dateTimeDia";
            this.dateTimeDia.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDia.TabIndex = 42;
            this.dateTimeDia.ValueChanged += new System.EventHandler(this.dateTimeDia_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Dia";
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "Peixe",
            "Carne",
            "Vegetariano"});
            this.comboTipo.Location = new System.Drawing.Point(99, 218);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(121, 21);
            this.comboTipo.TabIndex = 44;
            this.comboTipo.SelectedIndexChanged += new System.EventHandler(this.comboTipo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(17, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Tipo de prato :";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(87)))));
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.Location = new System.Drawing.Point(593, 505);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(97, 32);
            this.btnVoltar.TabIndex = 46;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // listProfessores
            // 
            this.listProfessores.FormattingEnabled = true;
            this.listProfessores.Location = new System.Drawing.Point(247, 37);
            this.listProfessores.Name = "listProfessores";
            this.listProfessores.Size = new System.Drawing.Size(207, 160);
            this.listProfessores.TabIndex = 47;
            this.listProfessores.DoubleClick += new System.EventHandler(this.ReservaProfessoresDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(307, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 48;
            this.label7.Text = "Professor";
            // 
            // listEstudantes
            // 
            this.listEstudantes.FormattingEnabled = true;
            this.listEstudantes.Location = new System.Drawing.Point(483, 37);
            this.listEstudantes.Name = "listEstudantes";
            this.listEstudantes.Size = new System.Drawing.Size(207, 160);
            this.listEstudantes.TabIndex = 49;
            this.listEstudantes.DoubleClick += new System.EventHandler(this.ReservaEstudantesDoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(547, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 50;
            this.label8.Text = "Estudantes";
            // 
            // listReservas
            // 
            this.listReservas.FormattingEnabled = true;
            this.listReservas.Location = new System.Drawing.Point(485, 245);
            this.listReservas.Name = "listReservas";
            this.listReservas.Size = new System.Drawing.Size(205, 186);
            this.listReservas.TabIndex = 52;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_DA.Properties.Resources.Design_sem_nome__3_;
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(718, 551);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(552, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "Reserva";
            // 
            // btnFatura
            // 
            this.btnFatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(87)))));
            this.btnFatura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFatura.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold);
            this.btnFatura.Location = new System.Drawing.Point(483, 461);
            this.btnFatura.Name = "btnFatura";
            this.btnFatura.Size = new System.Drawing.Size(97, 32);
            this.btnFatura.TabIndex = 54;
            this.btnFatura.Text = "Fatura";
            this.btnFatura.UseVisualStyleBackColor = false;
            this.btnFatura.Click += new System.EventHandler(this.btnFatura_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(87)))));
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.Location = new System.Drawing.Point(485, 505);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(97, 32);
            this.btnLimpar.TabIndex = 55;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVerificarReservas
            // 
            this.btnVerificarReservas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(87)))));
            this.btnVerificarReservas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerificarReservas.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold);
            this.btnVerificarReservas.Location = new System.Drawing.Point(362, 505);
            this.btnVerificarReservas.Name = "btnVerificarReservas";
            this.btnVerificarReservas.Size = new System.Drawing.Size(108, 32);
            this.btnVerificarReservas.TabIndex = 56;
            this.btnVerificarReservas.Text = "Verificar Reservas";
            this.btnVerificarReservas.UseVisualStyleBackColor = false;
            this.btnVerificarReservas.Click += new System.EventHandler(this.btnVerificarReservas_Click);
            // 
            // MenuReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 549);
            this.Controls.Add(this.btnVerificarReservas);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFatura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listReservas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listEstudantes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listProfessores);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimeDia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPrecoTotal);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.listExtras);
            this.Controls.Add(this.listMenu);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MenuReservas";
            this.Text = "MenuReservas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listMenu;
        private System.Windows.Forms.ListBox listExtras;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Label labelPrecoTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeDia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ListBox listProfessores;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listEstudantes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listReservas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFatura;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVerificarReservas;
    }
}