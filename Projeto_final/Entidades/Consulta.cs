using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Forms;
using System.Data.Entity;
namespace Projeto_final.Entidades
{
    class Consulta
    {
        [Key]
        public int IdConsulta { get; set; }
        public int IdPaciente { get; set; }
        public Pacientes Paciente { get; set; }
        public int IdMedico { get; set; }
        public Medico Medico { get; set; }
        public DateTime Data { get; set; }
        public string Diagnostico { get; set; }
        public string Exame { get; set; }
    }
}
