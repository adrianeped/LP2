namespace exercicio7
{
    partial class Form2
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
            this.rtxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnContaEspaco = new System.Windows.Forms.Button();
            this.btnContaR = new System.Windows.Forms.Button();
            this.btnContaPares = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtTexto
            // 
            this.rtxtTexto.Location = new System.Drawing.Point(55, 54);
            this.rtxtTexto.MaxLength = 100;
            this.rtxtTexto.Name = "rtxtTexto";
            this.rtxtTexto.Size = new System.Drawing.Size(639, 188);
            this.rtxtTexto.TabIndex = 0;
            this.rtxtTexto.Text = "";
            // 
            // btnContaEspaco
            // 
            this.btnContaEspaco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContaEspaco.Location = new System.Drawing.Point(55, 299);
            this.btnContaEspaco.Name = "btnContaEspaco";
            this.btnContaEspaco.Size = new System.Drawing.Size(180, 94);
            this.btnContaEspaco.TabIndex = 1;
            this.btnContaEspaco.Text = "Conta espaços em branco";
            this.btnContaEspaco.UseVisualStyleBackColor = true;
            this.btnContaEspaco.Click += new System.EventHandler(this.btnContaEspaco_Click);
            // 
            // btnContaR
            // 
            this.btnContaR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContaR.Location = new System.Drawing.Point(285, 299);
            this.btnContaR.Name = "btnContaR";
            this.btnContaR.Size = new System.Drawing.Size(180, 94);
            this.btnContaR.TabIndex = 2;
            this.btnContaR.Text = "Conta letra R";
            this.btnContaR.UseVisualStyleBackColor = true;
            this.btnContaR.Click += new System.EventHandler(this.btnContaR_Click);
            // 
            // btnContaPares
            // 
            this.btnContaPares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContaPares.Location = new System.Drawing.Point(514, 299);
            this.btnContaPares.Name = "btnContaPares";
            this.btnContaPares.Size = new System.Drawing.Size(180, 94);
            this.btnContaPares.TabIndex = 3;
            this.btnContaPares.Text = "Conta pares de letras";
            this.btnContaPares.UseVisualStyleBackColor = true;
            this.btnContaPares.Click += new System.EventHandler(this.btnContaPares_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContaPares);
            this.Controls.Add(this.btnContaR);
            this.Controls.Add(this.btnContaEspaco);
            this.Controls.Add(this.rtxtTexto);
            this.Name = "Form2";
            this.Text = "Exercício 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtTexto;
        private System.Windows.Forms.Button btnContaEspaco;
        private System.Windows.Forms.Button btnContaR;
        private System.Windows.Forms.Button btnContaPares;
    }
}