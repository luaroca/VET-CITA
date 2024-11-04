using System;
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
        public int ID_Mascota { get; set; }
        public int ID_Veterinario { get; set; }
        public decimal Costo { get; set; }
        public int ID_Servicio { get; set; }
        public string Estado { get; set; }
        public Pago Pago { get; set; }
    }
}
