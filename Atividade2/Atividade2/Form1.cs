using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2
{
    public partial class frmCalculadora : Form
    {
        double num1, num2, resultado;
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out num1) && (double.TryParse(txtNum2.Text, out num2)))
            {
                resultado = num1 - num2;

                txtResul.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números inválidos!!");
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out num1) && (double.TryParse(txtNum2.Text, out num2)))
            {
                resultado = num1 * num2;

                txtResul.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números inválidos!!");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out num1) && (double.TryParse(txtNum2.Text, out num2)))
            {
                if (num2 == 0)
                    MessageBox.Show("Divisor não pode ser 0");
                else
                {
                    resultado = num1 / num2;
                    txtResul.Text = resultado.ToString();
                }
            }
            else
                MessageBox.Show("Números inválidos!!");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResul.Clear();

            txtNum1.Focus();
        }

        private void btnAdi_Click(object sender, EventArgs e)
        {

            if (double.TryParse(txtNum1.Text, out num1) && (double.TryParse(txtNum2.Text, out num2)))
            {
                resultado = num1 + num2;

                txtResul.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números inválidos!!");
        }
    }
}
