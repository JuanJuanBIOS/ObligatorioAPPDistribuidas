namespace AppWinAdministracion
{
    partial class FrmPrincipal
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
            this.BtnABMNacionales = new System.Windows.Forms.Button();
            this.BtnABMTerminales = new System.Windows.Forms.Button();
            this.BtnABMCompanias = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.BtnABMInternacionales = new System.Windows.Forms.Button();
            this.BtnABMEmpleados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnABMNacionales
            // 
            this.BtnABMNacionales.Location = new System.Drawing.Point(25, 129);
            this.BtnABMNacionales.Name = "BtnABMNacionales";
            this.BtnABMNacionales.Size = new System.Drawing.Size(176, 43);
            this.BtnABMNacionales.TabIndex = 3;
            this.BtnABMNacionales.Text = "Mantenimiento de Viajes Nacionales";
            this.BtnABMNacionales.UseVisualStyleBackColor = true;
            this.BtnABMNacionales.Click += new System.EventHandler(this.BtnABMNacionales_Click);
            // 
            // BtnABMTerminales
            // 
            this.BtnABMTerminales.Location = new System.Drawing.Point(25, 84);
            this.BtnABMTerminales.Name = "BtnABMTerminales";
            this.BtnABMTerminales.Size = new System.Drawing.Size(176, 23);
            this.BtnABMTerminales.TabIndex = 2;
            this.BtnABMTerminales.Text = "Mantenimiento de Terminales";
            this.BtnABMTerminales.UseVisualStyleBackColor = true;
            this.BtnABMTerminales.Click += new System.EventHandler(this.BtnABMTerminales_Click);
            // 
            // BtnABMCompanias
            // 
            this.BtnABMCompanias.Location = new System.Drawing.Point(25, 42);
            this.BtnABMCompanias.Name = "BtnABMCompanias";
            this.BtnABMCompanias.Size = new System.Drawing.Size(176, 23);
            this.BtnABMCompanias.TabIndex = 1;
            this.BtnABMCompanias.Text = "Mantenimiento de Companías";
            this.BtnABMCompanias.UseVisualStyleBackColor = true;
            this.BtnABMCompanias.Click += new System.EventHandler(this.BtnABMCompanias_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 309);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(237, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // BtnABMInternacionales
            // 
            this.BtnABMInternacionales.Location = new System.Drawing.Point(25, 191);
            this.BtnABMInternacionales.Name = "BtnABMInternacionales";
            this.BtnABMInternacionales.Size = new System.Drawing.Size(176, 43);
            this.BtnABMInternacionales.TabIndex = 4;
            this.BtnABMInternacionales.Text = "Mantenimiento de Viajes Internacionales";
            this.BtnABMInternacionales.UseVisualStyleBackColor = true;
            this.BtnABMInternacionales.Click += new System.EventHandler(this.BtnABMInternacionales_Click);
            // 
            // BtnABMEmpleados
            // 
            this.BtnABMEmpleados.Location = new System.Drawing.Point(25, 256);
            this.BtnABMEmpleados.Name = "BtnABMEmpleados";
            this.BtnABMEmpleados.Size = new System.Drawing.Size(176, 29);
            this.BtnABMEmpleados.TabIndex = 5;
            this.BtnABMEmpleados.Text = "Mantenimiento de Empleados";
            this.BtnABMEmpleados.UseVisualStyleBackColor = true;
            this.BtnABMEmpleados.Click += new System.EventHandler(this.BtnABMEmpleados_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 331);
            this.Controls.Add(this.BtnABMEmpleados);
            this.Controls.Add(this.BtnABMInternacionales);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BtnABMCompanias);
            this.Controls.Add(this.BtnABMTerminales);
            this.Controls.Add(this.BtnABMNacionales);
            this.Name = "FrmPrincipal";
            this.Text = "Terminales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnABMNacionales;
        private System.Windows.Forms.Button BtnABMTerminales;
        private System.Windows.Forms.Button BtnABMCompanias;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button BtnABMInternacionales;
        private System.Windows.Forms.Button BtnABMEmpleados;

    }
}