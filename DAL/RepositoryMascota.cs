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

        public DataTable D_listar_mascotas()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_mascotas", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_buscar_mascota(Mascota obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_mascota", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", obje.Nombre);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public string D_mantenimiento_mascota(Mascota obje)
        {
            string accion = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_mascota", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_Mascota", obje.ID_Mascota);
            cmd.Parameters.AddWithValue("@Nombre", obje.Nombre);
            cmd.Parameters.AddWithValue("@Especie", obje.Especie);
            cmd.Parameters.AddWithValue("@Raza", obje.Raza);
            cmd.Parameters.AddWithValue("@Edad", obje.Edad);
            cmd.Parameters.AddWithValue("@Sexo", obje.Sexo);
            cmd.Parameters.AddWithValue("@CC_Cliente", obje.CC_Cliente);
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
