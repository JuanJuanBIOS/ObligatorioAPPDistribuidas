namespace AppWinAdministracion
{
    partial class FrmABMTerminales
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
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblPais = new System.Windows.Forms.Label();
            this.LblCiudad = new System.Windows.Forms.Label();
            this.TBCodigo = new System.Windows.Forms.TextBox();
            this.TBCiudad = new System.Windows.Forms.TextBox();
            this.EPTel = new System.Windows.Forms.ErrorProvider(this.components);
            this.CBPais = new System.Windows.Forms.ComboBox();
            this.TBFacilidad = new System.Windows.Forms.TextBox();
            this.LblFacilidades = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnQuitar = new System.Windows.Forms.Button();
            this.LBFacilidades = new System.Windows.Forms.ListBox();
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
            this.BarraDeHerramientas.Size = new System.Drawing.Size(816, 25);
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
            this.BarraDeEstado.Size = new System.Drawing.Size(816, 22);
            this.BarraDeEstado.TabIndex = 1;
            this.BarraDeEstado.Text = "statusStrip1";
            // 
            // LblError
            // 
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 17);
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Location = new System.Drawing.Point(35, 62);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(43, 13);
            this.LblCodigo.TabIndex = 1;
            this.LblCodigo.Text = "Código:";
            // 
            // LblPais
            // 
            this.LblPais.AutoSize = true;
            this.LblPais.Location = new System.Drawing.Point(35, 92);
            this.LblPais.Name = "LblPais";
            this.LblPais.Size = new System.Drawing.Size(32, 13);
            this.LblPais.TabIndex = 1;
            this.LblPais.Text = "País:";
            // 
            // LblCiudad
            // 
            this.LblCiudad.AutoSize = true;
            this.LblCiudad.Location = new System.Drawing.Point(35, 121);
            this.LblCiudad.Name = "LblCiudad";
            this.LblCiudad.Size = new System.Drawing.Size(43, 13);
            this.LblCiudad.TabIndex = 1;
            this.LblCiudad.Text = "Ciudad:";
            // 
            // TBCodigo
            // 
            this.TBCodigo.Location = new System.Drawing.Point(111, 59);
            this.TBCodigo.MaxLength = 3;
            this.TBCodigo.Name = "TBCodigo";
            this.TBCodigo.Size = new System.Drawing.Size(172, 20);
            this.TBCodigo.TabIndex = 2;
            this.TBCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.TBCodigo_Validating);
            // 
            // TBCiudad
            // 
            this.TBCiudad.Enabled = false;
            this.TBCiudad.Location = new System.Drawing.Point(111, 118);
            this.TBCiudad.MaxLength = 50;
            this.TBCiudad.Name = "TBCiudad";
            this.TBCiudad.Size = new System.Drawing.Size(172, 20);
            this.TBCiudad.TabIndex = 4;
            // 
            // EPTel
            // 
            this.EPTel.ContainerControl = this;
            // 
            // CBPais
            // 
            this.CBPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPais.Enabled = false;
            this.CBPais.FormattingEnabled = true;
            this.CBPais.Items.AddRange(new object[] {
            "Argentina",
            "Brasil",
            "Paraguay",
            "Uruguay"});
            this.CBPais.Location = new System.Drawing.Point(111, 89);
            this.CBPais.Name = "CBPais";
            this.CBPais.Size = new System.Drawing.Size(172, 21);
            this.CBPais.TabIndex = 3;
            // 
            // TBFacilidad
            // 
            this.TBFacilidad.Enabled = false;
            this.TBFacilidad.Location = new System.Drawing.Point(348, 85);
            this.TBFacilidad.MaxLength = 50;
            this.TBFacilidad.Name = "TBFacilidad";
            this.TBFacilidad.Size = new System.Drawing.Size(173, 20);
            this.TBFacilidad.TabIndex = 5;
            // 
            // LblFacilidades
            // 
            this.LblFacilidades.AutoSize = true;
            this.LblFacilidades.Location = new System.Drawing.Point(348, 61);
            this.LblFacilidades.Name = "LblFacilidades";
            this.LblFacilidades.Size = new System.Drawing.Size(66, 13);
            this.LblFacilidades.TabIndex = 1;
            this.LblFacilidades.Text = "Facilidades: ";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Enabled = false;
            this.BtnAgregar.Location = new System.Drawing.Point(348, 121);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 6;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnQuitar
            // 
            this.BtnQuitar.Enabled = false;
            this.BtnQuitar.Location = new System.Drawing.Point(446, 121);
            this.BtnQuitar.Name = "BtnQuitar";
            this.BtnQuitar.Size = new System.Drawing.Size(75, 23);
            this.BtnQuitar.TabIndex = 7;
            this.BtnQuitar.Text = "Quitar";
            this.BtnQuitar.UseVisualStyleBackColor = true;
            this.BtnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // LBFacilidades
            // 
            this.LBFacilidades.FormattingEnabled = true;
            this.LBFacilidades.Location = new System.Drawing.Point(544, 59);
            this.LBFacilidades.Name = "LBFacilidades";
            this.LBFacilidades.Size = new System.Drawing.Size(241, 134);
            this.LBFacilidades.TabIndex = 8;
            // 
            // FrmABMTerminales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 231);
            this.Controls.Add(this.LBFacilidades);
            this.Controls.Add(this.BtnQuitar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.LblFacilidades);
            this.Controls.Add(this.TBFacilidad);
            this.Controls.Add(this.CBPais);
            this.Controls.Add(this.TBCiudad);
            this.Controls.Add(this.TBCodigo);
            this.Controls.Add(this.LblCiudad);
            this.Controls.Add(this.LblPais);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.BarraDeEstado);
            this.Controls.Add(this.BarraDeHerramientas);
            this.Name = "FrmABMTerminales";
            this.Text = "Mantenimiento de Terminales";
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
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblPais;
        private System.Windows.Forms.Label LblCiudad;
        private System.Windows.Forms.TextBox TBCodigo;
        private System.Windows.Forms.TextBox TBCiudad;
        private System.Windows.Forms.ErrorProvider EPTel;
        private System.Windows.Forms.ComboBox CBPais;
        private System.Windows.Forms.Button BtnQuitar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label LblFacilidades;
        private System.Windows.Forms.TextBox TBFacilidad;
        private System.Windows.Forms.ListBox LBFacilidades;
    }
}