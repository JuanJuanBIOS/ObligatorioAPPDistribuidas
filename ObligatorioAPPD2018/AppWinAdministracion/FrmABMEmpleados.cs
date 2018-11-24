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
    public partial class FrmABMEmpleados : Form
    {
        private Empleados _EmpLogueado;

        private Empleados _objNvoEmpleado = null;

        public FrmABMEmpleados(Empleados pEmp)
        {
            InitializeComponent();
            _EmpLogueado = pEmp;
        }

        private void ActivoPorDefecto()
        {
            BtnAlta.Enabled = false;
            BtnBaja.Enabled = false;
            BtnModificar.Enabled = false;

            TBCedula.Text = "";
            TBNombre.Text = "";
            TBPass.Text = "";

            TBCedula.Enabled = true;
            //TBNombre.Enabled = false;
            TBPass.Enabled = false;

            TBCedula.Focus();

            _objNvoEmpleado = null;
        }


        private void ActivoActualizacion()
        {
            BtnAlta.Enabled = false;
            BtnBaja.Enabled = true;
            BtnModificar.Enabled = true;

            TBCedula.Text = _objNvoEmpleado.Cedula;
            TBNombre.Text = _objNvoEmpleado.Nombre;
            TBPass.Text = "";

            TBCedula.Enabled = false;
            TBNombre.Enabled = true;
            TBPass.Enabled = true;
        }


        private void ActivoAgregar()
        {
            BtnAlta.Enabled = true;
            BtnBaja.Enabled = false;
            BtnModificar.Enabled = false;

            TBNombre.Text = "";
            TBPass.Text = "";

            TBCedula.Enabled = false;
            TBNombre.Enabled = true;
            TBPass.Enabled = true;
        }

        private void TBCedula_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Empleados _unNvoEmpleado = null;
                _unNvoEmpleado = new AppWinAdministracion.WSTerminalRef.WSTerminal().Buscar_Empleado(TBCedula.Text);

                if (_unNvoEmpleado == null)
                {
                    this.ActivoAgregar();
                }
                else
                {
                    _objNvoEmpleado = _unNvoEmpleado;
                    this.ActivoActualizacion();
                }
            }

            catch (System.Web.Services.Protocols.SoapException ex)
            {
                int aux = ex.Message.IndexOf("ERROR: ");
                LblError.Text = ex.Message.Substring(aux, 80);
            }

            catch (Exception ex)
            {
                if (ex.Message.Length > 80)
                    LblError.Text = ex.Message.Substring(0, 80);
                else
                    LblError.Text = ex.Message;
            }
        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Empleados _unNvoEmpleado = new Empleados();
                _unNvoEmpleado.Cedula = TBCedula.Text.Trim();
                _unNvoEmpleado.Nombre = TBNombre.Text.Trim();
                _unNvoEmpleado.Pass = TBPass.Text.Trim();

                new AppWinAdministracion.WSTerminalRef.WSTerminal().Alta_Empleado(_unNvoEmpleado);
                LblError.Text = "Empleado dado de alta con éxito";

                this.ActivoPorDefecto();
            }

            catch (System.Web.Services.Protocols.SoapException ex)
            {
                int aux = ex.Message.IndexOf("ERROR: ");
                LblError.Text = ex.Message.Substring(aux, 80);
            }

            catch (Exception ex)
            {
                if (ex.Message.Length > 80)
                    LblError.Text = ex.Message.Substring(0, 80);
                else
                    LblError.Text = ex.Message;
            }
        }

        private void BtnBaja_Click(object sender, EventArgs e)
        {
            if (_objNvoEmpleado.Cedula == _EmpLogueado.Cedula)
            {
                LblError.Text = "El empleado logueado no se puede eliminar a sí mismo";
            }
            else
            {
                try
                {
                    new AppWinAdministracion.WSTerminalRef.WSTerminal().Eliminar_Empleado(_objNvoEmpleado);
                    LblError.Text = "Empleado eliminado con éxito";

                    this.ActivoPorDefecto();
                }

                catch (System.Web.Services.Protocols.SoapException ex)
                {
                    int aux = ex.Message.IndexOf("ERROR: ");
                    LblError.Text = ex.Message.Substring(aux, 80);
                }

                catch (Exception ex)
                {
                    if (ex.Message.Length > 80)
                        LblError.Text = ex.Message.Substring(0, 80);
                    else
                        LblError.Text = ex.Message;
                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                _objNvoEmpleado.Nombre = TBNombre.Text.Trim();
                _objNvoEmpleado.Pass = TBPass.Text.Trim();

                new AppWinAdministracion.WSTerminalRef.WSTerminal().Modificar_Empleado(_objNvoEmpleado);
                LblError.Text = "Empleado modificado con éxito";

                this.ActivoPorDefecto();
            }

            catch (System.Web.Services.Protocols.SoapException ex)
            {
                int aux = ex.Message.IndexOf("ERROR: ");
                LblError.Text = ex.Message.Substring(aux, 80);
            }

            catch (Exception ex)
            {
                if (ex.Message.Length > 80)
                    LblError.Text = ex.Message.Substring(0, 80);
                else
                    LblError.Text = ex.Message;
            }
        }

        private void BtnDeshacer_Click(object sender, EventArgs e)
        {
            this.ActivoPorDefecto();
        }

    }
}
