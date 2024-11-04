﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Mascota
    {
        public int ID_Mascota { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public int ID_Cliente { get; set; }
        public string Nombre { get; set; }

        
        public ICollection<Cita> Citas { get; set; }
    }
}
