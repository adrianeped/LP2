using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PF_0030482013002
{
    public partial class frmCidade : Form
    {
        private BindingSource bnCidade = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsCidade = new DataSet();

        public frmCidade()
        {
            InitializeComponent();
        }

        private void frmCidade_Load(object sender, EventArgs e)
        {
            try
            {
                Cidade Cid = new Cidade();
                dsCidade.Tables.Add(Cid.Listar());

                bnCidade.DataSource = dsCidade.Tables["TBCidade"];

                dgCidade.DataSource = bnCidade;

                bnvCidade.BindingSource = bnCidade;

                txtID.DataBindings.Add("TEXT", bnCidade, "id_cidade");

                txtNomeCidade.DataBindings.Add("TEXT", bnCidade, "nome_cidade");

                cboxUF.DataBindings.Add("SelectedItem", bnCidade, "uf_cidade");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            if (tbCidade.SelectedIndex == 0)
            {
                tbCidade.SelectTab(1);
            }

            bnCidade.AddNew();

            txtNomeCidade.Enabled = true;
            cboxUF.SelectedIndex = 0;
            txtNomeCidade.Focus();

            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeCidade.Text == "")
            {
                MessageBox.Show("Cidade Inválida");
            }
            else
            {
                Cidade RegCid = new Cidade();
                RegCid.IdCidade = Convert.ToInt16(txtID.Text);
                RegCid.NomeCidade = txtNomeCidade.Text;
                RegCid.UfCidade = cboxUF.SelectedItem.ToString();
                if (bInclusao)
                {
                    if (RegCid.Salvar() > 0)
                    {
                        MessageBox.Show("Cidade Adicionada com sucesso!");

                        btnSalvar.Enabled = false;
                        txtID.Enabled = false;
                        txtNomeCidade.Enabled = false;
                        cboxUF.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        bInclusao = false;

                        dsCidade.Tables.Clear();
                        dsCidade.Tables.Add(RegCid.Listar());
                        bnCidade.DataSource = dsCidade.Tables["TBCidade"];

                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar cidade!");
                    }
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbCidade.SelectedIndex == 0)
            {
                tbCidade.SelectTab(1);
            }
            txtNomeCidade.Enabled = true;
            cboxUF.Enabled = true;
            txtNomeCidade.Focus();
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbCidade.SelectedIndex == 0)
            {
                tbCidade.SelectTab(1);
            }
            if (MessageBox.Show("Confirma exclusão?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Cidade RegCid = new Cidade();
                RegCid.IdCidade = Convert.ToInt16(txtID.Text);
                RegCid.NomeCidade = txtNomeCidade.Text;
                RegCid.UfCidade = cboxUF.SelectedItem.ToString();

                if(RegCid.Excluir() > 0)
                {
                    MessageBox.Show("Cidade excluída com sucesso!");

                    Cidade R = new Cidade();
                    dsCidade.Tables.Clear();
                    dsCidade.Tables.Add(R.Listar());
                    bnCidade.DataSource = dsCidade.Tables["TBCidade"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir cidade!");
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnCidade.CancelEdit();
            btnSalvar.Enabled = false;
            txtNomeCidade.Enabled = false;
            cboxUF.Enabled = false;
            btnAlterar.Enabled = true;
            btnNovoRegistro.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;
        }
    }
}
