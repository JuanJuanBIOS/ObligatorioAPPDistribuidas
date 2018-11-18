namespace AppWinAdministracion
{
    partial class FrmABMCompanias
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
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblTel = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBDireccion = new System.Windows.Forms.TextBox();
            this.TBTel = new System.Windows.Forms.TextBox();
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
            this.BarraDeHerramientas.Size = new System.Drawing.Size(487, 25);
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
            this.BarraDeEstado.Size = new System.Drawing.Size(487, 22);
            this.BarraDeEstado.TabIndex = 1;
            this.BarraDeEstado.Text = "statusStrip1";
            // 
            // LblError
            // 
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 17);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(35, 62);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(47, 13);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Location = new System.Drawing.Point(35, 92);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(55, 13);
            this.LblDireccion.TabIndex = 2;
            this.LblDireccion.Text = "Dirección:";
            // 
            // LblTel
            // 
            this.LblTel.AutoSize = true;
            this.LblTel.Location = new System.Drawing.Point(35, 121);
            this.LblTel.Name = "LblTel";
            this.LblTel.Size = new System.Drawing.Size(52, 13);
            this.LblTel.TabIndex = 2;
            this.LblTel.Text = "Teléfono:";
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(111, 59);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(172, 20);
            this.TBNombre.TabIndex = 3;
            this.TBNombre.Validating += new System.ComponentModel.CancelEventHandler(this.TBNombre_Validating);
            // 
            // TBDireccion
            // 
            this.TBDireccion.Location = new System.Drawing.Point(111, 89);
            this.TBDireccion.Name = "TBDireccion";
            this.TBDireccion.Size = new System.Drawing.Size(172, 20);
            this.TBDireccion.TabIndex = 4;
            // 
            // TBTel
            // 
            this.TBTel.Enabled = false;
            this.TBTel.Location = new System.Drawing.Point(111, 118);
            this.TBTel.Name = "TBTel";
            this.TBTel.Size = new System.Drawing.Size(172, 20);
            this.TBTel.TabIndex = 5;
            this.TBTel.Validating += new System.ComponentModel.CancelEventHandler(this.TBTel_Validating);
            // 
            // EPTel
            // 
            this.EPTel.ContainerControl = this;
            // 
            // FrmABMCompanias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 231);
            this.Controls.Add(this.TBTel);
            this.Controls.Add(this.TBDireccion);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.LblTel);
            this.Controls.Add(this.LblDireccion);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.BarraDeEstado);
            this.Controls.Add(this.BarraDeHerramientas);
            this.Name = "FrmABMCompanias";
            this.Text = "Mantenimiento de Companías";
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
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblTel;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBDireccion;
        private System.Windows.Forms.TextBox TBTel;
        private System.Windows.Forms.ErrorProvider EPTel;
    }
}