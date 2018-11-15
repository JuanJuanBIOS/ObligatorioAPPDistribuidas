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
        
        private Terminales _objTerminal;

        private List<Facilidades> _objListaFacilidades;

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
            CBPais.SelectedIndex = 0;
            TBCiudad.Text = "";
            TBFacilidad.Text = "";
            //falta setear la lista de facilidades
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
            LBFacilidades.DataSource = _objTerminal.ListaFacilidades;
            LBFacilidades.DisplayMember = "Facilidad";
        }


        private void ActivoAgregar()
        {
            BtnAlta.Enabled = true;
            BtnBaja.Enabled = false;
            BtnModificar.Enabled = false;

            CBPais.Text = "";
            TBCiudad.Text = "";
            TBFacilidad.Text = "";
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
                    _objListaFacilidades = new List<Facilidades>();
                    //_objListaFacilidades = (List<Facilidades>)_unaTerminal.ListaFacilidades;
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
                //_unaTerminal.ListaFacilidades = (List<Facilidades>)_objListaFacilidades;

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
                Facilidades _unaFacilidad = new Facilidades();
                _unaFacilidad.Facilidad = TBFacilidad.Text.Trim();

                _objListaFacilidades.Add(_unaFacilidad);

                TBFacilidad.Text = "";
                LBFacilidades.DataSource = _objListaFacilidades;
                LBFacilidades.DisplayMember = "Facilidad";
            }
        }



    //    private void BtnBaja_Click(object sender, EventArgs e)
    //    {
    //        try
    //        {
    //            new AppWinAdministracion.WSTerminalRef.WSTerminal().Eliminar_Compania(_objCompania);
    //            LblError.Text = "Compañía eliminada con éxito";

    //            this.ActivoPorDefecto();
    //        }

    //        catch (System.Web.Services.Protocols.SoapException ex)
    //        {
    //            if (ex.Detail.InnerText.Length > 80)
    //                LblError.Text = ex.Detail.InnerText.Substring(0, 80);
    //            else
    //                LblError.Text = ex.Detail.InnerText;
    //        }

    //        catch (Exception ex)
    //        {
    //            if (ex.Message.Length > 80)
    //                LblError.Text = ex.Message.Substring(0, 80);
    //            else
    //                LblError.Text = ex.Message;
    //        }
    //    }


    //    private void BtnModificar_Click(object sender, EventArgs e)
    //    {
    //        try
    //        {
    //            _objCompania.Nombre = TBNombre.Text.Trim();
    //            _objCompania.Direccion = TBDireccion.Text.Trim();
    //            _objCompania.Telefono = TBTel.Text.Trim();

    //            new AppWinAdministracion.WSTerminalRef.WSTerminal().Modificar_Compania(_objCompania);
    //            LblError.Text = "Compañía modificada con éxito";

    //            this.ActivoPorDefecto();
    //        }

    //        catch (System.Web.Services.Protocols.SoapException ex)
    //        {
    //            if (ex.Detail.InnerText.Length > 80)
    //                LblError.Text = ex.Detail.InnerText.Substring(0, 80);
    //            else
    //                LblError.Text = ex.Detail.InnerText;
    //        }

    //        catch (Exception ex)
    //        {
    //            if (ex.Message.Length > 80)
    //                LblError.Text = ex.Message.Substring(0, 80);
    //            else
    //                LblError.Text = ex.Message;
    //        }
    //    }


    //    private void BtnDeshacer_Click(object sender, EventArgs e)
    //    {
    //        this.ActivoPorDefecto();
    //    }
    }
}
