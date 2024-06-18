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
            this.SuspendLayout();
            // 
            // dateTimeMenu
            // 
            this.dateTimeMenu.Checked = false;
            this.dateTimeMenu.Location = new System.Drawing.Point(78, 387);
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
            this.label2.Location = new System.Drawing.Point(11, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 67;
            this.label2.Text = "Pratos";
            // 
            // btncriar
            // 
            this.btncriar.Location = new System.Drawing.Point(131, 455);
            this.btncriar.Name = "btncriar";
            this.btncriar.Size = new System.Drawing.Size(75, 23);
            this.btncriar.TabIndex = 68;
            this.btncriar.Text = "Criar";
            this.btncriar.UseVisualStyleBackColor = true;
            this.btncriar.Click += new System.EventHandler(this.btncriar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(193, 9);
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
            this.listPratos.Size = new System.Drawing.Size(124, 329);
            this.listPratos.TabIndex = 70;
            this.listPratos.DoubleClick += new System.EventHandler(this.pratosDoubleClick);
            // 
            // listMenu
            // 
            this.listMenu.FormattingEnabled = true;
            this.listMenu.Location = new System.Drawing.Point(196, 32);
            this.listMenu.Name = "listMenu";
            this.listMenu.Size = new System.Drawing.Size(149, 329);
            this.listMenu.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(147, 410);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 73;
            this.label4.Text = "Hora";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(120, 429);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 20);
            this.txtHora.TabIndex = 3;
            // 
            // CriarMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 530);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listMenu);
            this.Controls.Add(this.listPratos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncriar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.dateTimeMenu);
            this.Name = "CriarMenus";
            this.Text = "CriarMenus";
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
    }
}