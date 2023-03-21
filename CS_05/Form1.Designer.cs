namespace CS_05
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtDollar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDollar = new System.Windows.Forms.Label();
            this.btnDollar = new System.Windows.Forms.Button();
            this.btnCelcius = new System.Windows.Forms.Button();
            this.lbCelcius = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCelcius = new System.Windows.Forms.TextBox();
            this.btnFahrenheit = new System.Windows.Forms.Button();
            this.lbFahrenheit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCot = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDollar
            // 
            this.txtDollar.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDollar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(180)))), ((int)(((byte)(231)))));
            this.txtDollar.Location = new System.Drawing.Point(121, 103);
            this.txtDollar.Name = "txtDollar";
            this.txtDollar.Size = new System.Drawing.Size(100, 28);
            this.txtDollar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dolar:";
            // 
            // lbDollar
            // 
            this.lbDollar.AutoSize = true;
            this.lbDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDollar.Location = new System.Drawing.Point(233, 105);
            this.lbDollar.Name = "lbDollar";
            this.lbDollar.Size = new System.Drawing.Size(100, 26);
            this.lbDollar.TabIndex = 2;
            this.lbDollar.Text = "R$ 00,00";
            this.lbDollar.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnDollar
            // 
            this.btnDollar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(180)))), ((int)(((byte)(231)))));
            this.btnDollar.FlatAppearance.BorderSize = 0;
            this.btnDollar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDollar.ForeColor = System.Drawing.Color.Black;
            this.btnDollar.Location = new System.Drawing.Point(353, 99);
            this.btnDollar.Name = "btnDollar";
            this.btnDollar.Size = new System.Drawing.Size(131, 36);
            this.btnDollar.TabIndex = 3;
            this.btnDollar.Text = "Converter";
            this.btnDollar.UseVisualStyleBackColor = false;
            this.btnDollar.Click += new System.EventHandler(this.btnDollar_Click);
            // 
            // btnCelcius
            // 
            this.btnCelcius.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(180)))), ((int)(((byte)(231)))));
            this.btnCelcius.FlatAppearance.BorderSize = 0;
            this.btnCelcius.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCelcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCelcius.ForeColor = System.Drawing.Color.Black;
            this.btnCelcius.Location = new System.Drawing.Point(353, 141);
            this.btnCelcius.Name = "btnCelcius";
            this.btnCelcius.Size = new System.Drawing.Size(131, 36);
            this.btnCelcius.TabIndex = 7;
            this.btnCelcius.Text = "Converter";
            this.btnCelcius.UseVisualStyleBackColor = false;
            this.btnCelcius.Click += new System.EventHandler(this.btnCelcius_Click);
            // 
            // lbCelcius
            // 
            this.lbCelcius.AutoSize = true;
            this.lbCelcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCelcius.Location = new System.Drawing.Point(228, 147);
            this.lbCelcius.Name = "lbCelcius";
            this.lbCelcius.Size = new System.Drawing.Size(76, 26);
            this.lbCelcius.TabIndex = 6;
            this.lbCelcius.Text = "°Fh 00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "°C:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCelcius
            // 
            this.txtCelcius.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCelcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelcius.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(180)))), ((int)(((byte)(231)))));
            this.txtCelcius.Location = new System.Drawing.Point(121, 145);
            this.txtCelcius.Name = "txtCelcius";
            this.txtCelcius.Size = new System.Drawing.Size(100, 28);
            this.txtCelcius.TabIndex = 4;
            // 
            // btnFahrenheit
            // 
            this.btnFahrenheit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(180)))), ((int)(((byte)(231)))));
            this.btnFahrenheit.FlatAppearance.BorderSize = 0;
            this.btnFahrenheit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFahrenheit.ForeColor = System.Drawing.Color.Black;
            this.btnFahrenheit.Location = new System.Drawing.Point(353, 183);
            this.btnFahrenheit.Name = "btnFahrenheit";
            this.btnFahrenheit.Size = new System.Drawing.Size(131, 36);
            this.btnFahrenheit.TabIndex = 11;
            this.btnFahrenheit.Text = "Converter";
            this.btnFahrenheit.UseVisualStyleBackColor = false;
            this.btnFahrenheit.Click += new System.EventHandler(this.btnFahrenheit_Click);
            // 
            // lbFahrenheit
            // 
            this.lbFahrenheit.AutoSize = true;
            this.lbFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFahrenheit.Location = new System.Drawing.Point(228, 187);
            this.lbFahrenheit.Name = "lbFahrenheit";
            this.lbFahrenheit.Size = new System.Drawing.Size(67, 26);
            this.lbFahrenheit.TabIndex = 10;
            this.lbFahrenheit.Text = "°C 00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "°Fh:";
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFahrenheit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(180)))), ((int)(((byte)(231)))));
            this.txtFahrenheit.Location = new System.Drawing.Point(121, 187);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(100, 28);
            this.txtFahrenheit.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(179, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 36);
            this.label7.TabIndex = 12;
            this.label7.Text = "Conversor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cotação:";
            // 
            // txtCot
            // 
            this.txtCot.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(180)))), ((int)(((byte)(231)))));
            this.txtCot.Location = new System.Drawing.Point(266, 59);
            this.txtCot.Name = "txtCot";
            this.txtCot.Size = new System.Drawing.Size(99, 28);
            this.txtCot.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(551, 252);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFahrenheit);
            this.Controls.Add(this.lbFahrenheit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.btnCelcius);
            this.Controls.Add(this.lbCelcius);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCelcius);
            this.Controls.Add(this.btnDollar);
            this.Controls.Add(this.lbDollar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDollar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(180)))), ((int)(((byte)(231)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDollar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDollar;
        private System.Windows.Forms.Button btnDollar;
        private System.Windows.Forms.Button btnCelcius;
        private System.Windows.Forms.Label lbCelcius;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCelcius;
        private System.Windows.Forms.Button btnFahrenheit;
        private System.Windows.Forms.Label lbFahrenheit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCot;
    }
}

