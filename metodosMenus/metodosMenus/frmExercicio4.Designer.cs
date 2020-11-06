namespace metodosMenus
{
    partial class frmExercicio4
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
            this.btnNumericos = new System.Windows.Forms.Button();
            this.btnPosicao = new System.Windows.Forms.Button();
            this.btnAlfabeticos = new System.Windows.Forms.Button();
            this.rtxtCaracteres = new System.Windows.Forms.RichTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNumericos
            // 
            this.btnNumericos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumericos.Location = new System.Drawing.Point(47, 303);
            this.btnNumericos.Name = "btnNumericos";
            this.btnNumericos.Size = new System.Drawing.Size(140, 71);
            this.btnNumericos.TabIndex = 0;
            this.btnNumericos.Text = "Númericos";
            this.btnNumericos.UseVisualStyleBackColor = true;
            this.btnNumericos.Click += new System.EventHandler(this.btnNumericos_Click);
            // 
            // btnPosicao
            // 
            this.btnPosicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosicao.Location = new System.Drawing.Point(218, 303);
            this.btnPosicao.Name = "btnPosicao";
            this.btnPosicao.Size = new System.Drawing.Size(196, 71);
            this.btnPosicao.TabIndex = 1;
            this.btnPosicao.Text = "Posição Primeiro Espaço em Branco";
            this.btnPosicao.UseVisualStyleBackColor = true;
            this.btnPosicao.Click += new System.EventHandler(this.btnPosicao_Click);
            // 
            // btnAlfabeticos
            // 
            this.btnAlfabeticos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlfabeticos.Location = new System.Drawing.Point(451, 303);
            this.btnAlfabeticos.Name = "btnAlfabeticos";
            this.btnAlfabeticos.Size = new System.Drawing.Size(149, 71);
            this.btnAlfabeticos.TabIndex = 2;
            this.btnAlfabeticos.Text = "Alfabéticos";
            this.btnAlfabeticos.UseVisualStyleBackColor = true;
            this.btnAlfabeticos.Click += new System.EventHandler(this.btnAlfabeticos_Click);
            // 
            // rtxtCaracteres
            // 
            this.rtxtCaracteres.Location = new System.Drawing.Point(47, 48);
            this.rtxtCaracteres.MaxLength = 100;
            this.rtxtCaracteres.Name = "rtxtCaracteres";
            this.rtxtCaracteres.Size = new System.Drawing.Size(553, 203);
            this.rtxtCaracteres.TabIndex = 3;
            this.rtxtCaracteres.Text = "";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(242, 391);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(149, 71);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 491);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.rtxtCaracteres);
            this.Controls.Add(this.btnAlfabeticos);
            this.Controls.Add(this.btnPosicao);
            this.Controls.Add(this.btnNumericos);
            this.Name = "frmExercicio4";
            this.Text = "Exercício 4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNumericos;
        private System.Windows.Forms.Button btnPosicao;
        private System.Windows.Forms.Button btnAlfabeticos;
        private System.Windows.Forms.RichTextBox rtxtCaracteres;
        private System.Windows.Forms.Button btnLimpar;
    }
}