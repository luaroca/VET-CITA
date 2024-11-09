using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Servicio
    {
        public int ID_Servicio { get; set; }
        public string Nombre_servicio { get; set; }
        public decimal Precio { get; set; }
        public string Accion { get; set; }


        public ICollection<Cita> Citas { get; set; }
    }
}
