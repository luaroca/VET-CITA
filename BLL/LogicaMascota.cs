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
    public class LogicaMascota
    {
        RepositoryMascota objd = new RepositoryMascota();

        public DataTable N_listar_mascotas()
        {
            return objd.D_listar_mascotas();
        }

        public DataTable N_buscar_mascota(Mascota obje)
        {
            return objd.D_buscar_mascota(obje);
        }

        public string N_mantenimiento_mascota(Mascota obje)
        {
            return objd.D_mantenimiento_mascota(obje);
        }
    }
}
