using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
  

namespace Projeto_final.Entidades
{
    class ManutUser
    {
        [Key]
        public int IdUsuario { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }        
    }
}
