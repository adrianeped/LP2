using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE4
{
    public partial class frmTriangulo : Form
    {
        public frmTriangulo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ladoA, ladoB, ladoC;

            if (double.TryParse(txtA.Text, out ladoA) && double.TryParse(txtB.Text, out ladoB) 
                && double.TryParse(txtC.Text, out ladoC))
            {

                double modBC = Math.Abs(ladoB - ladoC);
                double modAC = Math.Abs(ladoA - ladoC);
                double modAB = Math.Abs(ladoA - ladoB);
                double somaBC = ladoB + ladoC;
                double somaAC = ladoA + ladoC;
                double somaAB = ladoA + ladoB;
                Boolean verificaA = modBC < ladoA && ladoA < somaBC;
                Boolean verificaB = modAC < ladoB && ladoB < somaAC;
                Boolean verificaC = modAB < ladoC && ladoC < somaAB;

                if (verificaA && verificaB && verificaC) 
                {
                    if (ladoA == ladoB && ladoB == ladoC && ladoC == ladoA)
                    {
                        txtTri.Text = ("Triângulo Equilátero");
                    }
                    else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                    {
                        txtTri.Text = ("Triângulo Isósceles");
                    }
                    else
                    {
                        txtTri.Text = ("Triângulo Escaleno");
                    }
                } else
                    txtTri.Text = ("Não é um triângulo");
            } else
                txtTri.Text = ("Insira valores numéricos.");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtTri.Clear();

            txtA.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
