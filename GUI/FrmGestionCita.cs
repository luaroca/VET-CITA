using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmGestionCita : Form
    {

        Cita cita = new Cita();
        LogicaCita logicaCita = new LogicaCita();

        public FrmGestionCita()
        {
            InitializeComponent();

            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.ShowUpDown = true; 
        }


        void limpiar()
        {
            txtID_Cita.Text = "";
            dtpFecha.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now; // Resetea la hora al limpiar
            txtEstado.Text = "";
            txtCosto.Text = "";
            txtID_Mascota.Text = "";
            txtID_Veterinario.Text = "";
            txtID_Servicio.Text = "";
            dataGridViewCitas.DataSource = logicaCita.N_listar_citas();
        }


        void mantenimiento(string accion)
        {
            cita.ID_Cita = int.Parse(txtID_Cita.Text);
            cita.Fecha = dtpFecha.Value;
            cita.Hora = dtpHora.Value.TimeOfDay; // Toma solo la parte de la hora
            cita.Estado = cmbEstado.SelectedItem.ToString();
            cita.Costo = decimal.Parse(txtCosto.Text);
            cita.ID_Mascota = int.Parse(txtID_Mascota.Text);
            cita.ID_Veterinario = int.Parse(txtID_Veterinario.Text);

            if(txtID_Servicios.Text == "Consulta General")
            {
                cita.ID_Servicio = 1;
            }
            //cita.ID_Servicio = int.Parse(txtID_Servicio.Text);
            cita.Accion = accion;
            string mensaje = logicaCita.N_mantenimiento_cita(cita);
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }







        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas registrar la cita?", "Mensaje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                mantenimiento("1");
                limpiar();
            }
        }

        private void FrmGestionCita_Load(object sender, EventArgs e)
        {
            dataGridViewCitas.DataSource = logicaCita.N_listar_citas();

            // Renombrar las columnas para que sean más descriptivas, si es necesario
            dataGridViewCitas.Columns["Nombre_Mascota"].HeaderText = "Mascota";
            dataGridViewCitas.Columns["Nombre_Veterinario"].HeaderText = "Veterinario";
            dataGridViewCitas.Columns["Nombre_Servicio"].HeaderText = "Servicio";
            dataGridViewCitas.Columns["Estado"].HeaderText = "Estado";
        }
    }
}
