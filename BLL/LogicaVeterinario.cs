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
    public class LogicaVeterinario
    {
        RepositoryVeterinario objd = new RepositoryVeterinario();

        public DataTable N_listar_veterinario()
        {
            return objd.D_listar_veterinario();
        }

        public DataTable N_buscar_veterinario(Veterinario obj)
        {
            return objd.D_buscar_veterinario(obj);
        }

        public string N_mantenimiento_veterinario(Veterinario obj)
        {
            return objd.D_mantenimiento_veterinario(obj);
        }

        public DataTable N_listar_veterinarios_basico()
        {
            return objd.D_listar_veterinarios_basico();
        }


    }
}
