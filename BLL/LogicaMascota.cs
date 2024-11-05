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
        RepositoryMascota repository = new RepositoryMascota();

        public DataTable ListarMascotas()
        {
            return repository.ListarMascotas();
        }

        public DataTable BuscarMascota(string nombre)
        {
            return repository.BuscarMascota(nombre);
        }

        public string MantenimientoMascota(Mascota mascota, string accion)
        {
            return repository.MantenimientoMascota(mascota, accion);
        }
    }
}
