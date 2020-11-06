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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            double H = 0;
            int calcula = 0;

            Int32.TryParse(txtNum.Text, out calcula);
            
            if (calcula == 0)
                MessageBox.Show("O número tem que ser maior que 0!");
            else
            {
                for (double i = 1; i <= calcula; i++)
                {
                    H += 1 / i;
                }
                H = Math.Round(H, 4);
                MessageBox.Show("O resultado de H é: " + H);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
        }
    }
}

