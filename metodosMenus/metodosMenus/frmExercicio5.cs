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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            int numero1 = 0;
            int numero2 = 0;

            if ((int.TryParse(txtInicio.Text, out numero1)) && (int.TryParse(txtFim.Text, out numero2)))
            {
                if (numero1 >= numero2)
                    MessageBox.Show("O primeiro número deve ser menor que o segundo");
                else
                {
                    Random random = new Random();
                    double r = random.Next(numero1, numero2);

                    MessageBox.Show("O número sorteado é: " + r.ToString());
                }
            }
            else
                MessageBox.Show("Digite somente números!");
        }
    }
}
