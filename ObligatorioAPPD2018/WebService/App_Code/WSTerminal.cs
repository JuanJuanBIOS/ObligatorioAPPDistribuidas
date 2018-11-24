using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using EntidadesCompartidas;
using System.Xml;
using System.Web.Services.Protocols;
using Logica;
using Logica.Interfaces;

/// <summary>
/// Summary description for WSTerminal
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WSTerminal : System.Web.Services.WebService 
{
    public WSTerminal() 
    {
        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }


    private void GenerarSoapException(Exception ex)
    {
        XmlDocument _undoc = new XmlDocument();
        XmlNode _NodoError = _undoc.CreateNode(XmlNodeType.Element, SoapException.DetailElementName.Name, SoapException.DetailElementName.Namespace);

        XmlNode _NodoDetalle = _undoc.CreateNode(XmlNodeType.Element, "Error", "");
        _NodoDetalle.InnerText = ex.Message;
        _NodoError.AppendChild(_NodoDetalle);

        //SoapException _MiEx = new SoapException("Error WS", SoapException.ClientFaultCode, Context.Request.Url.AbsoluteUri, _NodoError);
        SoapException _MiEx = new SoapException("Error WS", SoapException.ClientFaultCode, Context.Request.Url.AbsoluteUri, _NodoError);
        throw _MiEx;
    }

    [WebMethod]
    public void ParaPoderSerializar(Nacionales unNac, Internacionales unInter) { }

    #region LogicaCompania

    [WebMethod]
    public Companias Buscar_Compania(string pNombre)
    {
        Companias _unaCompania = null;
        try
        {
            _unaCompania = FabricaLogica.getLogicaCompania().Buscar_Compania(pNombre);
        }

        catch (Exception ex)
        {
            this.GenerarSoapException(ex);
        }

        return _unaCompania;
    }


    [WebMethod]
    public void Alta_Compania(Companias unaCompania)
    {
        try
        {
            FabricaLogica.getLogicaCompania().Alta_Compania(unaCompania);
        }

        catch (Exception ex)
        {
            this.GenerarSoapException(ex);
        }
    }


    [WebMethod]
    public void Eliminar_Compania(Companias unaCompania)
    {
        try
        {
            FabricaLogica.getLogicaCompania().Eliminar_Compania(unaCompania);
        }

        catch (Exception ex)
        {
            this.GenerarSoapException(ex);
        }
    }


    [WebMethod]
    public void Modificar_Compania(Companias unaCompania)
    {
        try
        {
            FabricaLogica.getLogicaCompania().Modificar_Compania(unaCompania);
        }

        catch (Exception ex)
        {
            this.GenerarSoapException(ex);
        }
    }


    [WebMethod]
    public List<Companias> Listar_Companias()
    {
        List<Companias> _lista = null;
        try
        {
            _lista = FabricaLogica.getLogicaCompania().Listar_Companias();
        }

        catch (Exception ex)
        {
            this.GenerarSoapException(ex);
        }

        return _lista;
    }

    #endregion

    #region LogicaTerminal

    [WebMethod]
    public Terminales Buscar_Terminal(string pCodigo)
    {
        Terminales _unaTerminal = null;
        try
        {
            _unaTerminal = FabricaLogica.getLogicaTerminal().Buscar_Terminal(pCodigo);
        }

        catch (Exception ex)
        {
            this.GenerarSoapException(ex);
        }

        return _unaTerminal;
    }


    [WebMethod]
    public void Alta_Terminal(Terminales unaTerminal)
    {
        try
        {
            FabricaLogica.getLogicaTerminal().Alta_Terminal(unaTerminal);
        }

        catch (Exception ex)
        {
            this.GenerarSoapException(ex);
        }
    }


    [WebMethod]
    public void Eliminar_Terminal(Terminales unaTerminal)
    {
        try
        {
            FabricaLogica.getLogicaTerminal().Eliminar_Terminal(unaTerminal);
        }

        catch (Exception ex)
        {
            this.GenerarSoapException(ex);
        }
    }


    [WebMethod]
    public void Modificar_Terminal(Terminales unaTerminal)
    {
        try
        {
            FabricaLogica.getLogicaTerminal().Modificar_Terminal(unaTerminal);
        }

        catch (Exception ex)
        {
            this.GenerarSoapException(ex);
        }
    }


    [WebMethod]
    public List<Terminales> Listar_Terminales()
    {
        List<Terminales> _lista = null;
        try
        {
            _lista = FabricaLogica.getLogicaTerminal().Listar_Terminales();
        }

        catch (Exception ex)
        {
            this.GenerarSoapException(ex);
        }

        return _lista;
    }
    
    #endregion

    #region LogicaViaje

    [WebMethod]
    public Viajes Buscar_Viaje(int pCodigo)
    {
        Viajes _unViaje = null;
        try
        {
            _unViaje = FabricaLogica.getLogicaViaje().Buscar_Viaje(pCodigo);
        }

        catch (Exception ex)
        {
            this.GenerarSoapException(ex);
        }

        return _unViaje;
    }


    [WebMethod]
    public void Alta_Viaje(Viajes unViaje)
    {
        try
        {
            FabricaLogica.getLogicaViaje().Alta_Viaje(unViaje);
        }

        catch (Exception ex)
        {
            this.GenerarSoapException(ex);
        }
    }


    [WebMethod]
    public void Eliminar_Viaje(Viajes unViaje)
    {
        try
        {
            FabricaLogica.getLogicaViaje().Eliminar_Viaje(unViaje);
        }

        catch (Exception ex)
        {
            this.GenerarSoapException(ex);
        }
    }


    [WebMethod]
    public void Modificar_Viaje(Viajes unViaje)
    {
        try
        {
            FabricaLogica.getLogicaViaje().Modificar_Viaje(unViaje);
        }

        catch (Exception ex)
        {
            this.GenerarSoapException(ex);
        }
    }


    [WebMethod]
    public List<Viajes> Listar_Viajes()
    {
        List<Viajes> _lista = null;
        try
        {
            _lista = FabricaLogica.getLogicaViaje().Listar_Viajes();
        }

        catch (Exception ex)
        {
            this.GenerarSoapException(ex);
        }

        return _lista;
    }

    [WebMethod]
    public List<Viajes> Listar_Todos_Viajes()
    {
        List<Viajes> _lista = null;
        try
        {
            _lista = FabricaLogica.getLogicaViaje().Listar_Todos_Viajes();
            XmlDocument _doc = new XmlDocument();
            _doc.LoadXml("<?xml version='1.0' encoding ='utf-8' ?> <Viaje> </Viaje>");
            XmlNode nodoViaje = _doc.CreateNode(XmlNodeType.Element, "Viaje", "");

            foreach (Viajes _viaje in _lista)
            {
                

                XmlNode nodoNumero = _doc.CreateNode(XmlNodeType.Element, "Número", "");
                nodoNumero.InnerXml = _viaje.Numero.ToString();
                nodoViaje.AppendChild(nodoNumero);

                XmlNode nodoCiudadDestino = _doc.CreateNode(XmlNodeType.Element, "CiudadDestino", "");
                nodoCiudadDestino.InnerXml = _viaje.Terminal.Ciudad;
                nodoViaje.AppendChild(nodoCiudadDestino);

                XmlNode nodoPaisDestino = _doc.CreateNode(XmlNodeType.Element, "PaisDestino", "");
                nodoPaisDestino.InnerXml = _viaje.Terminal.Pais;
                nodoViaje.AppendChild(nodoPaisDestino);

                XmlNode nodoCompania = _doc.CreateNode(XmlNodeType.Element, "Compania", "");
                nodoCompania.InnerXml = _viaje.Compania.Nombre;
                nodoViaje.AppendChild(nodoCompania);

                XmlNode nodoFechaPartida = _doc.CreateNode(XmlNodeType.Element, "FechaPartida", "");
                nodoFechaPartida.InnerXml = _viaje.Fecha_partida.ToString();
                nodoViaje.AppendChild(nodoFechaPartida);

                _doc.DocumentElement.AppendChild(nodoViaje);
            }
            //return (_doc.OuterXml);
        }

        catch (Exception ex)
        {
            this.GenerarSoapException(ex);
        }

        return _lista;
    }

    #endregion

    #region LogicaEmpleado

    [WebMethod]
    public Empleados Login(string pCed, string pPass)
    {
        Empleados _unEmpleado = null;
        try
        {
            _unEmpleado = FabricaLogica.getLogicaEmpleado().Login(pCed, pPass);
        }

        catch (Exception ex)
        {
            this.GenerarSoapException(ex);
        }

        return _unEmpleado;
    }


    [WebMethod]
    public Empleados Buscar_Empleado(string pCedula)
    {
        Empleados _unEmpleado = null;
        try
        {
            _unEmpleado = FabricaLogica.getLogicaEmpleado().Buscar_Empleado(pCedula);
        }

        catch (Exception ex)
        {
            this.GenerarSoapException(ex);
        }

        return _unEmpleado;
    }

    [WebMethod]
    public void Alta_Empleado(Empleados unEmpleado)
    {
        try
        {
            FabricaLogica.getLogicaEmpleado().Alta_Empleado(unEmpleado);
        }

        catch (Exception ex)
        {
            this.GenerarSoapException(ex);
        }
    }


    [WebMethod]
    public void Eliminar_Empleado(Empleados unEmpleado)
    {
        try
        {
            FabricaLogica.getLogicaEmpleado().Eliminar_Empleado(unEmpleado);
        }

        catch (Exception ex)
        {
            this.GenerarSoapException(ex);
        }
    }


    [WebMethod]
    public void Modificar_Empleado(Empleados unEmpleado)
    {
        try
        {
            FabricaLogica.getLogicaEmpleado().Modificar_Empleado(unEmpleado);
        }

        catch (Exception ex)
        {
            this.GenerarSoapException(ex);
        }
    }

    #endregion
}
