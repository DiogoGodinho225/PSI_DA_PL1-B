namespace Projeto_DA.vistas
{
    partial class MenuMultas
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
            this.listMultas = new System.Windows.Forms.ListBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.textBoxHoras = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listMultas
            // 
            this.listMultas.FormattingEnabled = true;
            this.listMultas.Location = new System.Drawing.Point(13, 40);
            this.listMultas.Name = "listMultas";
            this.listMultas.Size = new System.Drawing.Size(120, 251);
            this.listMultas.TabIndex = 0;
            this.listMultas.DoubleClick += new System.EventHandler(this.ListMultaDoubleClick);
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(276, 44);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(100, 20);
            this.textBoxValor.TabIndex = 1;
            // 
            // textBoxHoras
            // 
            this.textBoxHoras.Location = new System.Drawing.Point(276, 88);
            this.textBoxHoras.Name = "textBoxHoras";
            this.textBoxHoras.Size = new System.Drawing.Size(100, 20);
            this.textBoxHoras.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(229, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 49;
            this.label7.Text = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Quantidade Horas";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(87)))));
            this.button1.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(260, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 32);
            this.button1.TabIndex = 51;
            this.button1.Text = "Criar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(87)))));
            this.button2.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(260, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 32);
            this.button2.TabIndex = 52;
            this.button2.Text = "Apagar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(87)))));
            this.button3.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(260, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 32);
            this.button3.TabIndex = 53;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(87)))));
            this.button4.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(260, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 32);
            this.button4.TabIndex = 54;
            this.button4.Text = "Voltar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_DA.Properties.Resources.Design_sem_nome__3_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "Multas";
            // 
            // MenuMultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 305);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxHoras);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.listMultas);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MenuMultas";
            this.Text = "MenuMultas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listMultas;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.TextBox textBoxHoras;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}