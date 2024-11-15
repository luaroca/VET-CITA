using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Pago
    {
        public int ID_Pago { get; set; }
        public int ID_Cita { get; set; }
        public string Metodo_Pago { get; set; }
        public DateTime Fecha_Pago { get; set; }
        public decimal Monto { get; set; }
    }

}
