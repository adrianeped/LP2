namespace ATIVIDADE4
{
    partial class frmTriangulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTriangulo));
            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.gbrTri = new System.Windows.Forms.GroupBox();
            this.txtTri = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gbrTri.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(85, 48);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(111, 29);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "LADO A:";
            // 
            // txtA
            // 
            this.txtA.AcceptsTab = true;
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(247, 48);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(192, 34);
            this.txtA.TabIndex = 1;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(167, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "VERIFICAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(85, 120);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(112, 29);
            this.lblB.TabIndex = 3;
            this.lblB.Text = "LADO B:";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(85, 196);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(113, 29);
            this.lblC.TabIndex = 4;
            this.lblC.Text = "LADO C:";
            // 
            // txtC
            // 
            this.txtC.AcceptsTab = true;
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(247, 196);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(192, 34);
            this.txtC.TabIndex = 5;
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtB
            // 
            this.txtB.AcceptsTab = true;
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(247, 120);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(192, 34);
            this.txtB.TabIndex = 6;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbrTri
            // 
            this.gbrTri.Controls.Add(this.txtTri);
            this.gbrTri.Location = new System.Drawing.Point(35, 359);
            this.gbrTri.Name = "gbrTri";
            this.gbrTri.Size = new System.Drawing.Size(466, 100);
            this.gbrTri.TabIndex = 7;
            this.gbrTri.TabStop = false;
            this.gbrTri.Text = "Seu triângulo é:";
            // 
            // txtTri
            // 
            this.txtTri.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTri.Location = new System.Drawing.Point(35, 36);
            this.txtTri.Name = "txtTri";
            this.txtTri.ReadOnly = true;
            this.txtTri.Size = new System.Drawing.Size(390, 38);
            this.txtTri.TabIndex = 0;
            this.txtTri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(147, 484);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(111, 40);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(293, 484);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(111, 40);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(544, 573);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.gbrTri);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTriangulo";
            this.Text = "Triângulos";
            this.gbrTri.ResumeLayout(false);
            this.gbrTri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.GroupBox gbrTri;
        private System.Windows.Forms.TextBox txtTri;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

