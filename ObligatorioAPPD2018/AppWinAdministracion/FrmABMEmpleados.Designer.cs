namespace AppWinAdministracion
{
    partial class FrmABMEmpleados
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
            this.components = new System.ComponentModel.Container();
            this.BarraDeHerramientas = new System.Windows.Forms.ToolStrip();
            this.BtnAlta = new System.Windows.Forms.ToolStripButton();
            this.BtnBaja = new System.Windows.Forms.ToolStripButton();
            this.BtnModificar = new System.Windows.Forms.ToolStripButton();
            this.BtnDeshacer = new System.Windows.Forms.ToolStripButton();
            this.BarraDeEstado = new System.Windows.Forms.StatusStrip();
            this.LblError = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblCedula = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblPass = new System.Windows.Forms.Label();
            this.TBCedula = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.EPTel = new System.Windows.Forms.ErrorProvider(this.components);
            this.BarraDeHerramientas.SuspendLayout();
            this.BarraDeEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPTel)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraDeHerramientas
            // 
            this.BarraDeHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAlta,
            this.BtnBaja,
            this.BtnModificar,
            this.BtnDeshacer});
            this.BarraDeHerramientas.Location = new System.Drawing.Point(0, 0);
            this.BarraDeHerramientas.Name = "BarraDeHerramientas";
            this.BarraDeHerramientas.Size = new System.Drawing.Size(369, 25);
            this.BarraDeHerramientas.TabIndex = 0;
            this.BarraDeHerramientas.Text = "toolStrip1";
            // 
            // BtnAlta
            // 
            this.BtnAlta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAlta.Enabled = false;
            this.BtnAlta.Image = global::AppWinAdministracion.Properties.Resources.nuevo;
            this.BtnAlta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAlta.Name = "BtnAlta";
            this.BtnAlta.Size = new System.Drawing.Size(23, 22);
            this.BtnAlta.Text = "toolStripButton1";
            this.BtnAlta.ToolTipText = "Alta";
            this.BtnAlta.Click += new System.EventHandler(this.BtnAlta_Click);
            // 
            // BtnBaja
            // 
            this.BtnBaja.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnBaja.Enabled = false;
            this.BtnBaja.Image = global::AppWinAdministracion.Properties.Resources.eliminar;
            this.BtnBaja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnBaja.Name = "BtnBaja";
            this.BtnBaja.Size = new System.Drawing.Size(23, 22);
            this.BtnBaja.Text = "toolStripButton2";
            this.BtnBaja.ToolTipText = "Eliminar";
            this.BtnBaja.Click += new System.EventHandler(this.BtnBaja_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnModificar.Enabled = false;
            this.BtnModificar.Image = global::AppWinAdministracion.Properties.Resources.modificar;
            this.BtnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(23, 22);
            this.BtnModificar.Text = "toolStripButton3";
            this.BtnModificar.ToolTipText = "Modificar";
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnDeshacer
            // 
            this.BtnDeshacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDeshacer.Image = global::AppWinAdministracion.Properties.Resources.cancelar;
            this.BtnDeshacer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDeshacer.Name = "BtnDeshacer";
            this.BtnDeshacer.Size = new System.Drawing.Size(23, 22);
            this.BtnDeshacer.Text = "toolStripButton4";
            this.BtnDeshacer.ToolTipText = "Deshacer";
            this.BtnDeshacer.Click += new System.EventHandler(this.BtnDeshacer_Click);
            // 
            // BarraDeEstado
            // 
            this.BarraDeEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblError});
            this.BarraDeEstado.Location = new System.Drawing.Point(0, 209);
            this.BarraDeEstado.Name = "BarraDeEstado";
            this.BarraDeEstado.Size = new System.Drawing.Size(369, 22);
            this.BarraDeEstado.TabIndex = 1;
            this.BarraDeEstado.Text = "statusStrip1";
            // 
            // LblError
            // 
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 17);
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.Location = new System.Drawing.Point(35, 62);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(46, 13);
            this.LblCedula.TabIndex = 2;
            this.LblCedula.Text = "Cédula :";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(35, 92);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(47, 13);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblPass
            // 
            this.LblPass.AutoSize = true;
            this.LblPass.Location = new System.Drawing.Point(35, 121);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(64, 13);
            this.LblPass.TabIndex = 2;
            this.LblPass.Text = "Contraseña:";
            // 
            // TBCedula
            // 
            this.TBCedula.Location = new System.Drawing.Point(111, 59);
            this.TBCedula.Name = "TBCedula";
            this.TBCedula.Size = new System.Drawing.Size(172, 20);
            this.TBCedula.TabIndex = 3;
            this.TBCedula.Validating += new System.ComponentModel.CancelEventHandler(this.TBCedula_Validating);
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(111, 89);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(172, 20);
            this.TBNombre.TabIndex = 4;
            // 
            // TBPass
            // 
            this.TBPass.Enabled = false;
            this.TBPass.Location = new System.Drawing.Point(111, 118);
            this.TBPass.MaxLength = 6;
            this.TBPass.Name = "TBPass";
            this.TBPass.Size = new System.Drawing.Size(172, 20);
            this.TBPass.TabIndex = 5;
            this.TBPass.UseSystemPasswordChar = true;
            // 
            // EPTel
            // 
            this.EPTel.ContainerControl = this;
            // 
            // FrmABMEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 231);
            this.Controls.Add(this.TBPass);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.TBCedula);
            this.Controls.Add(this.LblPass);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblCedula);
            this.Controls.Add(this.BarraDeEstado);
            this.Controls.Add(this.BarraDeHerramientas);
            this.Name = "FrmABMEmpleados";
            this.Text = "Mantenimiento de Empleados";
            this.BarraDeHerramientas.ResumeLayout(false);
            this.BarraDeHerramientas.PerformLayout();
            this.BarraDeEstado.ResumeLayout(false);
            this.BarraDeEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPTel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip BarraDeHerramientas;
        private System.Windows.Forms.ToolStripButton BtnAlta;
        private System.Windows.Forms.ToolStripButton BtnBaja;
        private System.Windows.Forms.ToolStripButton BtnModificar;
        private System.Windows.Forms.ToolStripButton BtnDeshacer;
        private System.Windows.Forms.StatusStrip BarraDeEstado;
        private System.Windows.Forms.ToolStripStatusLabel LblError;
        private System.Windows.Forms.Label LblCedula;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblPass;
        private System.Windows.Forms.TextBox TBCedula;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.ErrorProvider EPTel;
    }
}