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

        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            XmlDocument _doc = new XmlDocument();

            string xmltexto = new WSTerminalRef.WSTerminal().Listar_Todos_Viajes();

            _doc.LoadXml(xmltexto);
            DGVViajes.DataSource = _doc.OuterXml;
            XElement _documento = XElement.Parse(xmltexto);
            //Para cargar la grilla se usa linq to xml con objetos anonimos


        }
    }
}
