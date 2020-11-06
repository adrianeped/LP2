namespace CalculaSalario
{
    partial class frmCalculaSalario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculaSalario));
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.mtxtSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.btnVerificaDesc = new System.Windows.Forms.Button();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.chbEstadoCivil = new System.Windows.Forms.CheckBox();
            this.grbSexo = new System.Windows.Forms.GroupBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.pnlEstadoCivil = new System.Windows.Forms.Panel();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.lblNumFilhos = new System.Windows.Forms.Label();
            this.lblDados = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDadosFunc = new System.Windows.Forms.Label();
            this.txtDescIRPF = new System.Windows.Forms.TextBox();
            this.txtDescINSS = new System.Windows.Forms.TextBox();
            this.txtSalLiquido = new System.Windows.Forms.TextBox();
            this.txtSalFamilia = new System.Windows.Forms.TextBox();
            this.txtAliquotaIRPF = new System.Windows.Forms.TextBox();
            this.txtAliquotaINSS = new System.Windows.Forms.TextBox();
            this.lblDescIRPF = new System.Windows.Forms.Label();
            this.lblDescINSS = new System.Windows.Forms.Label();
            this.lblSalLiquido = new System.Windows.Forms.Label();
            this.lblSalFamilia = new System.Windows.Forms.Label();
            this.lblAliquotaIRPF = new System.Windows.Forms.Label();
            this.lblAliquotaINSS = new System.Windows.Forms.Label();
            this.mtxtNumFilhos = new System.Windows.Forms.MaskedTextBox();
            this.grbSexo.SuspendLayout();
            this.pnlEstadoCivil.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFunc.Location = new System.Drawing.Point(77, 37);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(150, 20);
            this.lblNomeFunc.TabIndex = 0;
            this.lblNomeFunc.Text = "Nome Funcionário:";
            // 
            // mtxtSalBruto
            // 
            this.mtxtSalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtSalBruto.Location = new System.Drawing.Point(197, 80);
            this.mtxtSalBruto.Mask = "00000,00";
            this.mtxtSalBruto.Name = "mtxtSalBruto";
            this.mtxtSalBruto.Size = new System.Drawing.Size(92, 27);
            this.mtxtSalBruto.TabIndex = 1;
            this.mtxtSalBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtSalBruto.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtSalBruto_MaskInputRejected);
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFunc.Location = new System.Drawing.Point(248, 30);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(435, 27);
            this.txtNomeFunc.TabIndex = 2;
            this.txtNomeFunc.TextChanged += new System.EventHandler(this.txtNomeFunc_TextChanged);
            // 
            // btnVerificaDesc
            // 
            this.btnVerificaDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificaDesc.Location = new System.Drawing.Point(102, 192);
            this.btnVerificaDesc.Name = "btnVerificaDesc";
            this.btnVerificaDesc.Size = new System.Drawing.Size(170, 39);
            this.btnVerificaDesc.TabIndex = 3;
            this.btnVerificaDesc.Text = "Verifica Desconto";
            this.btnVerificaDesc.UseVisualStyleBackColor = true;
            this.btnVerificaDesc.Click += new System.EventHandler(this.btnVerificaDesc_Click);
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(49, 33);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(98, 24);
            this.rbtnFeminino.TabIndex = 4;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // chbEstadoCivil
            // 
            this.chbEstadoCivil.AutoSize = true;
            this.chbEstadoCivil.Location = new System.Drawing.Point(61, 46);
            this.chbEstadoCivil.Name = "chbEstadoCivil";
            this.chbEstadoCivil.Size = new System.Drawing.Size(88, 24);
            this.chbEstadoCivil.TabIndex = 5;
            this.chbEstadoCivil.Text = "Casado";
            this.chbEstadoCivil.UseVisualStyleBackColor = true;
            // 
            // grbSexo
            // 
            this.grbSexo.Controls.Add(this.rbtnMasculino);
            this.grbSexo.Controls.Add(this.rbtnFeminino);
            this.grbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSexo.Location = new System.Drawing.Point(62, 258);
            this.grbSexo.Name = "grbSexo";
            this.grbSexo.Size = new System.Drawing.Size(234, 128);
            this.grbSexo.TabIndex = 6;
            this.grbSexo.TabStop = false;
            this.grbSexo.Text = "Sexo";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(49, 80);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(106, 24);
            this.rbtnMasculino.TabIndex = 5;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // pnlEstadoCivil
            // 
            this.pnlEstadoCivil.Controls.Add(this.chbEstadoCivil);
            this.pnlEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlEstadoCivil.Location = new System.Drawing.Point(62, 412);
            this.pnlEstadoCivil.Name = "pnlEstadoCivil";
            this.pnlEstadoCivil.Size = new System.Drawing.Size(234, 106);
            this.pnlEstadoCivil.TabIndex = 7;
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalBruto.Location = new System.Drawing.Point(32, 87);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(138, 20);
            this.lblSalBruto.TabIndex = 8;
            this.lblSalBruto.Text = "Salário Bruto: R$";
            // 
            // lblNumFilhos
            // 
            this.lblNumFilhos.AutoSize = true;
            this.lblNumFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFilhos.Location = new System.Drawing.Point(32, 133);
            this.lblNumFilhos.Name = "lblNumFilhos";
            this.lblNumFilhos.Size = new System.Drawing.Size(141, 20);
            this.lblNumFilhos.TabIndex = 9;
            this.lblNumFilhos.Text = "Número de filhos:";
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(154, 22);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(0, 20);
            this.lblDados.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDadosFunc);
            this.panel2.Controls.Add(this.txtDescIRPF);
            this.panel2.Controls.Add(this.txtDescINSS);
            this.panel2.Controls.Add(this.txtSalLiquido);
            this.panel2.Controls.Add(this.txtSalFamilia);
            this.panel2.Controls.Add(this.txtAliquotaIRPF);
            this.panel2.Controls.Add(this.txtAliquotaINSS);
            this.panel2.Controls.Add(this.lblDescIRPF);
            this.panel2.Controls.Add(this.lblDescINSS);
            this.panel2.Controls.Add(this.lblSalLiquido);
            this.panel2.Controls.Add(this.lblSalFamilia);
            this.panel2.Controls.Add(this.lblAliquotaIRPF);
            this.panel2.Controls.Add(this.lblAliquotaINSS);
            this.panel2.Controls.Add(this.lblDados);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(361, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 463);
            this.panel2.TabIndex = 12;
            // 
            // lblDadosFunc
            // 
            this.lblDadosFunc.AutoSize = true;
            this.lblDadosFunc.Location = new System.Drawing.Point(47, 10);
            this.lblDadosFunc.Name = "lblDadosFunc";
            this.lblDadosFunc.Size = new System.Drawing.Size(58, 20);
            this.lblDadosFunc.TabIndex = 23;
            this.lblDadosFunc.Text = "Dados";
            // 
            // txtDescIRPF
            // 
            this.txtDescIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescIRPF.Location = new System.Drawing.Point(167, 418);
            this.txtDescIRPF.Name = "txtDescIRPF";
            this.txtDescIRPF.ReadOnly = true;
            this.txtDescIRPF.Size = new System.Drawing.Size(188, 27);
            this.txtDescIRPF.TabIndex = 22;
            this.txtDescIRPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescINSS
            // 
            this.txtDescINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescINSS.Location = new System.Drawing.Point(167, 362);
            this.txtDescINSS.Name = "txtDescINSS";
            this.txtDescINSS.ReadOnly = true;
            this.txtDescINSS.Size = new System.Drawing.Size(188, 27);
            this.txtDescINSS.TabIndex = 21;
            this.txtDescINSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSalLiquido
            // 
            this.txtSalLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalLiquido.Location = new System.Drawing.Point(167, 304);
            this.txtSalLiquido.Name = "txtSalLiquido";
            this.txtSalLiquido.ReadOnly = true;
            this.txtSalLiquido.Size = new System.Drawing.Size(188, 27);
            this.txtSalLiquido.TabIndex = 20;
            this.txtSalLiquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSalFamilia
            // 
            this.txtSalFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalFamilia.Location = new System.Drawing.Point(167, 238);
            this.txtSalFamilia.Name = "txtSalFamilia";
            this.txtSalFamilia.ReadOnly = true;
            this.txtSalFamilia.Size = new System.Drawing.Size(188, 27);
            this.txtSalFamilia.TabIndex = 19;
            this.txtSalFamilia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAliquotaIRPF
            // 
            this.txtAliquotaIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAliquotaIRPF.Location = new System.Drawing.Point(167, 173);
            this.txtAliquotaIRPF.Name = "txtAliquotaIRPF";
            this.txtAliquotaIRPF.ReadOnly = true;
            this.txtAliquotaIRPF.Size = new System.Drawing.Size(188, 27);
            this.txtAliquotaIRPF.TabIndex = 18;
            this.txtAliquotaIRPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAliquotaINSS
            // 
            this.txtAliquotaINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAliquotaINSS.Location = new System.Drawing.Point(167, 109);
            this.txtAliquotaINSS.Name = "txtAliquotaINSS";
            this.txtAliquotaINSS.ReadOnly = true;
            this.txtAliquotaINSS.Size = new System.Drawing.Size(188, 27);
            this.txtAliquotaINSS.TabIndex = 17;
            this.txtAliquotaINSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDescIRPF
            // 
            this.lblDescIRPF.AutoSize = true;
            this.lblDescIRPF.Location = new System.Drawing.Point(24, 421);
            this.lblDescIRPF.Name = "lblDescIRPF";
            this.lblDescIRPF.Size = new System.Drawing.Size(123, 20);
            this.lblDescIRPF.TabIndex = 16;
            this.lblDescIRPF.Text = "Desconto IRPF";
            // 
            // lblDescINSS
            // 
            this.lblDescINSS.AutoSize = true;
            this.lblDescINSS.Location = new System.Drawing.Point(23, 365);
            this.lblDescINSS.Name = "lblDescINSS";
            this.lblDescINSS.Size = new System.Drawing.Size(124, 20);
            this.lblDescINSS.TabIndex = 15;
            this.lblDescINSS.Text = "Desconto INSS";
            // 
            // lblSalLiquido
            // 
            this.lblSalLiquido.AutoSize = true;
            this.lblSalLiquido.Location = new System.Drawing.Point(23, 307);
            this.lblSalLiquido.Name = "lblSalLiquido";
            this.lblSalLiquido.Size = new System.Drawing.Size(120, 20);
            this.lblSalLiquido.TabIndex = 14;
            this.lblSalLiquido.Text = "Salário Líquido";
            // 
            // lblSalFamilia
            // 
            this.lblSalFamilia.AutoSize = true;
            this.lblSalFamilia.Location = new System.Drawing.Point(23, 238);
            this.lblSalFamilia.Name = "lblSalFamilia";
            this.lblSalFamilia.Size = new System.Drawing.Size(120, 20);
            this.lblSalFamilia.TabIndex = 13;
            this.lblSalFamilia.Text = "Salário Família";
            // 
            // lblAliquotaIRPF
            // 
            this.lblAliquotaIRPF.AutoSize = true;
            this.lblAliquotaIRPF.Location = new System.Drawing.Point(23, 176);
            this.lblAliquotaIRPF.Name = "lblAliquotaIRPF";
            this.lblAliquotaIRPF.Size = new System.Drawing.Size(111, 20);
            this.lblAliquotaIRPF.TabIndex = 12;
            this.lblAliquotaIRPF.Text = "Alíquota IRPF";
            // 
            // lblAliquotaINSS
            // 
            this.lblAliquotaINSS.AutoSize = true;
            this.lblAliquotaINSS.Location = new System.Drawing.Point(22, 112);
            this.lblAliquotaINSS.Name = "lblAliquotaINSS";
            this.lblAliquotaINSS.Size = new System.Drawing.Size(112, 20);
            this.lblAliquotaINSS.TabIndex = 11;
            this.lblAliquotaINSS.Text = "Alíquota INSS";
            // 
            // mtxtNumFilhos
            // 
            this.mtxtNumFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtNumFilhos.Location = new System.Drawing.Point(197, 126);
            this.mtxtNumFilhos.Mask = "00";
            this.mtxtNumFilhos.Name = "mtxtNumFilhos";
            this.mtxtNumFilhos.Size = new System.Drawing.Size(45, 27);
            this.mtxtNumFilhos.TabIndex = 13;
            this.mtxtNumFilhos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtNumFilhos.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtNumFilhos_MaskInputRejected);
            // 
            // frmCalculaSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 555);
            this.Controls.Add(this.mtxtNumFilhos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblNumFilhos);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.pnlEstadoCivil);
            this.Controls.Add(this.grbSexo);
            this.Controls.Add(this.btnVerificaDesc);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.mtxtSalBruto);
            this.Controls.Add(this.lblNomeFunc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalculaSalario";
            this.Text = "Calcula Salario";
            this.grbSexo.ResumeLayout(false);
            this.grbSexo.PerformLayout();
            this.pnlEstadoCivil.ResumeLayout(false);
            this.pnlEstadoCivil.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.MaskedTextBox mtxtSalBruto;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.Button btnVerificaDesc;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.CheckBox chbEstadoCivil;
        private System.Windows.Forms.GroupBox grbSexo;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.Panel pnlEstadoCivil;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.Label lblNumFilhos;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDadosFunc;
        private System.Windows.Forms.TextBox txtDescIRPF;
        private System.Windows.Forms.TextBox txtDescINSS;
        private System.Windows.Forms.TextBox txtSalLiquido;
        private System.Windows.Forms.TextBox txtSalFamilia;
        private System.Windows.Forms.TextBox txtAliquotaIRPF;
        private System.Windows.Forms.TextBox txtAliquotaINSS;
        private System.Windows.Forms.Label lblDescIRPF;
        private System.Windows.Forms.Label lblDescINSS;
        private System.Windows.Forms.Label lblSalLiquido;
        private System.Windows.Forms.Label lblSalFamilia;
        private System.Windows.Forms.Label lblAliquotaIRPF;
        private System.Windows.Forms.Label lblAliquotaINSS;
        private System.Windows.Forms.MaskedTextBox mtxtNumFilhos;
    }
}

