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
    public partial class FrmABMTerminales : Form
    {
        //creo atributo que mantiene en memoria el objeto Terminal con el cual se esta trabajando
        
        private Terminales _objTerminal = null;

        public FrmABMTerminales()
        {
            InitializeComponent();
        }

        private void ActivoPorDefecto()
        {
            BtnAlta.Enabled = false;
            BtnBaja.Enabled = false;
            BtnModificar.Enabled = false;

            TBCodigo.Text = "";
            CBPais.SelectedIndex = -1;
            TBCiudad.Text = "";
            TBFacilidad.Text = "";
            LBFacilidades.Items.Clear();

            TBCodigo.Enabled = true;
            CBPais.Enabled = false;
            TBCiudad.Enabled = false;
            TBFacilidad.Enabled = false;
            BtnAgregar.Enabled = false;
            BtnQuitar.Enabled = false;
            //LBFacilidades.Enabled = false;

            TBCodigo.Focus();

            _objTerminal = null;
        }


        private void ActivoActualizacion()
        {
            BtnAlta.Enabled = false;
            BtnBaja.Enabled = true;
            BtnModificar.Enabled = true;

            TBCiudad.Text = _objTerminal.Codigo;
            CBPais.Text = _objTerminal.Pais;
            TBCiudad.Text = _objTerminal.Ciudad;
            TBFacilidad.Text = "";
            foreach (string unaFacilidad in _objTerminal.ListaFacilidades)
            {
                LBFacilidades.Items.Add(unaFacilidad);
            }

            TBCodigo.Enabled = false;
            CBPais.Enabled = true;
            TBCiudad.Enabled = true;
            TBFacilidad.Enabled = true;
            BtnAgregar.Enabled = true;
            BtnQuitar.Enabled = true;
        }


        private void ActivoAgregar()
        {
            BtnAlta.Enabled = true;
            BtnBaja.Enabled = false;
            BtnModificar.Enabled = false;

            CBPais.SelectedIndex = -1;
            TBCiudad.Text = "";
            TBFacilidad.Text = "";

            TBCodigo.Enabled = false;
            CBPais.Enabled = true;
            TBCiudad.Enabled = true;
            TBFacilidad.Enabled = true;
            BtnAgregar.Enabled = true;
            BtnQuitar.Enabled = true;
        }

        private void TBCodigo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Terminales _unaTerminal = null;

                _unaTerminal = new AppWinAdministracion.WSTerminalRef.WSTerminal().Buscar_Terminal(TBCodigo.Text);

                if (_unaTerminal == null)
                {
                    this.ActivoAgregar();
                }
                else
                {
                    _objTerminal = _unaTerminal;
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

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Terminales _unaTerminal = new Terminales();
                _unaTerminal.Codigo = TBCodigo.Text.Trim();
                _unaTerminal.Pais = CBPais.Text;
                _unaTerminal.Ciudad = TBCiudad.Text.Trim();
                
                List<string> _listaFacilidades = new List<string>();
                foreach(string unaFacilidad in LBFacilidades.Items)
                {
                    _listaFacilidades.Add(unaFacilidad);
                }

                _unaTerminal.ListaFacilidades = _listaFacilidades.ToArray();

                new AppWinAdministracion.WSTerminalRef.WSTerminal().Alta_Terminal(_unaTerminal);
                LblError.Text = "Terminal dada de alta con éxito";

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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TBFacilidad.Text != "")
            {
                bool encontrado = false;

                foreach (string unaFacilidad in LBFacilidades.Items)
                {
                    if ((string)unaFacilidad.ToLower() == TBFacilidad.Text.Trim().ToLower())
                    {
                        encontrado = true;
                    }
                }

                if (!encontrado)
                {
                    LBFacilidades.Items.Add(TBFacilidad.Text.Trim());
                }
                else
                {
                    LblError.Text = "La facilidad ya se encuentra en la lista";
                }

                TBFacilidad.Text = "";
            }
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            if (LBFacilidades.SelectedIndex >= 0)
            {
                LBFacilidades.Items.RemoveAt(LBFacilidades.SelectedIndex);
            }
        }

        private void BtnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                new AppWinAdministracion.WSTerminalRef.WSTerminal().Eliminar_Terminal(_objTerminal);
                LblError.Text = "Terminal eliminada con éxito";

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
                _objTerminal.Pais = CBPais.Text;
                _objTerminal.Ciudad = TBCiudad.Text.Trim();

                List<string> _listaFacilidades = new List<string>();
                foreach (string unaFacilidad in LBFacilidades.Items)
                {
                    _listaFacilidades.Add(unaFacilidad);
                }

                _objTerminal.ListaFacilidades = _listaFacilidades.ToArray();

                new AppWinAdministracion.WSTerminalRef.WSTerminal().Modificar_Terminal(_objTerminal);
                LblError.Text = "Terminal modificada con éxito";

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
            _objTerminal = null;
            this.ActivoPorDefecto();
        }
    }
}
