namespace AppWinAdministracion
{
    partial class ControlLogueo
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblCedula = new System.Windows.Forms.Label();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.TBCedula = new System.Windows.Forms.TextBox();
            this.TBContraseña = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.Location = new System.Drawing.Point(4, 4);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(43, 13);
            this.LblCedula.TabIndex = 0;
            this.LblCedula.Text = "Cédula:";
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Location = new System.Drawing.Point(4, 34);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(64, 13);
            this.LblContraseña.TabIndex = 1;
            this.LblContraseña.Text = "Contraseña:";
            // 
            // TBCedula
            // 
            this.TBCedula.Location = new System.Drawing.Point(102, 4);
            this.TBCedula.Name = "TBCedula";
            this.TBCedula.Size = new System.Drawing.Size(100, 20);
            this.TBCedula.TabIndex = 2;
            // 
            // TBContraseña
            // 
            this.TBContraseña.Location = new System.Drawing.Point(102, 31);
            this.TBContraseña.Name = "TBContraseña";
            this.TBContraseña.Size = new System.Drawing.Size(100, 20);
            this.TBContraseña.TabIndex = 2;
            this.TBContraseña.UseSystemPasswordChar = true;
            // 
            // ControlLogueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TBContraseña);
            this.Controls.Add(this.TBCedula);
            this.Controls.Add(this.LblContraseña);
            this.Controls.Add(this.LblCedula);
            this.Name = "ControlLogueo";
            this.Size = new System.Drawing.Size(218, 66);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCedula;
        private System.Windows.Forms.Label LblContraseña;
        private System.Windows.Forms.TextBox TBCedula;
        private System.Windows.Forms.TextBox TBContraseña;
    }
}
