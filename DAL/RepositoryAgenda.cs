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
    public class RepositoryAgenda
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable D_listar_agenda()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_agenda", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_buscar_agenda(Agenda obj)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_agenda", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Fecha", obj.Fecha);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public string D_mantenimiento_agenda(Agenda obj)
        {
            string accion = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_agenda", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Fecha", obj.Fecha);
            cmd.Parameters.AddWithValue("@Hora", obj.Hora);
            cmd.Parameters.AddWithValue("@ID_Veterinario", obj.ID_Veterinario);
            cmd.Parameters.Add("@Accion", SqlDbType.VarChar, 50).Value = obj.Accion;
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
