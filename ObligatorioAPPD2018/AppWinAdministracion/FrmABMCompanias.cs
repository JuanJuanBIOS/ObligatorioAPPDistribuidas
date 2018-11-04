﻿using System;
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

        private void DesActivoBotones()
        {
            BtnAlta.Enabled = false;
            BtnBaja.Enabled = false;
            BtnModificar.Enabled = false;
        }

        private void LimpioControles()
        {
            TBNombre.Text = "";
            TBDireccion.Text = "";
            TBTel.Text = "";
            LblError.Text = "";
        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Companias _unaCompania = new Companias();
                _unaCompania.Nombre = TBNombre.Text.Trim();
                _unaCompania.Direccion = TBDireccion.Text.Trim();
                _unaCompania.Telefono = TBTel.Text.Trim();

                new WSTerminal().Alta_Compania(_unaCompania);
                this.DesActivoBotones();
                this.LimpioControles();
                LblError.Text = "Alta con Exito";
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 40)
                    LblError.Text = ex.Detail.InnerText.Substring(0, 40);
                else
                    LblError.Text = ex.Detail.InnerText;
            }
            catch (Exception ex)
            {
                if (ex.Message.Length > 40)
                    LblError.Text = ex.Message.Substring(0, 40);
                else
                    LblError.Text = ex.Message;
            }
        }

        private void TBTel_Validating(object sender, CancelEventArgs e)
        {
            //verifico ingreso de solo numeros
            try
            {
                Convert.ToInt32(TBTel.Text);
                ErrorProv.Clear();
            }
            catch (Exception)
            {
                ErrorProv.SetError(TBTel, "Solo se pueden ingresar numeros");
                e.Cancel = true;
            }
        }

        private void TBNombre_Validating(object sender, CancelEventArgs e)
        {
            //busqueda del Compania
            try
            {
                Companias _unaCompania = null;
                _unaCompania = new WSTerminal().Buscar_Compania(TBNombre.Text);
                this.LimpioControles();

                if (_unaCompania == null)
                {
                    BtnAlta.Enabled = true;
                }
                else
                {
                    BtnModificar.Enabled = true;
                    BtnBaja.Enabled = true;
                    _objCompania = _unaCompania;
                    TBNombre.Text = _unaCompania.Nombre.ToString();
                    TBDireccion.Text = _unaCompania.Direccion;
                    TBTel.Text = _unaCompania.Telefono;
                }
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 40)
                    LblError.Text = ex.Detail.InnerText.Substring(0, 40);
                else
                    LblError.Text = ex.Detail.InnerText;
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
