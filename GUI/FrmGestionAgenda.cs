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
    public partial class FrmGestionAgenda : Form
    {


        Agenda agenda = new Agenda();
        LogicaAgenda logicaAgenda = new LogicaAgenda();
        public FrmGestionAgenda()
        {
            InitializeComponent();
        }

        void limpiar()
        {
            dtpFecha.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;
            txtID_Veterinario.Text = "";
            dataGridViewAgenda.DataSource = logicaAgenda.N_listar_agenda();
        }

        void mantenimiento(string accion)
        {
            agenda.Fecha = dtpFecha.Value;
            agenda.Hora = dtpHora.Value.TimeOfDay; // Obtiene solo la hora
            agenda.ID_Veterinario = int.Parse(txtID_Veterinario.Text);
            agenda.Accion = accion;
            string mensaje = logicaAgenda.N_mantenimiento_agenda(agenda);
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void Registrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas registrar esta agenda?", "Mensaje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                mantenimiento("1");
                limpiar();
            }
        }

        private void FrmGestionAgenda_Load(object sender, EventArgs e)
        {
            dataGridViewAgenda.DataSource = logicaAgenda.N_listar_agenda();
        }
    }
}
