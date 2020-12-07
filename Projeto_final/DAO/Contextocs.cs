using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Projeto_final.Entidades;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_final.DAO
{
    class Contextocs : DbContext
    { 
       public Contextocs() : base("conexao")
        {
            Database.SetInitializer<Contextocs>(null);
        }
        public DbSet<Pacientes> ObjetoPaciente { get; set; }
        public DbSet<Medico> ObjetoMedico { get; set; }
        public DbSet<Especialidade> ObjetoEspecialida { get; set; }
        public DbSet<Consulta> ObjetoConsulta { get; set; }
        public DbSet<ManutUser> ObjetoManuteUser { get; set; }

    }

    //    *1 -) enable-migration
    //    *2 -) add-migration banco
    //    *3 -) update-database





}
