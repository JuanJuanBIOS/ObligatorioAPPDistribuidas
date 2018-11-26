using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

using AppWinAdministracion.WSTerminalRef;
using System.Xml.Linq;

namespace AppWinAdministracion
{
    public partial class FrmEstadisticas : Form
    {
        XElement _documento = null;

        public FrmEstadisticas()
        {
            InitializeComponent();
        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            string xmltexto = new WSTerminalRef.WSTerminal().Listar_Todos_Viajes();

            _documento = XElement.Parse(xmltexto);

            var _resultado = (from unNodo in _documento.Elements("Viaje")
                              orderby Convert.ToDateTime(unNodo.Element("FechaPartida").Value)
                              select new
                                  {
                                      Numero = unNodo.Element("Numero").Value,
                                      CiudadDestino = unNodo.Element("CiudadDestino").Value,
                                      PaisDestino = unNodo.Element("PaisDestino").Value,
                                      Compania = unNodo.Element("Compania").Value,
                                      FechaPartida = unNodo.Element("FechaPartida").Value
                                  }).ToList();

            DGVViajes.DataSource = _resultado;

            List<string> Paises = (from unViaje in _resultado
                                   select unViaje.PaisDestino).Distinct().ToList();

            cbPais.DataSource = Paises;

            cbPais.SelectedIndex = -1;

            var _resultadoGrupo = (from unNodo in _resultado
                                     group unNodo by new { Comp = unNodo.Compania, Anio = Convert.ToDateTime(unNodo.FechaPartida).Year }
                                         into grp
                                         orderby grp.Key.Comp, grp.Key.Anio
                                         select new
                                         {
                                             Compania = grp.Key.Comp,
                                             Anio = grp.Key.Anio,
                                             Cantidad = grp.Count()
                                         }).ToList();

            DGVViajesCompania.DataSource = _resultadoGrupo;

        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            var _resultado = (from unNodo in _documento.Elements("Viaje")
                              orderby Convert.ToDateTime(unNodo.Element("FechaPartida").Value)
                              where
                             (unNodo.Element("PaisDestino").Value == (string)cbPais.SelectedValue || (string)cbPais.SelectedValue == string.Empty)
                             && (Convert.ToDateTime(unNodo.Element("FechaPartida").Value) >= DTPDesde.Value && Convert.ToDateTime(unNodo.Element("FechaPartida").Value) <= DTPHasta.Value)
                              select new
                              {
                                  Numero = unNodo.Element("Numero").Value,
                                  CiudadDestino = unNodo.Element("CiudadDestino").Value,
                                  PaisDestino = unNodo.Element("PaisDestino").Value,
                                  Compania = unNodo.Element("Compania").Value,
                                  FechaPartida = unNodo.Element("FechaPartida").Value
                              }).ToList();

            DGVViajes.DataSource = _resultado;
        }

        private void BTNLimpiar_Click(object sender, EventArgs e)
        {
            var _resultado = (from unNodo in _documento.Elements("Viaje")
                              select new
                              {
                                  Numero = unNodo.Element("Numero").Value,
                                  CiudadDestino = unNodo.Element("CiudadDestino").Value,
                                  PaisDestino = unNodo.Element("PaisDestino").Value,
                                  Compania = unNodo.Element("Compania").Value,
                                  FechaPartida = unNodo.Element("FechaPartida").Value
                              }).ToList();

            DGVViajes.DataSource = _resultado;

            cbPais.SelectedIndex = -1;
        }
    }
}
