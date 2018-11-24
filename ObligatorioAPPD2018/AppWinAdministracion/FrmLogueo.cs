using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AppWinAdministracion.WSTerminalRef;


namespace AppWinAdministracion
{
    public partial class FrmLogueo : Form
    {
        public FrmLogueo()
        {
            InitializeComponent();

            //Se crea el controlador del evento de logueo del ControlLogueo
            ControladorLogin.AutenticarUsuario += new EventHandler(VerificoIngreso);

        }

        public void VerificoIngreso(object sender, EventArgs e)
        {
            try
            {
                Empleados _unEmpleado = new AppWinAdministracion.WSTerminalRef.WSTerminal().Login(Convert.ToString(ControladorLogin.Usuario), ControladorLogin.Contraseña);
                if (_unEmpleado == null)
                {
                    LblError.Text = "Cédula o Contraseña Inválidos";
                }

                else
                {
                    this.Hide();
                    Form _unForm = new FrmPrincipal(_unEmpleado);
                    _unForm.ShowDialog();
                    this.Close();
                }
            }

            catch (System.Web.Services.Protocols.SoapException ex)
            {
                int aux = ex.Message.IndexOf("ERROR: ");
                LblError.Text = ex.Message.Substring(aux, 80);
            }

            catch (Exception ex)
            {
                if (ex.Message.Length > 40)
                    LblError.Text = ex.Message.Substring(0, 40);
                else
                    LblError.Text = ex.Message;
            }
        }
    }
}
