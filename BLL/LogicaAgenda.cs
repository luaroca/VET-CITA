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
    public class LogicaAgenda
    {
        RepositoryAgenda objd = new RepositoryAgenda();

        public DataTable N_listar_agenda()
        {
            return objd.D_listar_agenda();
        }

        public DataTable N_buscar_agenda(Agenda obj)
        {
            return objd.D_buscar_agenda(obj);
        }

        public string N_mantenimiento_agenda(Agenda obj)
        {
            return objd.D_mantenimiento_agenda(obj);
        }
    }
}
