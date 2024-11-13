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
    public partial class FrmGestionMascota : Form
    {

        Mascota mascota = new Mascota();
        LogicaMascota logicaMascota = new LogicaMascota();
        public FrmGestionMascota()
        {
            InitializeComponent();
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void mantenimiento(string accion)
        {

         

            mascota.Nombre = txtNombre.Text;
            mascota.Especie = txtEspecie.Text;
            mascota.Raza = txtRaza.Text;
            mascota.Edad = int.Parse(txtEdad.Text);
            mascota.Sexo = txtSexo.Text;
            mascota.CC_Cliente = int.Parse(txtCC_Cliente.Text);
            mascota.Accion = accion;

            string mensaje1 = logicaMascota.N_mantenimiento_mascota(mascota);
            MessageBox.Show(mensaje1, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void dataGridViewMascotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            if (fila >= 0)
            {
                txtNombre.Text = dataGridViewMascotas[0, fila].Value.ToString();
                txtEspecie.Text = dataGridViewMascotas[1, fila].Value.ToString();
                txtRaza.Text = dataGridViewMascotas[2, fila].Value.ToString();
                txtEdad.Text = dataGridViewMascotas[3, fila].Value.ToString();
                txtSexo.Text = dataGridViewMascotas[4, fila].Value.ToString();
                txtCC_Cliente.Text = dataGridViewMascotas[5, fila].Value.ToString();
            }
        }

        private void FrmGestionMascota_Load(object sender, EventArgs e)
        {
            dataGridViewMascotas.DataSource = logicaMascota.N_listar_mascotas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas modificar a " + txtNombre.Text + "?", "Mensaje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                mantenimiento("2");
                
            }
        }
    }
}
