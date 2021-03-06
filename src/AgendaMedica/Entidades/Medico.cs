﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMedica.Entidades {
    public class Medico : Pessoa {

        public string Especialidade { get; set; }
        public string Crm { get; set; }

        public virtual IList<Consulta> Consultas { get; set; }
    }
}
