namespace exercicio7
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
            this.btnEx1 = new System.Windows.Forms.Button();
            this.btnEx2 = new System.Windows.Forms.Button();
            this.btnEx3 = new System.Windows.Forms.Button();
            this.btnEx4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEx1
            // 
            this.btnEx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx1.Location = new System.Drawing.Point(37, 142);
            this.btnEx1.Name = "btnEx1";
            this.btnEx1.Size = new System.Drawing.Size(131, 93);
            this.btnEx1.TabIndex = 0;
            this.btnEx1.Text = "Exercício 1";
            this.btnEx1.UseVisualStyleBackColor = true;
            this.btnEx1.Click += new System.EventHandler(this.btnEx1_Click);
            // 
            // btnEx2
            // 
            this.btnEx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx2.Location = new System.Drawing.Point(210, 142);
            this.btnEx2.Name = "btnEx2";
            this.btnEx2.Size = new System.Drawing.Size(131, 93);
            this.btnEx2.TabIndex = 1;
            this.btnEx2.Text = "Exercício 2";
            this.btnEx2.UseVisualStyleBackColor = true;
            this.btnEx2.Click += new System.EventHandler(this.btnEx2_Click);
            // 
            // btnEx3
            // 
            this.btnEx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx3.Location = new System.Drawing.Point(390, 142);
            this.btnEx3.Name = "btnEx3";
            this.btnEx3.Size = new System.Drawing.Size(131, 93);
            this.btnEx3.TabIndex = 2;
            this.btnEx3.Text = "Exercício 3";
            this.btnEx3.UseVisualStyleBackColor = true;
            this.btnEx3.Click += new System.EventHandler(this.btnEx3_Click);
            // 
            // btnEx4
            // 
            this.btnEx4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx4.Location = new System.Drawing.Point(569, 142);
            this.btnEx4.Name = "btnEx4";
            this.btnEx4.Size = new System.Drawing.Size(131, 93);
            this.btnEx4.TabIndex = 3;
            this.btnEx4.Text = "Exercício 4";
            this.btnEx4.UseVisualStyleBackColor = true;
            this.btnEx4.Click += new System.EventHandler(this.btnEx4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 385);
            this.Controls.Add(this.btnEx4);
            this.Controls.Add(this.btnEx3);
            this.Controls.Add(this.btnEx2);
            this.Controls.Add(this.btnEx1);
            this.Name = "Form1";
            this.Text = "Exercícios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEx1;
        private System.Windows.Forms.Button btnEx2;
        private System.Windows.Forms.Button btnEx3;
        private System.Windows.Forms.Button btnEx4;
    }
}

