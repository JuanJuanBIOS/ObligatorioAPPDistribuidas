using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppWinAdministracion.WSTerminalRef;

namespace AppWinAdministracion
{
    public partial class ControlLogueo : UserControl
    {
        public ControlLogueo()
        {
            InitializeComponent();
        }

        public int Usuario
        {
            get { return (Convert.ToInt32(TBCedula.Text.Trim())); }
        }

        public string Contraseña
        {
            get { return (TBContraseña.Text.Trim()); }
        }

        //Se define evento para logueo
        public event EventHandler AutenticarUsuario;

        //provoco el evento de logueo cuando se presiona el boton
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            AutenticarUsuario(this, new EventArgs());
        }
    }
}
