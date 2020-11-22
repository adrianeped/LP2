using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string auxiliar = "";

            for (var i=0; i<vetor.Length; i++)
            {
                auxiliar = Interaction.InputBox("Digite o número na posição: "+(i+1).ToString(),
                    "Entrada de dados");

                if(!(int.TryParse(auxiliar, out vetor[i])))
                {
                    MessageBox.Show("Número inválido!");
                    i--;
                }

            }

            auxiliar = "";

            for (var i = vetor.Length - 1; i >= 0; i--)
                auxiliar += vetor[i].ToString() + "\n";

            MessageBox.Show(auxiliar);
        }

        private void btnExercicio6_Click(object sender, EventArgs e)
        {
            double[,] matriz = new double[20, 3];
            string auxiliar = "";
            double media = 0;

            for (var i=0; i<20; i++)
            {
                media = 0;

                for (var j=0; j<3; j++)
                {
                    auxiliar = Interaction.InputBox("Entre com a nota " +
                        (j + 1).ToString() + "do aluno " + (i + 1).ToString(),
                        "Entrada de notas ");

                    if((double.TryParse(auxiliar, out matriz [i,j])) &&
                            (matriz [i,j]>=0) && ((matriz [i,j] <= 10)))
                            {
                                media += matriz[i, j];
                            }
                            else
                            {
                                MessageBox.Show("Nota inválida!");
                                j--;
                            }
                }
                
                MessageBox.Show("Aluno " + (i + 1).ToString() + "média:" + (media / 3).ToString("N2"));
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string auxiliar = "";

            for (var i = 0; i < vetor.Length; i++)
            {
                auxiliar = Interaction.InputBox("Digite o Número: " + (i + 1), "Entrada de dados");
                if (!(int.TryParse(auxiliar, out vetor[i])))
                {
                    MessageBox.Show("Número Inválido");
                    i--;

                }
            }
            auxiliar = "";
            for (var i = vetor.Length - 1; i >= 0; i--)
                auxiliar += vetor[i].ToString() + "\n";

            MessageBox.Show(auxiliar);
        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string auxiliar = "";

            for (var i = 0; i < vetor.Length; i++)
            {
                auxiliar = Interaction.InputBox("Digite o número: " + (i + 1), "Entrada de dados");
                if (!(int.TryParse(auxiliar, out vetor[i])))
                {
                    MessageBox.Show("Número Inválido");
                    i--;

                }
            }
            auxiliar = "";
            for (var i = vetor.Length - 1; i >= 0; i--)
                auxiliar += vetor[i].ToString() + "\n";

            MessageBox.Show(auxiliar);
        }

        private void btnExercicio4_Click(object sender, EventArgs e)
        {
            string[] Alunos = {"Viviane", "André", "Hélio", "Denise", "Junior",
                                "Leonardo", "Jose", "Nelma", "Tobby"};
            Int32 i, Total = 0;
            Int32 n = Alunos.Length;
            for (i = 0; i < n - 1; i++)
            {
                Total += Alunos[i].Length;
            }
            MessageBox.Show("Resultado " + Total.ToString());
        }

        private void btnExercicio5_Click(object sender, EventArgs e)
        {
            string text = "";
            string[] alunos = { "Ana", "André", "Débora", "Fátima", "João", "Janete", "Otávio", "Marcelo", "Pedro", "Thais" };
            for (int i = 0; i < alunos.Length - 1; i++)
            {
                if (alunos[i] != "Otávio")
                {
                    text += alunos[i] + "";
                }
            }
            MessageBox.Show(text);
        }
    }
}
