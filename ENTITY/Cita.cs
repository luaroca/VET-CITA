﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Cita
    {
        public int ID_Cita { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Estado { get; set; }
        public int CC_Cliente { get; set; }
        public int ID_Veterinario { get; set; }
        public string Nombre_servicio { get; set; }
        public string Accion { get; set; }
    }
}
