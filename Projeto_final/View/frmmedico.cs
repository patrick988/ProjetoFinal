using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_final.DAO;
using Projeto_final.Entidades;


namespace Projeto_final.View
{
    public partial class frmmedico : Form
    {
        public frmmedico()
        {
            InitializeComponent();
        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            using (var tb = new Contextocs())
            {
                try
                {
                    tb.ObjetoMedico.Add(new Medico {NomeMedico = txtnome.Text, Endereco = txtendereco.Text, Telefone = txttelefone.Text, CPF = txtcpf.Text,IdEspecialidade = Convert.ToInt32(cmbespecialidade.Text)});
                    tb.SaveChanges();
                    MessageBox.Show("Incluido com seucesso","Inclusão");
                    AtualizaGrid();
                    limpacampos();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void AtualizaGrid()
        {
            using (var tb = new Contextocs())
            {
                dgmedico.DataSource = null;
                dgmedico.DataSource = tb.ObjetoMedico.ToList();
            }


        }
        public void limpacampos()
        {
            txtnome.Text = "";
            txtendereco.Text = "";
            txtcpf.Text = "";
            txtidmed.Text = "";
            txttelefone.Text = "";
            AtualizaGrid();
            txtnome.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            using (var tb = new Contextocs())
            {
                try
                {
                    var objeto = tb.ObjetoMedico.Find(Convert.ToInt32(txtidmed.Text));
                    objeto.NomeMedico = txtnome.Text;
                    objeto.Endereco = txtendereco.Text;
                    objeto.Telefone = txttelefone.Text;
                    objeto.CPF = txtcpf.Text;

                    // tb.Entry(objeto).State = EntityState.Modified;
                    tb.SaveChanges();
                    MessageBox.Show("Alteração realizada com sucesso", "Alteração");
                    limpacampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cbespecialidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmmedico_Load(object sender, EventArgs e)
        {
            
            using (var tb = new Contextocs())
            {
                var item = from Especialidade in tb.ObjetoEspecialida
                           select new { Especialidade.IdEspecialidade};
                cmbespecialidade.Items.Clear();
                cmbespecialidade.DataSource = item.ToList();
                cmbespecialidade.DisplayMember = "IdEspecialidade";
                tb.SaveChanges();
            }
            {
                AtualizaGrid();
            }
            

        }

        private void dgmedico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnome.Text = dgmedico.CurrentRow.Cells[2].Value.ToString();
            txtendereco.Text = dgmedico.CurrentRow.Cells[3].Value.ToString();
            txttelefone.Text = dgmedico.CurrentRow.Cells[4].Value.ToString();
            txtcpf.Text = dgmedico.CurrentRow.Cells[5].Value.ToString();
            txtidmed.Text = dgmedico.CurrentRow.Cells[0].Value.ToString();
            
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            using (var tb = new Contextocs())
            {
                try
                {
                    var objeto = tb.ObjetoMedico.Find(Convert.ToInt32(txtidmed.Text));
                    tb.ObjetoMedico.Remove(objeto);
                    tb.SaveChanges();
                    MessageBox.Show("Excluido com sucesso", "Exclusão");
                    limpacampos();
                    AtualizaGrid();
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void frmmedico_Layout(object sender, LayoutEventArgs e)
        {

        }
    }
}
