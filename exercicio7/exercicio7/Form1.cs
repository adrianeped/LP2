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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Form2"];

            if (fc != null)
                fc.Close();

            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Form3"];

            if (fc != null)
                fc.Close();

            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void btnEx3_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Form4"];

            if (fc != null)
                fc.Close();

            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void btnEx4_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Form5"];

            if (fc != null)
                fc.Close();

            Form5 frm5 = new Form5();
            frm5.Show();
        }
    }
}
