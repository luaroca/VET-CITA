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
    public partial class FrmGestionServicio : Form
    {

        Servicio servicio = new Servicio();
        LogicaServicio logicaServicio = new LogicaServicio();
        public FrmGestionServicio()
        {
            InitializeComponent();
        }

        void limpiar()
        {
            txtNombreServicio.Text = "";
            txtPrecio.Text = "";
            dataGridViewServicio.DataSource = logicaServicio.N_listar_servicios();
        }

        void mantenimiento(string accion)
        {
            servicio.Nombre_servicio = txtNombreServicio.Text;
            servicio.Precio = decimal.Parse(txtPrecio.Text);
            servicio.Accion = accion;
            string mensaje = logicaServicio.N_mantenimiento_servicio(servicio);
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewServicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            if (fila >= 0)
            {
                txtNombreServicio.Text = dataGridViewServicio[0, fila].Value.ToString();
                txtPrecio.Text = dataGridViewServicio[1, fila].Value.ToString();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas registrar este servicio?", "Mensaje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                mantenimiento("1");
                limpiar();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas modificar este servicio?", "Mensaje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                mantenimiento("2");
                limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas eliminar este servicio?", "Mensaje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                mantenimiento("3");
                limpiar();
            }
        }

        private void FrmGestionServicio_Load(object sender, EventArgs e)
        {
            dataGridViewServicio.DataSource = logicaServicio.N_listar_servicios();
        }
    }
}
