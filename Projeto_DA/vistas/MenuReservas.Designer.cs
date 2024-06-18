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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.listProfessores = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listEstudantes = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listMenu
            // 
            this.listMenu.FormattingEnabled = true;
            this.listMenu.Location = new System.Drawing.Point(12, 85);
            this.listMenu.Name = "listMenu";
            this.listMenu.Size = new System.Drawing.Size(246, 17);
            this.listMenu.TabIndex = 0;
            // 
            // listExtras
            // 
            this.listExtras.FormattingEnabled = true;
            this.listExtras.Location = new System.Drawing.Point(12, 159);
            this.listExtras.Name = "listExtras";
            this.listExtras.Size = new System.Drawing.Size(190, 147);
            this.listExtras.TabIndex = 1;
            this.listExtras.DoubleClick += new System.EventHandler(this.ReservaExtrasDoubleClick);
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(670, 85);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(99, 23);
            this.btnCriar.TabIndex = 4;
            this.btnCriar.Text = "Criar Reserva";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // labelPrecoTotal
            // 
            this.labelPrecoTotal.AutoSize = true;
            this.labelPrecoTotal.Location = new System.Drawing.Point(710, 50);
            this.labelPrecoTotal.Name = "labelPrecoTotal";
            this.labelPrecoTotal.Size = new System.Drawing.Size(28, 13);
            this.labelPrecoTotal.TabIndex = 5;
            this.labelPrecoTotal.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(666, 50);
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
            this.label5.Location = new System.Drawing.Point(9, 66);
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
            this.label3.Location = new System.Drawing.Point(9, 140);
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
            this.label4.Location = new System.Drawing.Point(11, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Dia";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Peixe",
            "Carne",
            "Vegetariano"});
            this.comboBox1.Location = new System.Drawing.Point(81, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Tipo de prato :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(684, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listProfessores
            // 
            this.listProfessores.FormattingEnabled = true;
            this.listProfessores.Location = new System.Drawing.Point(274, 44);
            this.listProfessores.Name = "listProfessores";
            this.listProfessores.Size = new System.Drawing.Size(190, 251);
            this.listProfessores.TabIndex = 47;
            this.listProfessores.DoubleClick += new System.EventHandler(this.ReservaProfessoresDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(271, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 48;
            this.label7.Text = "Professor";
            // 
            // listEstudantes
            // 
            this.listEstudantes.FormattingEnabled = true;
            this.listEstudantes.Location = new System.Drawing.Point(470, 44);
            this.listEstudantes.Name = "listEstudantes";
            this.listEstudantes.Size = new System.Drawing.Size(190, 251);
            this.listEstudantes.TabIndex = 49;
            this.listEstudantes.DoubleClick += new System.EventHandler(this.ReservaEstudantesDoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(467, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 50;
            this.label8.Text = "Estudantes";
            // 
            // MenuReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 352);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listEstudantes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listProfessores);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimeDia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPrecoTotal);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.listExtras);
            this.Controls.Add(this.listMenu);
            this.Name = "MenuReservas";
            this.Text = "MenuReservas";
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listProfessores;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listEstudantes;
        private System.Windows.Forms.Label label8;
    }
}