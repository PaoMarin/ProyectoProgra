﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiempos.Model
{
    class Sorteo
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public DateTime fecha { get; set; }
        public bool activo { get; set; }
    }
}
