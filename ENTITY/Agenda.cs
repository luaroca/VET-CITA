using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Agenda
    {
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public int ID_Veterinario { get; set; }
        public string Accion { get; set; }
    }
}
