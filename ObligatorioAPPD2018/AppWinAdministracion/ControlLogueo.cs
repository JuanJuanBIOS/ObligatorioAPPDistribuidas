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
        private Empleados _objEmpleado = null;

        public ControlLogueo()
        {
            InitializeComponent();
        }

        private void TBCedula_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Empleados _unEmpleado = null;
                _unEmpleado = new AppWinAdministracion.WSTerminalRef.WSTerminal().Buscar_Empleado(TBCedula.Text);

                if (_unEmpleado == null)
                {
                    MessageBox.Show("El usuario no existe");

                }

            }
            
            catch (System.Web.Services.Protocols.SoapException ex)
            {}
        }
    }
}
