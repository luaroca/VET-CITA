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

        Cliente cliente = new Cliente();
        LogicaCliente logicaCliente = new LogicaCliente();
        public FrmGestionCliente()
        {
            InitializeComponent();
            
        }

       

        private void LimpiarCampos()
        {
            txtCC_Cliente.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            
        }

        void limpiar()
        {
            txtCC_Cliente.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            dataGridViewClientes.DataSource = logicaCliente.N_listar_clientes();
        }

        void mantenimiento(string accion)
        {
            cliente.CC_Cliente = int.Parse(txtCC_Cliente.Text);
            cliente.Nombre = txtNombre.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Accion = accion;
            string mensaje = logicaCliente.N_mantenimiento_cliente(cliente);
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //if (txtCC_Cliente.Text == "")
            //{
            //    if (MessageBox.Show("¿Deseas registrar a " + txtNombre.Text + "?", "Mensaje",
            //        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            //    {
            //        mantenimiento("1");
            //        limpiar();
            //    }
            //}

            if (!string.IsNullOrEmpty(txtNombre.Text)) 
            {
                if (MessageBox.Show("¿Deseas registrar a " + txtNombre.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    mantenimiento("1");
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa los datos del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtCC_Cliente.Text != "")
            {
                if (MessageBox.Show("¿Deseas modificar a " + txtNombre.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    mantenimiento("2");
                    limpiar();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCC_Cliente.Text != "")
            {
                if (MessageBox.Show("¿Deseas eliminar a " + txtNombre.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    mantenimiento("3");
                    limpiar();
                }
            }
        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (txtCC_Cliente.Text != "")
            {
                if (MessageBox.Show("¿Deseas eliminar a " + txtNombre.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    mantenimiento("3");
                    limpiar();
                }
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (txtCC_Cliente.Text != "")
            {
                if (MessageBox.Show("¿Deseas modificar a " + txtNombre.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    mantenimiento("2");
                    limpiar();
                }
            }
        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int fila = dataGridViewClientes.CurrentCell.RowIndex;

            //txtCC_Cliente.Text = dataGridViewClientes[0, fila].Value.ToString();
            //txtNombre.Text = dataGridViewClientes[1, fila].Value.ToString();
            //txtDireccion.Text = dataGridViewClientes[2, fila].Value.ToString();
            //txtTelefono.Text = dataGridViewClientes[3, fila].Value.ToString();


            int fila = e.RowIndex;
            if (fila >= 0)
            {
                txtCC_Cliente.Text = dataGridViewClientes[0, fila].Value.ToString();
                txtNombre.Text = dataGridViewClientes[1, fila].Value.ToString();
                txtDireccion.Text = dataGridViewClientes[2, fila].Value.ToString();
                txtTelefono.Text = dataGridViewClientes[3, fila].Value.ToString();
            }


        }

        private void FrmGestionCliente_Load(object sender, EventArgs e)
        {
            dataGridViewClientes.DataSource = logicaCliente.N_listar_clientes();
        }
    }
}
