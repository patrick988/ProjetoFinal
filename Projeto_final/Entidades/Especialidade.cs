﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_final.Entidades
{
    class Especialidade
    {
        [Key]
        public int IdEspecialidade { get; set; }
        public string Especialidades { get; set; }
    }
}
