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
    public class LogicaUsuario
    {
        RepositoryUsuario objd = new RepositoryUsuario();

        public DataTable N_listar_usuarios()
        {
            return objd.D_listar_usuarios();
        }

        public DataTable N_buscar_usuario(Usuario obje)
        {
            return objd.D_buscar_usuario(obje);
        }

        public string N_mantenimiento_usuario(Usuario obje)
        {
            return objd.D_mantenimiento_usuario(obje);
        }
    }
}
