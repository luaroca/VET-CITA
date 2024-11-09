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
    public class RepositoryServicio
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable D_listar_servicios()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_servicios", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_buscar_servicio(Servicio obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_servicio", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre_servicio", obje.Nombre_servicio);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public string D_mantenimiento_servicio(Servicio obje)
        {
            string accion = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_servicio", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_Servicio", obje.ID_Servicio);
            cmd.Parameters.AddWithValue("@Nombre_servicio", obje.Nombre_servicio);
            cmd.Parameters.AddWithValue("@Precio", obje.Precio);
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
