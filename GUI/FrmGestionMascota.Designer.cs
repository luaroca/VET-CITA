namespace GUI
{
    partial class FrmGestionMascota
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dataGridViewMascotas = new System.Windows.Forms.DataGridView();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtCC_Cliente = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(739, 335);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(155, 40);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(739, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // dataGridViewMascotas
            // 
            this.dataGridViewMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMascotas.Location = new System.Drawing.Point(44, 111);
            this.dataGridViewMascotas.Name = "dataGridViewMascotas";
            this.dataGridViewMascotas.ReadOnly = true;
            this.dataGridViewMascotas.RowHeadersWidth = 51;
            this.dataGridViewMascotas.RowTemplate.Height = 24;
            this.dataGridViewMascotas.Size = new System.Drawing.Size(483, 179);
            this.dataGridViewMascotas.TabIndex = 2;
            this.dataGridViewMascotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMascotas_CellContentClick);
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(739, 127);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(149, 22);
            this.txtEspecie.TabIndex = 3;
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(739, 168);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(149, 22);
            this.txtRaza.TabIndex = 4;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(739, 215);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(149, 22);
            this.txtEdad.TabIndex = 5;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(739, 248);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(149, 22);
            this.txtSexo.TabIndex = 6;
            // 
            // txtCC_Cliente
            // 
            this.txtCC_Cliente.Location = new System.Drawing.Point(739, 294);
            this.txtCC_Cliente.Name = "txtCC_Cliente";
            this.txtCC_Cliente.Size = new System.Drawing.Size(149, 22);
            this.txtCC_Cliente.TabIndex = 7;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(603, 351);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(105, 23);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // FrmGestionMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 450);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtCC_Cliente);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(this.dataGridViewMascotas);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "FrmGestionMascota";
            this.Text = "FrmGestionMascota";
            this.Load += new System.EventHandler(this.FrmGestionMascota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMascotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dataGridViewMascotas;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtCC_Cliente;
        private System.Windows.Forms.Button btnModificar;
    }
}