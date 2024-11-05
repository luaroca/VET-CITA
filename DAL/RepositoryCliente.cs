using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;



namespace DAL
{
    public class RepositoryCliente
    {
        private SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);


        public DataTable ListarClientes()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public DataTable BuscarClientes(string nombre)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente WHERE Nombre LIKE @nombre + '%'", cn);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public string MantenimientoCliente(Cliente cliente, string accion)
        {
            string mensaje = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_cliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Establece los parámetros necesarios dependiendo de la acción
            cmd.Parameters.AddWithValue("@CC_Cliente", cliente.CC_Cliente);

            // Solo asigna los parámetros que son relevantes para la acción
            if (accion == "1") // Insertar
            {
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            }
            else if (accion == "2") // Modificar
            {
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            }
            else if (accion == "3") // Eliminar
            {
                // Para eliminar, no se necesitan Nombre, Dirección o Teléfono
                cmd.Parameters.AddWithValue("@Nombre", DBNull.Value); // O simplemente no agregar el parámetro
                cmd.Parameters.AddWithValue("@Direccion", DBNull.Value);
                cmd.Parameters.AddWithValue("@Telefono", DBNull.Value);
            }

            cmd.Parameters.Add("@accion", SqlDbType.NVarChar, 50).Value = accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;

            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            mensaje = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return mensaje;
        }




    }
}
