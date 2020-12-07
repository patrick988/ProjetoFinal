using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_final.Entidades
{
    class Pacientes
    {
        [Key]
        public int IdPaciente { get; set; }
        public string NomePaciente { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string Convenio { get; set; }
        public string Plano { get; set; }
        public string NumCartao { get; set; }
       

    }
}
