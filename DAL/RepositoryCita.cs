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
    public class RepositoryCita
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable D_listar_citas()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_citas", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_buscar_cita(Cita obj)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_cita", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_Cita", obj.ID_Cita);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public string D_mantenimiento_cita(Cita obj)
        {
            string accion = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_cita", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_Cita", obj.ID_Cita);
            cmd.Parameters.AddWithValue("@Fecha", obj.Fecha);
            cmd.Parameters.AddWithValue("@Hora", obj.Hora);
            cmd.Parameters.AddWithValue("@Estado", obj.Estado);
            cmd.Parameters.AddWithValue("@CC_Cliente", obj.CC_Cliente);
            cmd.Parameters.AddWithValue("@ID_Veterinario", obj.ID_Veterinario);
            cmd.Parameters.AddWithValue("@Nombre_servicio", obj.Nombre_servicio);
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
