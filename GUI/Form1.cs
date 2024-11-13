﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGestionCliente frmGestionCliente = new FrmGestionCliente();
            frmGestionCliente.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGestionCita frmGestionCita = new FrmGestionCita();
            frmGestionCita.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmGestionAgenda frmGestionAgenda = new FrmGestionAgenda();
            frmGestionAgenda.ShowDialog();
        }

        private void btnGestionServicio_Click(object sender, EventArgs e)
        {
            FrmGestionServicio frmGestionServicio = new FrmGestionServicio();
            frmGestionServicio.ShowDialog();
        }

        private void btnGestionVeterinario_Click(object sender, EventArgs e)
        {
            FrmGestionVeterinario gestionVeterinario = new FrmGestionVeterinario();
            gestionVeterinario.ShowDialog();
        }

        private void btnGestionMasco_Click(object sender, EventArgs e)
        {
            FrmGestionMascota frmGestionMascota = new FrmGestionMascota();
            frmGestionMascota.ShowDialog();
        }
    }
}
