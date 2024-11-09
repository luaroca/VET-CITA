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
    public class RepositoryPago
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable D_listar_pagos()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_pagos", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_buscar_pago(Pago obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_pago", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Metodo_Pago", obje.Metodo_Pago);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public string D_mantenimiento_pago(Pago obje)
        {
            string accion = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_pago", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_Pago", obje.ID_Pago);
            cmd.Parameters.AddWithValue("@Metodo_Pago", obje.Metodo_Pago);
            cmd.Parameters.AddWithValue("@Fecha_Pago", obje.Fecha_Pago);
            cmd.Parameters.AddWithValue("@Monto", obje.Monto);
            cmd.Parameters.AddWithValue("@ID_Cita", obje.ID_Cita);
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
