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
        Mascota mascota = new Mascota();
        Cliente cliente = new Cliente();
        LogicaCliente logicaCliente = new LogicaCliente();
        LogicaMascota logicaMascota = new LogicaMascota();
        LogicaVeterinario logicaVeterinario = new LogicaVeterinario();
        LogicaServicio logicaServicio = new LogicaServicio();
        public FrmGestionCita()
        {
            InitializeComponent();

            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.ShowUpDown = true; 
        }

        private void CargarVeterinarios()
        {
            DataTable veterinarios = logicaVeterinario.N_listar_veterinarios_basico();
            cmbVeterinario.DataSource = veterinarios;
            cmbVeterinario.DisplayMember = "Nombre";
            cmbVeterinario.ValueMember = "ID_Veterinario";
            cmbVeterinario.SelectedIndex = -1; // No seleccionar ningún veterinario al inicio
        }

        private void CargarServicios()
        {
            DataTable servicios = logicaServicio.N_listar_servicios_basico();
            cmbServicio.DataSource = servicios;
            cmbServicio.DisplayMember = "Nombre_servicio";
            cmbServicio.ValueMember = "Nombre_servicio";
            cmbServicio.SelectedIndex = -1; // No seleccionar ningún servicio al inicio
        }

        void limpiar()
        {
            txtID_Cita.Text = "";
            dtpFecha.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now; // Resetea la hora al limpiar            
            txtCosto.Text = "";           
            dataGridViewCitas.DataSource = logicaCita.N_listar_citas();
        }




        private void mantenimiento(string accion)
        {

            cliente.CC_Cliente = int.Parse(txtCCCliente.Text);
            cliente.Nombre = txtNombre.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Accion = accion;
            string mensaje2 = logicaCliente.N_mantenimiento_cliente(cliente);
            MessageBox.Show(mensaje2, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            mascota.Nombre = txtNombreMascota.Text;
            mascota.Especie = cmbEspecie.SelectedItem.ToString();
            mascota.Raza = txtRaza.Text;
            mascota.Edad = int.Parse(txtEdad.Text);
            mascota.Sexo = txtSexo.Text;
            mascota.CC_Cliente = int.Parse(txtCCCliente.Text);
            mascota.Accion = accion;

            string mensaje1 = logicaMascota.N_mantenimiento_mascota(mascota);
            MessageBox.Show(mensaje1, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);


            cita.ID_Cita = int.Parse(txtID_Cita.Text);
            cita.Fecha = dtpFecha.Value;
            cita.Hora = dtpHora.Value.TimeOfDay;
            cita.Estado = cmbEstado.SelectedItem.ToString();
            cita.CC_Cliente= int.Parse(txtCCCliente.Text);
            
            if (cmbVeterinario.SelectedValue != null)
            {
                cita.ID_Veterinario = Convert.ToInt32(cmbVeterinario.SelectedValue);
            }

            if (cmbServicio.SelectedValue != null)
            {
                cita.Nombre_servicio = cmbServicio.SelectedValue.ToString();
            }
            cita.Accion = accion;
            string mensaje = logicaCita.N_mantenimiento_cita(cita);
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //
        }







        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas registrar la cita?", "Mensaje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                mantenimiento("1");
                limpiar();
                CargarVeterinarios();
            }
        }

        private void FrmGestionCita_Load(object sender, EventArgs e)
        {
            CargarVeterinarios();
            CargarServicios();

            dataGridViewCitas.DataSource = logicaCita.N_listar_citas();

            // Renombrar las columnas para que sean más descriptivas, si es necesario
            dataGridViewCitas.Columns["Nombre_Veterinario"].HeaderText = "Veterinario";
            dataGridViewCitas.Columns["Nombre_Servicio"].HeaderText = "Servicio";
            dataGridViewCitas.Columns["Estado"].HeaderText = "Estado";
        }
    }
}
