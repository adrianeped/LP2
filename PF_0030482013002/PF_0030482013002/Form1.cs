using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PF_0030482013002
{
    public partial class frmCadCidades : Form
    {
        public static SqlConnection conexao;
        public frmCadCidades()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cADASTROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCidade frmC = new frmCidade();
            frmC.MdiParent = this;
            frmC.WindowState = FormWindowState.Maximized;
            frmC.Show();
        }

        private void frmCadCidades_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=LAPTOP-UJJ8LITT\\SQLEXPRESS;Initial Catalog=LP2;Integrated Security=True");
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados :/" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros erros :/" + ex.Message);
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frmS = new frmSobre();
            frmS.MdiParent = this;
            frmS.WindowState = FormWindowState.Maximized;
            frmS.Show();
        }
    }
}
