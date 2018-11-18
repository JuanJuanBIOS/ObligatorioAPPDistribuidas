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
    public partial class FrmABMCompanias : Form
    {
        //creo atributo que mantiene en memoria el objeto Compania con el cual se esta trabajando
        
        private Companias _objCompania = null;

        public FrmABMCompanias()
        {
            InitializeComponent();
        }


        private void ActivoPorDefecto()
        {
            BtnAlta.Enabled = false;
            BtnBaja.Enabled = false;
            BtnModificar.Enabled = false;

            TBNombre.Text = "";
            TBDireccion.Text = "";
            TBTel.Text = "";

            TBNombre.Enabled = true;
            //TBDireccion.Enabled = false;
            TBTel.Enabled = false;

            TBNombre.Focus();

            _objCompania = null;
        }


        private void ActivoActualizacion()
        {
            BtnAlta.Enabled = false;
            BtnBaja.Enabled = true;
            BtnModificar.Enabled = true;

            TBNombre.Text = _objCompania.Nombre;
            TBDireccion.Text = _objCompania.Direccion;
            TBTel.Text = _objCompania.Telefono;

            TBNombre.Enabled = false;
            TBDireccion.Enabled = true;
            TBTel.Enabled = true;
        }


        private void ActivoAgregar()
        {
            BtnAlta.Enabled = true;
            BtnBaja.Enabled = false;
            BtnModificar.Enabled = false;

            TBDireccion.Text = "";
            TBTel.Text = "";

            TBNombre.Enabled = false;
            TBDireccion.Enabled = true;
            TBTel.Enabled = true;
        }


        private void TBNombre_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Companias _unaCompania = null;
                _unaCompania = new AppWinAdministracion.WSTerminalRef.WSTerminal().Buscar_Compania(TBNombre.Text);

                if (_unaCompania == null)
                {
                    this.ActivoAgregar();
                }
                else
                {
                    _objCompania = _unaCompania;
                    this.ActivoActualizacion();
                }
            }

            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 80)
                    LblError.Text = ex.Detail.InnerText.Substring(0, 80);
                else
                    LblError.Text = ex.Detail.InnerText;
            }

            catch (Exception ex)
            {
                if (ex.Message.Length > 80)
                    LblError.Text = ex.Message.Substring(0, 80);
                else
                    LblError.Text = ex.Message;
            }
        }


        private void TBTel_Validating(object sender, CancelEventArgs e)
        {
            if (TBNombre.Text != "" && TBTel.Text != "")
            {
                try
                {
                    Convert.ToInt32(TBTel.Text);
                    EPTel.Clear();
                }

                catch
                {
                    EPTel.SetError(TBTel, "Sólo se pueden ingresar números");
                    e.Cancel = true;
                }
            }
        }


        private void BtnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Companias _unaCompania = new Companias();
                _unaCompania.Nombre = TBNombre.Text.Trim();
                _unaCompania.Direccion = TBDireccion.Text.Trim();
                _unaCompania.Telefono = TBTel.Text.Trim();

                new AppWinAdministracion.WSTerminalRef.WSTerminal().Alta_Compania(_unaCompania);
                LblError.Text = "Compañía dada de alta con éxito";

                this.ActivoPorDefecto();
            }

            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 80)
                    LblError.Text = ex.Detail.InnerText.Substring(0, 80);
                else
                    LblError.Text = ex.Detail.InnerText;
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
            try
            {
                new AppWinAdministracion.WSTerminalRef.WSTerminal().Eliminar_Compania(_objCompania);
                LblError.Text = "Compañía eliminada con éxito";

                this.ActivoPorDefecto();
            }

            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 80)
                    LblError.Text = ex.Detail.InnerText.Substring(0, 80);
                else
                    LblError.Text = ex.Detail.InnerText;
            }

            catch (Exception ex)
            {
                if (ex.Message.Length > 80)
                    LblError.Text = ex.Message.Substring(0, 80);
                else
                    LblError.Text = ex.Message;
            }
        }


        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //_objCompania.Nombre = TBNombre.Text.Trim();
                _objCompania.Direccion = TBDireccion.Text.Trim();
                _objCompania.Telefono = TBTel.Text.Trim();

                new AppWinAdministracion.WSTerminalRef.WSTerminal().Modificar_Compania(_objCompania);
                LblError.Text = "Compañía modificada con éxito";

                this.ActivoPorDefecto();
            }

            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 80)
                    LblError.Text = ex.Detail.InnerText.Substring(0, 80);
                else
                    LblError.Text = ex.Detail.InnerText;
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
