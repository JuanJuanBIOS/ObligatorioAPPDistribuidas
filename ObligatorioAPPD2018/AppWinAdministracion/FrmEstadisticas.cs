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
        public FrmEstadisticas()
        {
            InitializeComponent();

            //XmlDocument _doc = new XmlDocument();

            //string xmltexto = new WSTerminalRef.WSTerminal().Listar_Todos_Viajes();
            
            //XElement _documento = XElement.Parse(xmltexto);
            
            //_doc.LoadXml(xmltexto);
            //XElement _documento = XElement.Parse(xmltexto);
            //DGVViajes.DataSource = _documento;
            //DGVViajes.DataSource = _doc.OuterXml;
            //Para cargar la grilla se usa linq to xml con objetos anonimos

        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            //XmlDocument _doc = new XmlDocument();

            ////string xmltexto = new WSTerminalRef.WSTerminal().Listar_Todos_Viajes();

            ////_doc.LoadXml(xmltexto);
            ////DGVViajes.DataSource = _doc.OuterXml;
            //XElement _documento = XElement.Parse(xmltexto);
            ////Para cargar la grilla se usa linq to xml con objetos anonimos


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //limpio el resultado anterior
            DGVViajes.DataSource = null;

            
            //origen de datos
            string xmltexto = new WSTerminalRef.WSTerminal().Listar_Todos_Viajes();
            XElement _docu = XElement.Parse(xmltexto);

            //linq busqueda
            var _resultado = (from unNodo in _docu.Elements()
                               select
                                   new
                                   {
                                       Número = unNodo.Element("Numero").Value,
                                       CiudadDestino = unNodo.Element("CiudadDestino").Value,
                                       PaisDestino = unNodo.Element("PaisDestino").Value,
                                       Compania = unNodo.Element("Compania").Value,
                                       FechaPartida = unNodo.Element("FechaPartida")
                                   }).ToList();

            //muestro resultado

            DGVViajes.DataSource = _resultado;


        }

    }
}
