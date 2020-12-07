using Projeto_final.DAO;
using Projeto_final.Entidades;
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

namespace Projeto_final.View
{
    public partial class frmEspecialidade : Form
    {
        public frmEspecialidade()
        {
            InitializeComponent();
        }
        

        private void btnInserir_Click(object sender, EventArgs e)
        {
            using (var tb = new Contextocs())
            {
                try
                {
                    tb.ObjetoEspecialida.Add(new Especialidade { Especialidades = txtEspecialidade.Text });
                    tb.SaveChanges();
                    AtualizaGrid();
                    MessageBox.Show("Especialidade Cadastrada", "Inserir");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void AtualizaGrid()
        {
            using (var tb = new Contextocs())
            {
                dgEspecialidade.DataSource = null;
                dgEspecialidade.DataSource = tb.ObjetoEspecialida.ToList();
            }
        }
        public void Limparcampos()
        {
            txtEspecialidade.Text = "";
            txtEspecialidade.Focus();
            AtualizaGrid();
        }

        private void dgEspecialidade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgEspecialidade.CurrentRow.Cells[0].Value.ToString();
            txtEspecialidade.Text = dgEspecialidade.CurrentRow.Cells[1].Value.ToString();

        }

        private void frmEspecialidade_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            using (var tb = new Contextocs())
            {
                try
                {
                    var objeto = tb.ObjetoEspecialida.Find(Convert.ToInt32(txtID.Text));
                    objeto.Especialidades = txtEspecialidade.Text;

                    //tb.Entry(objeto).State = EntityState.Modified;
                    tb.SaveChanges();
                    MessageBox.Show("Alteração do Cadastro de Especialidade", "Alteração");
                    AtualizaGrid();
                    Limparcampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            using (var tb = new Contextocs())
            {
                try
                {
                    var objeto = tb.ObjetoEspecialida.Find(Convert.ToInt32(txtID.Text));
                    tb.ObjetoEspecialida.Remove(objeto);
                    tb.SaveChanges();
                    MessageBox.Show("Excluido Com sucesso", "Exclusão");
                    AtualizaGrid();
                    Limparcampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
