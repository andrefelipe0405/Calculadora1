namespace Calculadora
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
            this.LblNumero1 = new System.Windows.Forms.Label();
            this.LblNumero2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LblOperacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblNumero1
            // 
            this.LblNumero1.AutoSize = true;
            this.LblNumero1.Location = new System.Drawing.Point(24, 9);
            this.LblNumero1.Name = "LblNumero1";
            this.LblNumero1.Size = new System.Drawing.Size(53, 13);
            this.LblNumero1.TabIndex = 0;
            this.LblNumero1.Text = "Numero 1";
            // 
            // LblNumero2
            // 
            this.LblNumero2.AutoSize = true;
            this.LblNumero2.Location = new System.Drawing.Point(24, 47);
            this.LblNumero2.Name = "LblNumero2";
            this.LblNumero2.Size = new System.Drawing.Size(53, 13);
            this.LblNumero2.TabIndex = 1;
            this.LblNumero2.Text = "Numero 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(111, 110);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 4;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // LblOperacao
            // 
            this.LblOperacao.AutoSize = true;
            this.LblOperacao.Location = new System.Drawing.Point(24, 86);
            this.LblOperacao.Name = "LblOperacao";
            this.LblOperacao.Size = new System.Drawing.Size(54, 13);
            this.LblOperacao.TabIndex = 6;
            this.LblOperacao.Text = "Operação";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 154);
            this.Controls.Add(this.LblOperacao);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblNumero2);
            this.Controls.Add(this.LblNumero1);
            this.MaximumSize = new System.Drawing.Size(251, 193);
            this.MinimumSize = new System.Drawing.Size(251, 193);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNumero1;
        private System.Windows.Forms.Label LblNumero2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LblOperacao;
    }
}

