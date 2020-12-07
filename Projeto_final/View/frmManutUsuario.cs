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
    public partial class frmManutUsuario : Form
    {
        public frmManutUsuario()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var tb = new Contextocs())
            {
                try
                {
                    tb.ObjetoManuteUser.Add(new ManutUser { usuario = txtUsuario.Text, senha = txtSenha.Text });
                    tb.SaveChanges();
                    limpacampos();
                    MessageBox.Show("Incluido com sucesso", "Inclusão");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void limpacampos()
        {
            txtID.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtUsuario.Focus();
            AtualizaGrid();
        }
        private void AtualizaGrid()
        {
            using (var tb = new Contextocs())
            {
                dgManutUsuario.DataSource = null;
                dgManutUsuario.DataSource = tb.ObjetoManuteUser.ToList();

            }
        }
        private void frmManutUsuario_load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void dgManutUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgManutUsuario.CurrentRow.Cells[0].Value.ToString();
            txtUsuario.Text = dgManutUsuario.CurrentRow.Cells[1].Value.ToString();
            txtSenha.Text = dgManutUsuario.CurrentRow.Cells[2].Value.ToString();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var tb = new Contextocs())
            {
                try
                {
                    var objeto = tb.ObjetoManuteUser.Find(Convert.ToInt32(txtID.Text));
                    objeto.usuario = txtUsuario.Text;
                    objeto.senha = txtSenha.Text;

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

        private void frmManutUsuario_Load_1(object sender, EventArgs e)
        {
            AtualizaGrid();

        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var tb = new Contextocs())
            {
                try
                {
                    var objeto = tb.ObjetoManuteUser.Find(Convert.ToInt32(txtID.Text));
                    tb.ObjetoManuteUser.Remove(objeto);
                    tb.SaveChanges();
                    MessageBox.Show("Excluido com sucesso", "Exclusão");
                    limpacampos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }

   
}
