using ENTITY;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RepositoryMascota
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable ListarMascotas()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_mascotas", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable BuscarMascota(string nombre)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_mascota", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public string MantenimientoMascota(Mascota mascota, string accion)
        {
            string mensaje = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_mascota", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_Mascota", mascota.ID_Mascota);
            cmd.Parameters.AddWithValue("@Nombre", mascota.Nombre);
            cmd.Parameters.AddWithValue("@Especie", mascota.Especie);
            cmd.Parameters.AddWithValue("@Raza", mascota.Raza);
            cmd.Parameters.AddWithValue("@Edad", mascota.Edad);
            cmd.Parameters.AddWithValue("@Sexo", mascota.Sexo);
            cmd.Parameters.AddWithValue("@ID_Cliente", mascota.ID_Cliente);
            cmd.Parameters.Add("@Accion", SqlDbType.VarChar, 50).Value = accion;
            cmd.Parameters["@Accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            mensaje = cmd.Parameters["@Accion"].Value.ToString();
            cn.Close();
            return mensaje;
        }
    }
}
