using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_final.DAO;
using Projeto_final.Entidades;


namespace Projeto_final.View
{
    public partial class frmPaciente : Form
    {
        public frmPaciente()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPaciente_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void cadastroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblinserircad_Click(object sender, EventArgs e)
        {
            using (var tb = new Contextocs())
            {
                try
                {
                    tb.ObjetoPaciente.Add(new Pacientes { NomePaciente = txtnome.Text, Endereco = txtendereco.Text, Telefone = txttelefone.Text, CPF = txtcpf.Text, Convenio = txtconvenio.Text, Plano = txtplano.Text, NumCartao = txtnumcartao.Text });
                    tb.SaveChanges();
                    AtualizaGrid();
                    limparcampos();
                    MessageBox.Show("Incluido com sucesso", "Inclusão");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void limparcampos()
        {
            txtconvenio.Text = "";
            txtcpf.Text = "";
            txtendereco.Text = "";
            txtnome.Text = "";
            txtnumcartao.Text = "";
            txtplano.Text = "";
            txttelefone.Text = "";
            txtidcad.Text = "";
            txtnome.Focus();

        }

        public void AtualizaGrid()
        {
            using (var tb =new Contextocs())
            {
                dgPaciente.DataSource = null;
                dgPaciente.DataSource = tb.ObjetoPaciente.ToList();
            }
        }
            


        private void lblidpaciente_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidcad.Text = dgPaciente.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = dgPaciente.CurrentRow.Cells[1].Value.ToString();
            txtendereco.Text = dgPaciente.CurrentRow.Cells[2].Value.ToString();
            txttelefone.Text = dgPaciente.CurrentRow.Cells[3].Value.ToString();
            txtcpf.Text = dgPaciente.CurrentRow.Cells[4].Value.ToString();          
            txtconvenio.Text = dgPaciente.CurrentRow.Cells[5].Value.ToString();
            txtplano.Text = dgPaciente.CurrentRow.Cells[6].Value.ToString();
            txtnumcartao.Text = dgPaciente.CurrentRow.Cells[7].Value.ToString();
        }

        private void lblalterarcad_Click(object sender, EventArgs e)
        {
            using (var tb = new Contextocs())
            {
                try
                {
                    var objeto = tb.ObjetoPaciente.Find(Convert.ToInt32(txtidcad.Text));
                    objeto.NomePaciente = txtnome.Text;
                    objeto.Endereco = txtendereco.Text;
                    objeto.Telefone = txttelefone.Text;
                    objeto.CPF = txtcpf.Text;
                    objeto.Convenio = txtconvenio.Text;
                    objeto.Plano = txtplano.Text;
                    objeto.NumCartao = txtnumcartao.Text;

                    // tb.Entry(objeto).State = EntityState.Modified;
                    tb.SaveChanges();
                    MessageBox.Show("Alteração Realizada com Sucesso", "Alteração");
                    limparcampos();
                    AtualizaGrid();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lblexcluircad_Click(object sender, EventArgs e)
        {
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {

            using (var tb = new Contextocs())
            {
                try
                {
                    var objeto = tb.ObjetoPaciente.Find(Convert.ToInt32(txtidcad.Text));
                    tb.ObjetoPaciente.Remove(objeto);
                    tb.SaveChanges();
                    MessageBox.Show("Excluir com sucesso", "Exclusão");
                    limparcampos();
                    AtualizaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            using (var tb = new Contextocs())
            {
                try
                {
                    var objeto = tb.ObjetoPaciente.Find(Convert.ToInt32(txtidcad.Text));
                    objeto.NomePaciente = txtnome.Text;
                    objeto.Endereco = txtendereco.Text;
                    objeto.Telefone = txttelefone.Text;
                    objeto.CPF = txtcpf.Text;
                    objeto.Convenio = txtconvenio.Text;
                    objeto.Plano = txtplano.Text;
                    objeto.NumCartao = txtnumcartao.Text;

                    // tb.Entry(objeto).State = EntityState.Modified;
                    tb.SaveChanges();
                    MessageBox.Show("Alteração Realizada com Sucesso", "Alteração");
                    limparcampos();
                    AtualizaGrid();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var tb = new Contextocs())
            {
                try
                {
                    tb.ObjetoPaciente.Add(new Pacientes { NomePaciente = txtnome.Text, Endereco = txtendereco.Text, Telefone = txttelefone.Text, CPF = txtcpf.Text, Convenio = txtconvenio.Text, Plano = txtplano.Text, NumCartao = txtnumcartao.Text });
                    tb.SaveChanges();
                    AtualizaGrid();
                    limparcampos();
                    MessageBox.Show("Incluido com sucesso", "Inclusão");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
