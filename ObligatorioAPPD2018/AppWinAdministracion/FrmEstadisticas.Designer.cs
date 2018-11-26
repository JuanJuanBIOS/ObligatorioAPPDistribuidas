namespace AppWinAdministracion
{
    partial class FrmEstadisticas
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
            this.DGVViajes = new System.Windows.Forms.DataGridView();
            this.DTPDesde = new System.Windows.Forms.DateTimePicker();
            this.DTPHasta = new System.Windows.Forms.DateTimePicker();
            this.LBDesde = new System.Windows.Forms.Label();
            this.LBHasta = new System.Windows.Forms.Label();
            this.LBPais = new System.Windows.Forms.Label();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.LBViajes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVViajesCompania = new System.Windows.Forms.DataGridView();
            this.BTNLimpiar = new System.Windows.Forms.Button();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVViajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVViajesCompania)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVViajes
            // 
            this.DGVViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVViajes.Location = new System.Drawing.Point(16, 126);
            this.DGVViajes.Name = "DGVViajes";
            this.DGVViajes.Size = new System.Drawing.Size(902, 179);
            this.DGVViajes.TabIndex = 0;
            // 
            // DTPDesde
            // 
            this.DTPDesde.Location = new System.Drawing.Point(163, 13);
            this.DTPDesde.Name = "DTPDesde";
            this.DTPDesde.Size = new System.Drawing.Size(200, 20);
            this.DTPDesde.TabIndex = 1;
            // 
            // DTPHasta
            // 
            this.DTPHasta.Location = new System.Drawing.Point(163, 40);
            this.DTPHasta.Name = "DTPHasta";
            this.DTPHasta.Size = new System.Drawing.Size(200, 20);
            this.DTPHasta.TabIndex = 2;
            // 
            // LBDesde
            // 
            this.LBDesde.AutoSize = true;
            this.LBDesde.Location = new System.Drawing.Point(13, 13);
            this.LBDesde.Name = "LBDesde";
            this.LBDesde.Size = new System.Drawing.Size(121, 13);
            this.LBDesde.TabIndex = 3;
            this.LBDesde.Text = "Desde fecha de partida:";
            // 
            // LBHasta
            // 
            this.LBHasta.AutoSize = true;
            this.LBHasta.Location = new System.Drawing.Point(13, 40);
            this.LBHasta.Name = "LBHasta";
            this.LBHasta.Size = new System.Drawing.Size(118, 13);
            this.LBHasta.TabIndex = 4;
            this.LBHasta.Text = "Hasta fecha de partida:";
            // 
            // LBPais
            // 
            this.LBPais.AutoSize = true;
            this.LBPais.Location = new System.Drawing.Point(13, 69);
            this.LBPais.Name = "LBPais";
            this.LBPais.Size = new System.Drawing.Size(84, 13);
            this.LBPais.TabIndex = 5;
            this.LBPais.Text = "País de destino:";
            // 
            // cbPais
            // 
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(163, 69);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(200, 21);
            this.cbPais.TabIndex = 6;
            // 
            // LBViajes
            // 
            this.LBViajes.AutoSize = true;
            this.LBViajes.Location = new System.Drawing.Point(16, 107);
            this.LBViajes.Name = "LBViajes";
            this.LBViajes.Size = new System.Drawing.Size(38, 13);
            this.LBViajes.TabIndex = 7;
            this.LBViajes.Text = "Viajes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Viajes anualmente por companía:";
            // 
            // DGVViajesCompania
            // 
            this.DGVViajesCompania.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVViajesCompania.Location = new System.Drawing.Point(16, 357);
            this.DGVViajesCompania.Name = "DGVViajesCompania";
            this.DGVViajesCompania.Size = new System.Drawing.Size(902, 150);
            this.DGVViajesCompania.TabIndex = 9;
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.Location = new System.Drawing.Point(751, 66);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BTNLimpiar.TabIndex = 10;
            this.BTNLimpiar.Text = "Limpiar";
            this.BTNLimpiar.UseVisualStyleBackColor = true;
            this.BTNLimpiar.Click += new System.EventHandler(this.BTNLimpiar_Click);
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(498, 69);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.BtnFiltrar.TabIndex = 11;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // FrmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 548);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.BTNLimpiar);
            this.Controls.Add(this.DGVViajesCompania);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBViajes);
            this.Controls.Add(this.cbPais);
            this.Controls.Add(this.LBPais);
            this.Controls.Add(this.LBHasta);
            this.Controls.Add(this.LBDesde);
            this.Controls.Add(this.DTPHasta);
            this.Controls.Add(this.DTPDesde);
            this.Controls.Add(this.DGVViajes);
            this.Name = "FrmEstadisticas";
            this.Text = "Estadísticas";
            this.Load += new System.EventHandler(this.FrmEstadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVViajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVViajesCompania)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVViajes;
        private System.Windows.Forms.DateTimePicker DTPDesde;
        private System.Windows.Forms.DateTimePicker DTPHasta;
        private System.Windows.Forms.Label LBDesde;
        private System.Windows.Forms.Label LBHasta;
        private System.Windows.Forms.Label LBPais;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.Label LBViajes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVViajesCompania;
        private System.Windows.Forms.Button BTNLimpiar;
        private System.Windows.Forms.Button BtnFiltrar;
    }
}