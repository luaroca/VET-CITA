namespace GUI
{
    partial class FrmGestionVeterinario
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
            this.txtID_Veterinario = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.Cedula = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewVeterinario = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeterinario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID_Veterinario
            // 
            this.txtID_Veterinario.Location = new System.Drawing.Point(612, 75);
            this.txtID_Veterinario.Name = "txtID_Veterinario";
            this.txtID_Veterinario.Size = new System.Drawing.Size(100, 22);
            this.txtID_Veterinario.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(612, 134);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(612, 188);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(100, 22);
            this.txtEspecialidad.TabIndex = 2;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(612, 244);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 22);
            this.txtTelefono.TabIndex = 3;
            // 
            // Cedula
            // 
            this.Cedula.AutoSize = true;
            this.Cedula.Location = new System.Drawing.Point(505, 81);
            this.Cedula.Name = "Cedula";
            this.Cedula.Size = new System.Drawing.Size(50, 16);
            this.Cedula.TabIndex = 4;
            this.Cedula.Text = "Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Especialidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefono";
            // 
            // dataGridViewVeterinario
            // 
            this.dataGridViewVeterinario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVeterinario.Location = new System.Drawing.Point(12, 108);
            this.dataGridViewVeterinario.Name = "dataGridViewVeterinario";
            this.dataGridViewVeterinario.ReadOnly = true;
            this.dataGridViewVeterinario.RowHeadersWidth = 51;
            this.dataGridViewVeterinario.RowTemplate.Height = 24;
            this.dataGridViewVeterinario.Size = new System.Drawing.Size(434, 150);
            this.dataGridViewVeterinario.TabIndex = 8;
            this.dataGridViewVeterinario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVeterinario_CellContentClick);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(777, 73);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(777, 132);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(777, 194);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmGestionVeterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dataGridViewVeterinario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cedula);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID_Veterinario);
            this.Name = "FrmGestionVeterinario";
            this.Text = "FrmGestionVeterinario";
            this.Load += new System.EventHandler(this.FrmGestionVeterinario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeterinario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID_Veterinario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label Cedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewVeterinario;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}