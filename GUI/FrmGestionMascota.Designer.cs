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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dataGridViewMascotas = new System.Windows.Forms.DataGridView();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtCC_Cliente = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMascotas)).BeginInit();
            this.SuspendLayout();
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
            this.btnModificar.Location = new System.Drawing.Point(748, 351);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(149, 53);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(612, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Especie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Raza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(615, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(621, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "CC_Cliente";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(739, 55);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(149, 22);
            this.txtId.TabIndex = 15;
            // 
            // FrmGestionMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 450);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtCC_Cliente);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(this.dataGridViewMascotas);
            this.Controls.Add(this.txtNombre);
            this.Name = "FrmGestionMascota";
            this.Text = "FrmGestionMascota";
            this.Load += new System.EventHandler(this.FrmGestionMascota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMascotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dataGridViewMascotas;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtCC_Cliente;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
    }
}