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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtTexto.Clear();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            Char[] texto = txtTexto.Text.Replace(" ","").ToCharArray();

            Array.Reverse(texto);
            int c = 0;
            string texto2 = "";

            for (c = 0; c <= texto.Length - 1; c++)
                texto2 += texto[c];

            if (texto2.ToUpper() == txtTexto.Text.Replace(" ","").ToUpper())
            {
                MessageBox.Show("O texto é palíndromo!");
            }
            else
                MessageBox.Show("O texto não é panlídromo!");
        
        }
    }
}
