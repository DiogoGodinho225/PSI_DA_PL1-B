namespace Projeto_DA.vistas
{
    partial class VerificarReservas
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
            this.listReservas = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEntregue = new System.Windows.Forms.Button();
            this.dateTimeDia = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listReservas
            // 
            this.listReservas.FormattingEnabled = true;
            this.listReservas.Location = new System.Drawing.Point(12, 28);
            this.listReservas.Name = "listReservas";
            this.listReservas.Size = new System.Drawing.Size(211, 173);
            this.listReservas.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 66;
            this.label5.Text = "Reservas";
            // 
            // btnEntregue
            // 
            this.btnEntregue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(87)))));
            this.btnEntregue.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold);
            this.btnEntregue.Location = new System.Drawing.Point(287, 107);
            this.btnEntregue.Name = "btnEntregue";
            this.btnEntregue.Size = new System.Drawing.Size(97, 32);
            this.btnEntregue.TabIndex = 67;
            this.btnEntregue.Text = "Entregue";
            this.btnEntregue.UseVisualStyleBackColor = false;
            this.btnEntregue.Click += new System.EventHandler(this.btnEntregue_Click);
            // 
            // dateTimeDia
            // 
            this.dateTimeDia.Location = new System.Drawing.Point(239, 28);
            this.dateTimeDia.Name = "dateTimeDia";
            this.dateTimeDia.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDia.TabIndex = 68;
            this.dateTimeDia.ValueChanged += new System.EventHandler(this.dateTimeDia_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(87)))));
            this.button1.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(287, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 32);
            this.button1.TabIndex = 69;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_DA.Properties.Resources.Design_sem_nome__3_;
            this.pictureBox1.Location = new System.Drawing.Point(2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(446, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // VerificarReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 221);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimeDia);
            this.Controls.Add(this.btnEntregue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listReservas);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VerificarReservas";
            this.Text = "VerificarReservas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listReservas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEntregue;
        private System.Windows.Forms.DateTimePicker dateTimeDia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}