using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio7
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCargo.Clear();
            txtGratif.Clear();
            txtNome.Clear();
            txtNumInsc.Clear();
            txtProd.Clear();
            txtSal.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salBruto = 0;
            double salLiq = Convert.ToDouble(txtSal.Text);
            double B, C, D;
            double producao = Convert.ToDouble(txtProd.Text);
            double gratif = Convert.ToDouble(txtGratif.Text);

            if (producao >= 100)
            {
                if (producao >= 120)
                {
                    if (producao >= 150)
                    {
                        B = 1;
                        C = 1;
                        D = 1;
                    }
                    else
                    {
                        B = 1;
                        C = 1;
                        D = 0;
                    }
                }
                else
                {
                    B = 1;
                    C = 0;
                    D = 0;
                }
            }
            else
            {
                B = 0;
                C = 0;
                D = 0;
            }

            salBruto = salLiq + (salLiq * (0.05 * B + 0.1 * C + 0.1 * D)) + gratif;

            if (salBruto >= 7000)
            {
                if (producao < 150 || gratif <= 0)
                {
                    MessageBox.Show("Funcionário: " + txtNome.Text.ToString() + "\n" + 
                        "Salário acima do teto: R$" + salBruto);
                }
                else
                {
                    MessageBox.Show("Funcionário: " + txtNome.Text.ToString() + "\n" +
                        "Cargo: " + txtCargo.Text.ToString() + "\n" +
                        "Inscrição: " + txtNumInsc.Text.ToString() + "\n" + "Salario Bruto: R$" + salBruto);
                }
            }
            else
            {
                MessageBox.Show("Funcionário: " + txtNome.Text.ToString() + "\n" +
                      "Cargo: " + txtCargo.Text.ToString() + "\n" +
                      "Inscrição: " + txtNumInsc.Text.ToString() + "\n" + "Salario Bruto: R$" + salBruto);
            }
        }
    }
}
