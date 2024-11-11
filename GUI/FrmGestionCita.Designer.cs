namespace GUI
{
    partial class FrmGestionCita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewCitas = new System.Windows.Forms.DataGridView();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtID_Mascota = new System.Windows.Forms.TextBox();
            this.txtID_Veterinario = new System.Windows.Forms.TextBox();
            this.txtID_Servicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtID_Cita = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtID_Servicios = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(109, 26);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(285, 22);
            this.dtpFecha.TabIndex = 0;
            // 
            // dataGridViewCitas
            // 
            this.dataGridViewCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCitas.Location = new System.Drawing.Point(12, 170);
            this.dataGridViewCitas.Name = "dataGridViewCitas";
            this.dataGridViewCitas.ReadOnly = true;
            this.dataGridViewCitas.RowHeadersWidth = 51;
            this.dataGridViewCitas.RowTemplate.Height = 24;
            this.dataGridViewCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCitas.Size = new System.Drawing.Size(531, 359);
            this.dataGridViewCitas.TabIndex = 1;
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(109, 74);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(285, 22);
            this.dtpHora.TabIndex = 2;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(569, 48);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 22);
            this.txtEstado.TabIndex = 3;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(569, 93);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 22);
            this.txtCosto.TabIndex = 4;
            // 
            // txtID_Mascota
            // 
            this.txtID_Mascota.Location = new System.Drawing.Point(569, 149);
            this.txtID_Mascota.Name = "txtID_Mascota";
            this.txtID_Mascota.Size = new System.Drawing.Size(100, 22);
            this.txtID_Mascota.TabIndex = 5;
            // 
            // txtID_Veterinario
            // 
            this.txtID_Veterinario.Location = new System.Drawing.Point(569, 201);
            this.txtID_Veterinario.Name = "txtID_Veterinario";
            this.txtID_Veterinario.Size = new System.Drawing.Size(100, 22);
            this.txtID_Veterinario.TabIndex = 6;
            // 
            // txtID_Servicio
            // 
            this.txtID_Servicio.Location = new System.Drawing.Point(569, 253);
            this.txtID_Servicio.Name = "txtID_Servicio";
            this.txtID_Servicio.Size = new System.Drawing.Size(100, 22);
            this.txtID_Servicio.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(716, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(719, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Costo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(719, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID Mascota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(719, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID_Veterinario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(719, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID_Servicio";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(955, 141);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(92, 50);
            this.btnRegistrar.TabIndex = 13;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtID_Cita
            // 
            this.txtID_Cita.Location = new System.Drawing.Point(569, 303);
            this.txtID_Cita.Name = "txtID_Cita";
            this.txtID_Cita.Size = new System.Drawing.Size(100, 22);
            this.txtID_Cita.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(722, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "ID_CITA";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "PENDIENTE",
            "CANCELADA",
            "AUTORIZADA"});
            this.cmbEstado.Location = new System.Drawing.Point(905, 58);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 24);
            this.cmbEstado.TabIndex = 16;
            // 
            // txtID_Servicios
            // 
            this.txtID_Servicios.FormattingEnabled = true;
            this.txtID_Servicios.Items.AddRange(new object[] {
            "Consulta General"});
            this.txtID_Servicios.Location = new System.Drawing.Point(905, 98);
            this.txtID_Servicios.Name = "txtID_Servicios";
            this.txtID_Servicios.Size = new System.Drawing.Size(121, 24);
            this.txtID_Servicios.TabIndex = 17;
            // 
            // FrmGestionCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 552);
            this.Controls.Add(this.txtID_Servicios);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtID_Cita);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID_Servicio);
            this.Controls.Add(this.txtID_Veterinario);
            this.Controls.Add(this.txtID_Mascota);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.dataGridViewCitas);
            this.Controls.Add(this.dtpFecha);
            this.Name = "FrmGestionCita";
            this.Text = "FrmGestionCita";
            this.Load += new System.EventHandler(this.FrmGestionCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dataGridViewCitas;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtID_Mascota;
        private System.Windows.Forms.TextBox txtID_Veterinario;
        private System.Windows.Forms.TextBox txtID_Servicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtID_Cita;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox txtID_Servicios;
    }
}