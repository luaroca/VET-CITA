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
        RepositoryCliente repoCliente = new RepositoryCliente();

        public DataTable N_listar_clientes()
        {
            return repoCliente.D_listar_clientes();
        }

        public DataTable N_buscar_cliente(Cliente cliente)
        {
            return repoCliente.D_buscar_cliente(cliente);
        }

        public string N_mantenimiento_cliente(Cliente cliente)
        {
            return repoCliente.D_mantenimiento_cliente(cliente);
        }
    }
}
