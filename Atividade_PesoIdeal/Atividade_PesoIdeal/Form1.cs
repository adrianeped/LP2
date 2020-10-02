using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_PesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtPesoAtual.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPesoAtual.Clear();

            txtPesoAtual.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura, pesoIdeal;

            double.TryParse(txtAltura.Text, out altura);
            double.TryParse(txtPesoAtual.Text, out peso);

            if (rdbMulher.Checked == true)
            {
                pesoIdeal = (62.1 * altura) - 44.7;
            }
            else
            {
                pesoIdeal = (72.7 * altura) - 58;
            }

            if (pesoIdeal > peso)
            {
                MessageBox.Show("Seu peso ideal é: "+ pesoIdeal + "\n" + "Coma bastante massas e doces!!");
            }
            else if (pesoIdeal < peso)
            {
                MessageBox.Show("Seu peso ideal é: " + pesoIdeal + "\n" + "Regime obrigatório já!!");
            }
            else
            {
                MessageBox.Show("Seu peso ideal é: " + pesoIdeal + "\n" + "Você está com o peso ideal!!");
            }

        }
    }
}
