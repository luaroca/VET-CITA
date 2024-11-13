namespace GUI
{
    partial class FrmGestionServicio
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridViewServicio = new System.Windows.Forms.DataGridView();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(810, 156);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(810, 199);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(810, 258);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dataGridViewServicio
            // 
            this.dataGridViewServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServicio.Location = new System.Drawing.Point(12, 94);
            this.dataGridViewServicio.Name = "dataGridViewServicio";
            this.dataGridViewServicio.RowHeadersWidth = 51;
            this.dataGridViewServicio.RowTemplate.Height = 24;
            this.dataGridViewServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewServicio.Size = new System.Drawing.Size(424, 248);
            this.dataGridViewServicio.TabIndex = 3;
            this.dataGridViewServicio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewServicio_CellContentClick);
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.Location = new System.Drawing.Point(626, 171);
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(134, 22);
            this.txtNombreServicio.TabIndex = 4;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(626, 210);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(134, 22);
            this.txtPrecio.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre Del Servicio";
            // 
            // FrmGestionServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 566);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombreServicio);
            this.Controls.Add(this.dataGridViewServicio);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "FrmGestionServicio";
            this.Text = "FrmGestionServicio";
            this.Load += new System.EventHandler(this.FrmGestionServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dataGridViewServicio;
        private System.Windows.Forms.TextBox txtNombreServicio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}