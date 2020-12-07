using Projeto_final.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_final.View;
using System.Linq.Expressions;

namespace Projeto_final
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var tb = new Contextocs())
            {
                try
                {
                    var objusr = tb.ObjetoManuteUser.Where(x => x.usuario == txtUsuario.Text).FirstOrDefault();
                    var objpass = tb.ObjetoManuteUser.Where(a => a.senha == txtSenha.Text).FirstOrDefault();
                    if (objusr != null && objpass != null)
                    {
                        this.Hide();
                        Form f = new fmrSistemaconsultorio();
                        f.Closed += (s, args) => this.Close();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha não confere");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
                
             }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}

