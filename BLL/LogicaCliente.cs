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
        private RepositoryCliente repoCliente = new RepositoryCliente();

       
        public DataTable ListarClientes()
        {
            return repoCliente.ListarClientes();
        }

        
        public DataTable BuscarClientes(string nombre)
        {
            return repoCliente.BuscarClientes(nombre);
        }

        

        public string MantenimientoCliente(Cliente cliente, string accion)
        {
            return repoCliente.MantenimientoCliente(cliente, accion);
        }
    }
}
