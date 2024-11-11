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
    public class RepositoryVeterinario
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable D_listar_veterinarios()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_veterinarios", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_buscar_veterinario(Veterinario obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_veterinario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", obje.Nombre);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_listar_veterinarios_basico()
        {
            SqlCommand cmd = new SqlCommand("SELECT ID_Veterinario, Nombre FROM Veterinario", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        

        public string D_mantenimiento_veterinario(Veterinario obje)
        {
            string accion = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_veterinario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_Veterinario", obje.ID_Veterinario);
            cmd.Parameters.AddWithValue("@Nombre", obje.Nombre);
            cmd.Parameters.AddWithValue("@Especialidad", obje.Especialidad);
            cmd.Parameters.AddWithValue("@Telefono", obje.Telefono);
            cmd.Parameters.AddWithValue("@Horario", obje.Horario);
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
