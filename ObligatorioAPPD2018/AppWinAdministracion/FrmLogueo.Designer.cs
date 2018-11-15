namespace AppWinAdministracion
{
    partial class FrmLogueo
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
            this.controlLogueo1 = new AppWinAdministracion.ControlLogueo();
            this.SuspendLayout();
            // 
            // controlLogueo1
            // 
            this.controlLogueo1.Location = new System.Drawing.Point(12, 12);
            this.controlLogueo1.Name = "controlLogueo1";
            this.controlLogueo1.Size = new System.Drawing.Size(218, 66);
            this.controlLogueo1.TabIndex = 0;
            // 
            // FrmLogueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 136);
            this.Controls.Add(this.controlLogueo1);
            this.Name = "FrmLogueo";
            this.Text = "Terminales Logueo";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLogueo controlLogueo1;

    }
}