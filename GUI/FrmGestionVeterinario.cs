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
    public partial class FrmGestionVeterinario : Form
    {

        Veterinario veterinario = new Veterinario();
        LogicaVeterinario logicaVeterinario = new LogicaVeterinario();
        public FrmGestionVeterinario()
        {
            InitializeComponent();
        }

        void limpiar()
        {
            txtID_Veterinario.Text = "";
            txtNombre.Text = "";
            txtEspecialidad.Text = "";
            txtTelefono.Text = "";
            dataGridViewVeterinario.DataSource = logicaVeterinario.N_listar_veterinario();
        }

        void mantenimiento(string accion)
        {
            veterinario.ID_Veterinario = int.Parse(txtID_Veterinario.Text);
            veterinario.Nombre = txtNombre.Text;
            veterinario.Especialidad = txtEspecialidad.Text;
            veterinario.Telefono = txtTelefono.Text;
            veterinario.Accion = accion;
            string mensaje = logicaVeterinario.N_mantenimiento_veterinario(veterinario);
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas registrar a este veterinario?", "Mensaje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                mantenimiento("1");
                limpiar();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas modificar a este veterinario?", "Mensaje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                mantenimiento("2");
                limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas eliminar a este veterinario?", "Mensaje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                mantenimiento("3");
                limpiar();
            }
        }

        private void dataGridViewVeterinario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            if (fila >= 0)
            {
                txtID_Veterinario.Text = dataGridViewVeterinario[0, fila].Value.ToString();
                txtNombre.Text = dataGridViewVeterinario[1, fila].Value.ToString();
                txtEspecialidad.Text = dataGridViewVeterinario[2, fila].Value.ToString();
                txtTelefono.Text = dataGridViewVeterinario[3, fila].Value.ToString();
            }
        }

        private void FrmGestionVeterinario_Load(object sender, EventArgs e)
        {
            dataGridViewVeterinario.DataSource = logicaVeterinario.N_listar_veterinario();
        }
    }
}
