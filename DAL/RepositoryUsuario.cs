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
    public class RepositoryUsuario
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable D_listar_usuarios()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_usuarios", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_buscar_usuario(Usuario obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_usuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NameUsuario", obje.NameUsuario);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public string D_mantenimiento_usuario(Usuario obje)
        {
            string accion = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_usuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NameUsuario", obje.NameUsuario);
            cmd.Parameters.AddWithValue("@Contrasena", obje.Contrasena);
            cmd.Parameters.AddWithValue("@Rol", obje.Rol);
            cmd.Parameters.Add("@Accion", SqlDbType.VarChar, 50).Value = obje.Accion;
            cmd.Parameters["@Accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@Accion"].Value.ToString();
            cn.Close();
            return accion;
        }
    }
}
