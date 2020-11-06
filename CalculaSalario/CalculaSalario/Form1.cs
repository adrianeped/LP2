using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculaSalario
{
    public partial class frmCalculaSalario : Form
    {
        public frmCalculaSalario()
        {
            InitializeComponent();
        }

        private void mtxtSalBruto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Enabled = true;
        }

        private void mtxtNumFilhos_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Enabled = true;
        }

        private void txtNomeFunc_TextChanged(object sender, EventArgs e)
        {
            Focus();
        }

        private void btnVerificaDesc_Click(object sender, EventArgs e)
        {

            double descontoINSS = 0;
            double descontoIRPF = 0;
            double salarioLiquido = 0;
            double salarioBruto = 0;
            double salarioFamilia = 0;
            double numeroFilhos = 0;

            if (txtNomeFunc.Text == String.Empty)
            {
                MessageBox.Show("O nome do funcionário" + "\n" +
                    "não pode ser vazio!");
            }
            else
            {
                if (!double.TryParse(mtxtSalBruto.Text, out salarioBruto) || !double.TryParse(mtxtNumFilhos.Text, out numeroFilhos))
                {
                    MessageBox.Show("Salário bruto e número de filhos devem ser numéricos.");
                }
                else
                {
                    if (salarioBruto <= 0)
                        MessageBox.Show("Salário bruto deve ser maior que 0");
                    else
                    {
                        if (salarioBruto <= 800.47)
                        {
                            txtAliquotaINSS.Text = "7,65%";
                            descontoINSS = 0.0765 * salarioBruto;
                        }
                        else if (salarioBruto < 1050)
                        {
                            txtAliquotaINSS.Text = "8,65%";
                            descontoINSS = ((8.65 / 100) * salarioBruto);
                        }
                        else if (salarioBruto <= 1400.77)
                        {
                            txtAliquotaINSS.Text = "9,00%";
                            descontoINSS = ((9 / 100) * salarioBruto);
                        }
                        else if (salarioBruto <= 2081.56)
                        {
                            txtAliquotaINSS.Text = "11,00%";
                            descontoINSS = 0.11 * salarioBruto;
                        }
                        else
                        {
                            txtAliquotaINSS.Text = "Teto";
                            descontoINSS = 308.17;
                        }

                        txtDescINSS.Text = descontoINSS.ToString("N2");

                        if (salarioBruto <= 1257.12)
                            txtAliquotaIRPF.Text = "0";
                        else if (salarioBruto <= 2512.08)
                        {
                            txtAliquotaIRPF.Text = "15%";
                            descontoIRPF = (salarioBruto * 15 / 100);
                        }
                        else
                        {
                            txtAliquotaIRPF.Text = "27,5%";
                            descontoIRPF = (salarioBruto * 27.5 / 100);
                        }

                        txtDescIRPF.Text = descontoIRPF.ToString("N2");

                        if (numeroFilhos > 0)
                        {
                            if (salarioBruto <= 435.52)
                                salarioFamilia = (22.33 * numeroFilhos);
                            else if (salarioBruto <= 654.61)
                                salarioFamilia = (15.74 * numeroFilhos);
                            else
                                salarioFamilia = 0;
                        }
                        txtSalFamilia.Text = salarioFamilia.ToString("N2");

                        salarioLiquido = salarioBruto - descontoINSS - descontoIRPF + salarioFamilia;

                        txtSalLiquido.Text = salarioLiquido.ToString("N2");

                        lblDadosFunc.Text = "Os descontos do salário " + "\n";

                        if (rbtnFeminino.Checked)
                            lblDadosFunc.Text = lblDadosFunc.Text + "da Sra. " + txtNomeFunc.Text +"\n";
                        else
                            lblDadosFunc.Text = lblDadosFunc.Text + " do Sr. " + txtNomeFunc.Text + "\n";

                        if (chbEstadoCivil.Checked)
                            lblDadosFunc.Text = lblDadosFunc.Text + " que é casado " + "\n";
                        else
                            lblDadosFunc.Text = lblDadosFunc.Text + " que é solteiro " + "\n";

                        lblDadosFunc.Text = lblDadosFunc.Text + numeroFilhos + " filhos são: ";
                    }
                }
            }

        }
    }
}
