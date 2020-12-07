using Projeto_final.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_final
{
    public partial class fmrSistemaconsultorio : Form
    {
        public fmrSistemaconsultorio()
        {
            InitializeComponent();
        }

        private void fmrSistemaconsultorio_Load(object sender, EventArgs e)
        {

        }

        private void manutençãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manutençãoDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManutUsuario manutusr = new frmManutUsuario();
            manutusr.Show();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaciente paciente = new frmPaciente();
            paciente.Show();
        }

        private void especialidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEspecialidade especialidade = new frmEspecialidade();
            especialidade.Show();
        }

        private void medicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmedico medico = new frmmedico();
            medico.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta consulta = new frmConsulta();
            consulta.Show();
        }
    }
}
