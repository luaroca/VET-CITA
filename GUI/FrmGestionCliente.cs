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
    public partial class FrmGestionCliente : Form
    {

        private Cliente cliente = new Cliente();
        private LogicaCliente logicaCliente = new LogicaCliente();

        public FrmGestionCliente()
        {
            InitializeComponent();
            CargarClientes();
        }

        private void CargarClientes()
        {
            dataGridViewClientes.DataSource = logicaCliente.ListarClientes();
        }

        private void LimpiarCampos()
        {
            txtCC_Cliente.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            CargarClientes();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            cliente.CC_Cliente = int.Parse(txtCC_Cliente.Text);
            cliente.Nombre = txtNombre.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Telefono = txtTelefono.Text;

            string mensaje = logicaCliente.MantenimientoCliente(cliente, "1");
            MessageBox.Show(mensaje, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            cliente.CC_Cliente = int.Parse(txtCC_Cliente.Text);
            cliente.Nombre = txtNombre.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Telefono = txtTelefono.Text;

            string mensaje = logicaCliente.MantenimientoCliente(cliente, "2");
            MessageBox.Show(mensaje, "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cliente.CC_Cliente = int.Parse(txtCC_Cliente.Text);

            string mensaje = logicaCliente.MantenimientoCliente(cliente, "3");
            MessageBox.Show(mensaje, "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
        }

        //private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dataGridViewClientes.CurrentRow != null)
        //    {
        //        txtCC_Cliente.Text = dataGridViewClientes.CurrentRow.Cells[0].Value.ToString();
        //        txtNombre.Text = dataGridViewClientes.CurrentRow.Cells[1].Value.ToString();
        //        txtDireccion.Text = dataGridViewClientes.CurrentRow.Cells[2].Value.ToString();
        //        txtTelefono.Text = dataGridViewClientes.CurrentRow.Cells[3].Value.ToString();
        //    }
        //}

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            cliente.CC_Cliente = int.Parse(txtCC_Cliente.Text);

            string mensaje = logicaCliente.MantenimientoCliente(cliente, "3");
            MessageBox.Show(mensaje, "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            cliente.CC_Cliente = int.Parse(txtCC_Cliente.Text);
            cliente.Nombre = txtNombre.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Telefono = txtTelefono.Text;

            string mensaje = logicaCliente.MantenimientoCliente(cliente, "2");
            MessageBox.Show(mensaje, "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridViewClientes.CurrentCell.RowIndex;

            txtCC_Cliente.Text = dataGridViewClientes[0, fila].Value.ToString();
            txtNombre.Text = dataGridViewClientes[1, fila].Value.ToString();
            txtDireccion.Text = dataGridViewClientes[2, fila].Value.ToString();
            txtTelefono.Text = dataGridViewClientes[3, fila].Value.ToString();

        }



    }
}
