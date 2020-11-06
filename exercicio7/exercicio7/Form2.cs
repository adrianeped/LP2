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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnContaPares_Click(object sender, EventArgs e)
        {
            int contaRepet = 0;
            char letraAnt = '\0';

            foreach(char c in rtxtTexto.Text)
            {
                if (Char.ToUpper(c) == letraAnt)
                {
                    contaRepet++;
                }

                letraAnt = Char.ToUpper(c);
            }
            MessageBox.Show("Número de pares de letras repetidas: " + contaRepet.ToString());
        }

        private void btnContaR_Click(object sender, EventArgs e)
        {
            int contaR = 0;
            for (int i = 0; i < rtxtTexto.Text.Length; i++)
            {
                if (rtxtTexto.Text[i] == 'r' || rtxtTexto.Text[i] == 'R')
                    contaR++;
            }
            MessageBox.Show("O número de letras R: " + contaR.ToString());
        }

        private void btnContaEspaco_Click(object sender, EventArgs e)
        {
            int contaEspaco = 0;

            foreach (char c in rtxtTexto.Text.ToUpper())
            {
                if (Char.ToUpper(c) == ' ')
                    contaEspaco++;
            }
            MessageBox.Show("O número de espaços em branco: " + contaEspaco.ToString());
        }
    }
}
