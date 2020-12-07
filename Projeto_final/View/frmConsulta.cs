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
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void AtualizaGrid()
        {
            using (var tb = new Contextocs())
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tb.ObjetoConsulta.ToList();
            }
        }

        private void txtExame_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {

            CarregaGrid();
            using (var tb = new Contextocs())
            {








                var item = from Medico in tb.ObjetoMedico
                           select new { Medico.NomeMedico };

                cbmedico.Items.Clear();
                cbmedico.DataSource = item.ToList();
                cbmedico.DisplayMember = "NomeMedico";
            }
            using (var tb = new Contextocs())
            {
                var item = from Pacientes in tb.ObjetoPaciente
                           select new { Pacientes.NomePaciente };

                cbpaciente.Items.Clear();
                cbpaciente.DataSource = item.ToList();
                cbpaciente.DisplayMember = "NomePaciente";
            }
        }

       



        private void bntinserir_Click(object sender, EventArgs e)
        {
            using (var tb = new Contextocs())
            {
                //var objeto = tb.ObjetoConsulta.Find(Convert.ToInt32(txtidmedico.Text));

                int ResultadoPesquisaMedico;
                string TextoMedico;
                TextoMedico = cbmedico.Text;

                var ObjetoPesquisaMedico = tb.ObjetoMedico.Where(a => a.NomeMedico == TextoMedico).FirstOrDefault();
                ResultadoPesquisaMedico = ObjetoPesquisaMedico.IdMedico;

                int ResultadoPaciente;
                string TextoPaciente;
                TextoPaciente = cbpaciente.Text;

                var ObjetoPesquisaPaciente = tb.ObjetoPaciente.Where(a => a.NomePaciente == TextoPaciente).FirstOrDefault();
                ResultadoPaciente = ObjetoPesquisaPaciente.IdPaciente;






                tb.ObjetoConsulta.Add(new Consulta
                {
                    IdMedico = ResultadoPesquisaMedico,
                    IdPaciente = ResultadoPaciente,
                    Exame = txtExame.Text,
                    Diagnostico = txtDiagnostico.Text,
                    Data = Convert.ToDateTime(dateTime.Text)

                }) ;
                tb.SaveChanges();
                AtualizaGrid();

            } 
            
            
        }

        private void cbmedico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            txtExame.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cbmedico.Text = dataGridView1.CurrentRow.Cells[1 ].Value.ToString();
            txtidconsulta.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cbpaciente.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtidmedico.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtpaci.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTime.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
           
        }

        private void CarregaGrid()
        {
            using (var tb = new Contextocs())
            {
                var result = from consulta in tb.ObjetoConsulta
                             join medico in tb.ObjetoMedico
                             on consulta.IdMedico equals medico.IdMedico
                             join paciente in tb.ObjetoPaciente
                             on consulta.IdPaciente equals paciente.IdPaciente
                             select new
                             {
                                 consulta.IdMedico,
                                 medico.NomeMedico,
                                 consulta.IdPaciente,
                                 paciente.NomePaciente,
                                 consulta.Data,
                                 consulta.Exame,
                                 consulta.IdConsulta,
                             };
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = result.ToList();
            }    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            using (var tb = new Contextocs())
            {
                try
                {
                    var objeto = tb.ObjetoConsulta.Find(Convert.ToInt32(txtidconsulta.Text));
                    objeto.Diagnostico = txtDiagnostico.Text;
                    objeto.Exame = txtExame.Text;
                    objeto.IdPaciente = Convert.ToInt32(cbpaciente.Text);
                    objeto.IdMedico = Convert.ToInt32(cbmedico.Text);
                    objeto.Data = Convert.ToDateTime(dateTime.Text);
                    tb.SaveChanges();
                    MessageBox.Show("Alteração Realizada", "Alteração");
                    AtualizaGrid();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            using (var tb = new Contextocs())
            {
                try
                {
                    var objeto = tb.ObjetoConsulta.Find(Convert.ToInt32(txtidconsulta.Text));
                    tb.ObjetoConsulta.Remove(objeto);
                    tb.SaveChanges();
                    MessageBox.Show("Excluido com sucesso", "Exclusão");
                    AtualizaGrid();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
