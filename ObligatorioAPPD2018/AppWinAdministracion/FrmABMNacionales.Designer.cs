namespace AppWinAdministracion
{
    partial class FrmABMNacionales
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
            this.LblNumero = new System.Windows.Forms.Label();
            this.LblCompania = new System.Windows.Forms.Label();
            this.LblTerminal = new System.Windows.Forms.Label();
            this.TBNumero = new System.Windows.Forms.TextBox();
            this.EPTel = new System.Windows.Forms.ErrorProvider(this.components);
            this.CBCompania = new System.Windows.Forms.ComboBox();
            this.CBTerminal = new System.Windows.Forms.ComboBox();
            this.LblAsientos = new System.Windows.Forms.Label();
            this.TBAsientos = new System.Windows.Forms.TextBox();
            this.LblParadas = new System.Windows.Forms.Label();
            this.TBParadas = new System.Windows.Forms.TextBox();
            this.DTPFechaPartida = new System.Windows.Forms.DateTimePicker();
            this.CBHoraPartida = new System.Windows.Forms.ComboBox();
            this.CBMinutosPartida = new System.Windows.Forms.ComboBox();
            this.LblFechaPartida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblHoraPartida = new System.Windows.Forms.Label();
            this.LblHoraArribo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblFechaArribo = new System.Windows.Forms.Label();
            this.CBMinutosArribo = new System.Windows.Forms.ComboBox();
            this.CBHoraArribo = new System.Windows.Forms.ComboBox();
            this.DTPFechaArribo = new System.Windows.Forms.DateTimePicker();
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
            this.BarraDeEstado.Location = new System.Drawing.Point(0, 234);
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
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Location = new System.Drawing.Point(35, 62);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(47, 13);
            this.LblNumero.TabIndex = 1;
            this.LblNumero.Text = "Número:";
            // 
            // LblCompania
            // 
            this.LblCompania.AutoSize = true;
            this.LblCompania.Location = new System.Drawing.Point(35, 92);
            this.LblCompania.Name = "LblCompania";
            this.LblCompania.Size = new System.Drawing.Size(59, 13);
            this.LblCompania.TabIndex = 1;
            this.LblCompania.Text = "Compañía:";
            // 
            // LblTerminal
            // 
            this.LblTerminal.AutoSize = true;
            this.LblTerminal.Location = new System.Drawing.Point(35, 126);
            this.LblTerminal.Name = "LblTerminal";
            this.LblTerminal.Size = new System.Drawing.Size(50, 13);
            this.LblTerminal.TabIndex = 1;
            this.LblTerminal.Text = "Terminal:";
            // 
            // TBNumero
            // 
            this.TBNumero.Location = new System.Drawing.Point(111, 59);
            this.TBNumero.MaxLength = 3;
            this.TBNumero.Name = "TBNumero";
            this.TBNumero.Size = new System.Drawing.Size(172, 20);
            this.TBNumero.TabIndex = 2;
            this.TBNumero.Validating += new System.ComponentModel.CancelEventHandler(this.TBNumero_Validating);
            // 
            // EPTel
            // 
            this.EPTel.ContainerControl = this;
            // 
            // CBCompania
            // 
            this.CBCompania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCompania.Enabled = false;
            this.CBCompania.FormattingEnabled = true;
            this.CBCompania.Location = new System.Drawing.Point(111, 89);
            this.CBCompania.Name = "CBCompania";
            this.CBCompania.Size = new System.Drawing.Size(172, 21);
            this.CBCompania.TabIndex = 3;
            // 
            // CBTerminal
            // 
            this.CBTerminal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTerminal.FormattingEnabled = true;
            this.CBTerminal.Location = new System.Drawing.Point(111, 121);
            this.CBTerminal.Name = "CBTerminal";
            this.CBTerminal.Size = new System.Drawing.Size(172, 21);
            this.CBTerminal.TabIndex = 9;
            // 
            // LblAsientos
            // 
            this.LblAsientos.Location = new System.Drawing.Point(36, 156);
            this.LblAsientos.Name = "LblAsientos";
            this.LblAsientos.Size = new System.Drawing.Size(67, 31);
            this.LblAsientos.TabIndex = 10;
            this.LblAsientos.Text = "Cantidad de Asientos: ";
            // 
            // TBAsientos
            // 
            this.TBAsientos.Location = new System.Drawing.Point(111, 160);
            this.TBAsientos.Name = "TBAsientos";
            this.TBAsientos.Size = new System.Drawing.Size(172, 20);
            this.TBAsientos.TabIndex = 11;
            // 
            // LblParadas
            // 
            this.LblParadas.AutoSize = true;
            this.LblParadas.Location = new System.Drawing.Point(38, 200);
            this.LblParadas.Name = "LblParadas";
            this.LblParadas.Size = new System.Drawing.Size(52, 13);
            this.LblParadas.TabIndex = 12;
            this.LblParadas.Text = "Paradas: ";
            // 
            // TBParadas
            // 
            this.TBParadas.Location = new System.Drawing.Point(111, 200);
            this.TBParadas.Name = "TBParadas";
            this.TBParadas.Size = new System.Drawing.Size(172, 20);
            this.TBParadas.TabIndex = 13;
            // 
            // DTPFechaPartida
            // 
            this.DTPFechaPartida.Location = new System.Drawing.Point(484, 59);
            this.DTPFechaPartida.Name = "DTPFechaPartida";
            this.DTPFechaPartida.Size = new System.Drawing.Size(200, 20);
            this.DTPFechaPartida.TabIndex = 14;
            // 
            // CBHoraPartida
            // 
            this.CBHoraPartida.FormattingEnabled = true;
            this.CBHoraPartida.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.CBHoraPartida.Location = new System.Drawing.Point(484, 88);
            this.CBHoraPartida.Name = "CBHoraPartida";
            this.CBHoraPartida.Size = new System.Drawing.Size(62, 21);
            this.CBHoraPartida.TabIndex = 15;
            // 
            // CBMinutosPartida
            // 
            this.CBMinutosPartida.FormattingEnabled = true;
            this.CBMinutosPartida.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.CBMinutosPartida.Location = new System.Drawing.Point(573, 88);
            this.CBMinutosPartida.Name = "CBMinutosPartida";
            this.CBMinutosPartida.Size = new System.Drawing.Size(62, 21);
            this.CBMinutosPartida.TabIndex = 16;
            // 
            // LblFechaPartida
            // 
            this.LblFechaPartida.AutoSize = true;
            this.LblFechaPartida.Location = new System.Drawing.Point(367, 62);
            this.LblFechaPartida.Name = "LblFechaPartida";
            this.LblFechaPartida.Size = new System.Drawing.Size(94, 13);
            this.LblFechaPartida.TabIndex = 17;
            this.LblFechaPartida.Text = "Fecha de Partida: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(552, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = ":";
            // 
            // LblHoraPartida
            // 
            this.LblHoraPartida.AutoSize = true;
            this.LblHoraPartida.Location = new System.Drawing.Point(369, 93);
            this.LblHoraPartida.Name = "LblHoraPartida";
            this.LblHoraPartida.Size = new System.Drawing.Size(87, 13);
            this.LblHoraPartida.TabIndex = 19;
            this.LblHoraPartida.Text = "Hora de Partida: ";
            // 
            // LblHoraArribo
            // 
            this.LblHoraArribo.AutoSize = true;
            this.LblHoraArribo.Location = new System.Drawing.Point(369, 160);
            this.LblHoraArribo.Name = "LblHoraArribo";
            this.LblHoraArribo.Size = new System.Drawing.Size(81, 13);
            this.LblHoraArribo.TabIndex = 25;
            this.LblHoraArribo.Text = "Hora de Arribo: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(552, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = ":";
            // 
            // LblFechaArribo
            // 
            this.LblFechaArribo.AutoSize = true;
            this.LblFechaArribo.Location = new System.Drawing.Point(367, 129);
            this.LblFechaArribo.Name = "LblFechaArribo";
            this.LblFechaArribo.Size = new System.Drawing.Size(88, 13);
            this.LblFechaArribo.TabIndex = 23;
            this.LblFechaArribo.Text = "Fecha de Arribo: ";
            // 
            // CBMinutosArribo
            // 
            this.CBMinutosArribo.FormattingEnabled = true;
            this.CBMinutosArribo.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.CBMinutosArribo.Location = new System.Drawing.Point(573, 155);
            this.CBMinutosArribo.Name = "CBMinutosArribo";
            this.CBMinutosArribo.Size = new System.Drawing.Size(62, 21);
            this.CBMinutosArribo.TabIndex = 22;
            // 
            // CBHoraArribo
            // 
            this.CBHoraArribo.FormattingEnabled = true;
            this.CBHoraArribo.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.CBHoraArribo.Location = new System.Drawing.Point(484, 155);
            this.CBHoraArribo.Name = "CBHoraArribo";
            this.CBHoraArribo.Size = new System.Drawing.Size(62, 21);
            this.CBHoraArribo.TabIndex = 21;
            // 
            // DTPFechaArribo
            // 
            this.DTPFechaArribo.Location = new System.Drawing.Point(484, 126);
            this.DTPFechaArribo.Name = "DTPFechaArribo";
            this.DTPFechaArribo.Size = new System.Drawing.Size(200, 20);
            this.DTPFechaArribo.TabIndex = 20;
            // 
            // FrmABMNacionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 256);
            this.Controls.Add(this.LblHoraArribo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblFechaArribo);
            this.Controls.Add(this.CBMinutosArribo);
            this.Controls.Add(this.CBHoraArribo);
            this.Controls.Add(this.DTPFechaArribo);
            this.Controls.Add(this.LblHoraPartida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblFechaPartida);
            this.Controls.Add(this.CBMinutosPartida);
            this.Controls.Add(this.CBHoraPartida);
            this.Controls.Add(this.DTPFechaPartida);
            this.Controls.Add(this.TBParadas);
            this.Controls.Add(this.LblParadas);
            this.Controls.Add(this.TBAsientos);
            this.Controls.Add(this.LblAsientos);
            this.Controls.Add(this.CBTerminal);
            this.Controls.Add(this.CBCompania);
            this.Controls.Add(this.TBNumero);
            this.Controls.Add(this.LblTerminal);
            this.Controls.Add(this.LblCompania);
            this.Controls.Add(this.LblNumero);
            this.Controls.Add(this.BarraDeEstado);
            this.Controls.Add(this.BarraDeHerramientas);
            this.Name = "FrmABMNacionales";
            this.Text = "Mantenimiento de Viajes Nacionales";
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
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.Label LblCompania;
        private System.Windows.Forms.Label LblTerminal;
        private System.Windows.Forms.TextBox TBNumero;
        private System.Windows.Forms.ErrorProvider EPTel;
        private System.Windows.Forms.ComboBox CBCompania;
        private System.Windows.Forms.DateTimePicker DTPFechaPartida;
        private System.Windows.Forms.TextBox TBParadas;
        private System.Windows.Forms.Label LblParadas;
        private System.Windows.Forms.TextBox TBAsientos;
        private System.Windows.Forms.Label LblAsientos;
        private System.Windows.Forms.ComboBox CBTerminal;
        private System.Windows.Forms.Label LblFechaPartida;
        private System.Windows.Forms.ComboBox CBMinutosPartida;
        private System.Windows.Forms.ComboBox CBHoraPartida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblHoraArribo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblFechaArribo;
        private System.Windows.Forms.ComboBox CBMinutosArribo;
        private System.Windows.Forms.ComboBox CBHoraArribo;
        private System.Windows.Forms.DateTimePicker DTPFechaArribo;
        private System.Windows.Forms.Label LblHoraPartida;
    }
}