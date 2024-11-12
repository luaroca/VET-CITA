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
    public class LogicaServicio
    {
        RepositoryServicio objd = new RepositoryServicio();

        public DataTable N_listar_servicios()
        {
            return objd.D_listar_servicios();
        }

        public DataTable N_buscar_servicio(Servicio obj)
        {
            return objd.D_buscar_servicio(obj);
        }

        public string N_mantenimiento_servicio(Servicio obj)
        {
            return objd.D_mantenimiento_servicio(obj);
        }
    }
}
