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
    public class LogicaCliente
    {
        RepositoryCliente repository = new RepositoryCliente();

        public DataTable ListarClientes()
        {
            return repository.ListarClientes();
        }

        public DataTable BuscarCliente(string nombre)
        {
            return repository.BuscarCliente(nombre);
        }

        public string MantenimientoCliente(Cliente cliente, string accion)
        {
            return repository.MantenimientoCliente(cliente, accion);
        }
    }
}
