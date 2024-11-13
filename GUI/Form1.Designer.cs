namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnGestionServicio = new System.Windows.Forms.Button();
            this.btnGestionVeterinario = new System.Windows.Forms.Button();
            this.btnGestionMasco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gestion Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(422, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Agendar Cita";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(433, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Crear Agenda";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnGestionServicio
            // 
            this.btnGestionServicio.Location = new System.Drawing.Point(433, 340);
            this.btnGestionServicio.Name = "btnGestionServicio";
            this.btnGestionServicio.Size = new System.Drawing.Size(131, 23);
            this.btnGestionServicio.TabIndex = 3;
            this.btnGestionServicio.Text = "GestionServicio";
            this.btnGestionServicio.UseVisualStyleBackColor = true;
            this.btnGestionServicio.Click += new System.EventHandler(this.btnGestionServicio_Click);
            // 
            // btnGestionVeterinario
            // 
            this.btnGestionVeterinario.Location = new System.Drawing.Point(422, 151);
            this.btnGestionVeterinario.Name = "btnGestionVeterinario";
            this.btnGestionVeterinario.Size = new System.Drawing.Size(142, 23);
            this.btnGestionVeterinario.TabIndex = 4;
            this.btnGestionVeterinario.Text = "Gestion Veterinario";
            this.btnGestionVeterinario.UseVisualStyleBackColor = true;
            this.btnGestionVeterinario.Click += new System.EventHandler(this.btnGestionVeterinario_Click);
            // 
            // btnGestionMasco
            // 
            this.btnGestionMasco.Location = new System.Drawing.Point(427, 311);
            this.btnGestionMasco.Name = "btnGestionMasco";
            this.btnGestionMasco.Size = new System.Drawing.Size(137, 23);
            this.btnGestionMasco.TabIndex = 5;
            this.btnGestionMasco.Text = "Gestion Mascota";
            this.btnGestionMasco.UseVisualStyleBackColor = true;
            this.btnGestionMasco.Click += new System.EventHandler(this.btnGestionMasco_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGestionMasco);
            this.Controls.Add(this.btnGestionVeterinario);
            this.Controls.Add(this.btnGestionServicio);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnGestionServicio;
        private System.Windows.Forms.Button btnGestionVeterinario;
        private System.Windows.Forms.Button btnGestionMasco;
    }
}

