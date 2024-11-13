﻿namespace GUI
{
    partial class FrmGestionAgenda
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
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.txtID_Veterinario = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dataGridViewAgenda = new System.Windows.Forms.DataGridView();
            this.cmbVeterinario = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(789, 54);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(250, 22);
            this.dtpFecha.TabIndex = 0;
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(789, 108);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(250, 22);
            this.dtpHora.TabIndex = 1;
            // 
            // txtID_Veterinario
            // 
            this.txtID_Veterinario.Location = new System.Drawing.Point(725, 343);
            this.txtID_Veterinario.Name = "txtID_Veterinario";
            this.txtID_Veterinario.Size = new System.Drawing.Size(250, 22);
            this.txtID_Veterinario.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(789, 235);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(250, 23);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // dataGridViewAgenda
            // 
            this.dataGridViewAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgenda.Location = new System.Drawing.Point(34, 76);
            this.dataGridViewAgenda.Name = "dataGridViewAgenda";
            this.dataGridViewAgenda.RowHeadersWidth = 51;
            this.dataGridViewAgenda.RowTemplate.Height = 24;
            this.dataGridViewAgenda.Size = new System.Drawing.Size(634, 274);
            this.dataGridViewAgenda.TabIndex = 4;
            // 
            // cmbVeterinario
            // 
            this.cmbVeterinario.FormattingEnabled = true;
            this.cmbVeterinario.Location = new System.Drawing.Point(789, 177);
            this.cmbVeterinario.Name = "cmbVeterinario";
            this.cmbVeterinario.Size = new System.Drawing.Size(250, 24);
            this.cmbVeterinario.TabIndex = 5;
            // 
            // FrmGestionAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 450);
            this.Controls.Add(this.cmbVeterinario);
            this.Controls.Add(this.dataGridViewAgenda);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtID_Veterinario);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.dtpFecha);
            this.Name = "FrmGestionAgenda";
            this.Text = "FrmGestionAgenda";
            this.Load += new System.EventHandler(this.FrmGestionAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.TextBox txtID_Veterinario;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dataGridViewAgenda;
        private System.Windows.Forms.ComboBox cmbVeterinario;
    }
}