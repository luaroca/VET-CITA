using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LogicaCita
    {
        RepositoryCita objd = new RepositoryCita();

        public DataTable N_listar_citas()
        {
            return objd.D_listar_citas();
        }

        public DataTable N_buscar_cita(Cita obje)
        {
            return objd.D_buscar_cita(obje);
        }

        public string N_mantenimiento_cita(Cita obje)
        {
            return objd.D_mantenimiento_cita(obje);
        }
    }
}
