using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metodosMenus
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnNumericos_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int numeros = 0;

            for (contador = 0; contador < rtxtCaracteres.Text.Length; contador++)
            {
                if (Char.IsNumber(Convert.ToChar(rtxtCaracteres.Text.Substring(contador, 1))))
                {
                    numeros += 1;
                }
            }
            MessageBox.Show("A quantidade de números é: " + numeros.ToString());
        }

        private void btnPosicao_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int posicaoBranco = 0;

            while(contador < rtxtCaracteres.Text.Length)
            {
                if (Char.IsWhiteSpace(rtxtCaracteres.Text[contador]))
                {
                    posicaoBranco = contador;
                    break;
                }
                contador++;
            }
            MessageBox.Show("O primeiro caracter branco está na posição: " + posicaoBranco.ToString());
        }

        private void btnAlfabeticos_Click(object sender, EventArgs e)
        {
            int contador = 0;

            foreach (char chara in rtxtCaracteres.Text)
            {
                if (Char.IsLetter(chara))
                {
                    contador += 1;
                }
            }
            MessageBox.Show("O texto tem " + contador.ToString() + " caracteres alfabéticos");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rtxtCaracteres.Clear();
        }
    }
}
