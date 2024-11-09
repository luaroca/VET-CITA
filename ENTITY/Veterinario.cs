using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Veterinario
    {
        public int ID_Veterinario { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public string Telefono { get; set; }
        public string Horario { get; set; }
        public string Accion { get; set; }


        public ICollection<Cita> Citas { get; set; }
    }
}
