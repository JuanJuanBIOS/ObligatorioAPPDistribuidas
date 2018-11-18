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
            this.BtnABMViajes = new System.Windows.Forms.Button();
            this.BtnABMTerminales = new System.Windows.Forms.Button();
            this.BtnABMCompanias = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // BtnABMViajes
            // 
            this.BtnABMViajes.Location = new System.Drawing.Point(41, 61);
            this.BtnABMViajes.Name = "BtnABMViajes";
            this.BtnABMViajes.Size = new System.Drawing.Size(75, 23);
            this.BtnABMViajes.TabIndex = 0;
            this.BtnABMViajes.Text = "Viajes";
            this.BtnABMViajes.UseVisualStyleBackColor = true;
            this.BtnABMViajes.Click += new System.EventHandler(this.BtnABMViajes_Click);
            // 
            // BtnABMTerminales
            // 
            this.BtnABMTerminales.Location = new System.Drawing.Point(41, 99);
            this.BtnABMTerminales.Name = "BtnABMTerminales";
            this.BtnABMTerminales.Size = new System.Drawing.Size(75, 23);
            this.BtnABMTerminales.TabIndex = 1;
            this.BtnABMTerminales.Text = "Terminales";
            this.BtnABMTerminales.UseVisualStyleBackColor = true;
            this.BtnABMTerminales.Click += new System.EventHandler(this.BtnABMTerminales_Click);
            // 
            // BtnABMCompanias
            // 
            this.BtnABMCompanias.Location = new System.Drawing.Point(41, 140);
            this.BtnABMCompanias.Name = "BtnABMCompanias";
            this.BtnABMCompanias.Size = new System.Drawing.Size(75, 23);
            this.BtnABMCompanias.TabIndex = 2;
            this.BtnABMCompanias.Text = "Companías";
            this.BtnABMCompanias.UseVisualStyleBackColor = true;
            this.BtnABMCompanias.Click += new System.EventHandler(this.BtnABMCompanias_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(229, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 261);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BtnABMCompanias);
            this.Controls.Add(this.BtnABMTerminales);
            this.Controls.Add(this.BtnABMViajes);
            this.Name = "FrmPrincipal";
            this.Text = "Terminales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnABMViajes;
        private System.Windows.Forms.Button BtnABMTerminales;
        private System.Windows.Forms.Button BtnABMCompanias;
        private System.Windows.Forms.StatusStrip statusStrip1;

    }
}