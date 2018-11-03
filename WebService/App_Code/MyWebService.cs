using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using EntidadesCompartidas;
using Logica;
using System.Xml;
using System.Web.Services.Protocols;

/// <summary>
/// Summary description for MyWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class MyWebService : System.Web.Services.WebService 
{
    public MyWebService () 
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

        SoapException _MiEx = new SoapException("Error WS", SoapException.ClientFaultCode, Context.Request.Url.AbsoluteUri, _NodoError);
        throw _MiEx;
    }


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

    [WebMethod]
    public List<Companias> Listar_Todos_Companias()
    {
        List<Companias> _lista = null;
        try
        {
            _lista = FabricaLogica.getLogicaCompania().Listar_Todos_Companias();
        }

        catch (Exception ex)
        {
            this.GenerarSoapException(ex);
        }

        return _lista;
    }
}
