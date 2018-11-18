using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;

using WSTerminalRef;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FiltroDestinoObligatorio();

            try
            {

                //Obtengo lista de viajes y lo guardo en el session
                List<WSTerminalRef.Viajes> ListaViajes = new WSTerminalRef.WSTerminal().Listar_Viajes().ToList<Viajes>();
                Session["ListaViajes"] = ListaViajes;

                //Obtengo lista de terminales en mis viajes usando LinQ
               
                List<Terminales> ListaTerminales = (from unViaje in (List<Viajes>)Session["ListaViajes"]
                                                    select unViaje.Terminal).GroupBy(n => new { n.Codigo }).Select(g => g.FirstOrDefault()).ToList();
          

                Session["Terminales"] = ListaTerminales;

                //Obtengo lista de Companias en mis viajes usando LinQ
                List<Companias> ListaCompanias = (from unViaje in (List<Viajes>)Session["ListaViajes"]
                                                    select unViaje.Compania).GroupBy(n => new { n.Nombre }).Select(g => g.FirstOrDefault()).ToList();;
                Session["Companias"] = ListaCompanias;

                //Predefino los valores en los dropdown lists
                DDLTerminal.DataSource = ListaTerminales;
                DDLTerminal.DataTextField = "codigo";
                DDLTerminal.DataBind();
                DDLCompania.Items.Insert(0, new ListItem("", ""));

                DDLCompania.DataSource = ListaCompanias;
                DDLCompania.DataTextField = "nombre";
                DDLCompania.DataBind();
                DDLCompania.Items.Insert(0, new ListItem("", ""));


                //Uso LinQ para tener solo los viajes que aún no hayan partido

                RepeaterViajes.DataSource = ListaViajes;
                RepeaterViajes.DataBind();
            }

            catch (Exception ex)
            {
                LblError.Text = ex.Message;
            }
        }
    }


    protected void RepeaterViajes_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "ConsultaViaje")
        {
            try
            {
                int viajeseleccionado = Convert.ToInt32(((TextBox)(e.Item.Controls[1])).Text);

                //Uso LinQ para tener solo el viaje seleccionado por el click en el boton del repeater
                //Solo se puede seleccionar un viaje pro eso usamos first
                Session["ViajeSeleccionado"] = (from unViaje in (List<Viajes>)Session["ListaViajes"]
                                                where unViaje.Numero == viajeseleccionado
                                                select unViaje).First();

                Response.Redirect("~/ConsultaIndividualViaje.aspx");
            }

            catch (Exception ex) { LblError.Text = ex.Message; }
        }

    }


    protected void CalDesde_SelectionChanged(object sender, EventArgs e)
    {
        TBDesFechaPartida.Text = CalDesde.SelectedDate.ToShortDateString();
        if (!(TBHasFechaPartida.Text == ""))
        {
            VerificarFechas();
        }
    }


    protected void CalHasta_SelectionChanged(object sender, EventArgs e)
    {
        TBHasFechaPartida.Text = CalHasta.SelectedDate.ToShortDateString();
        if (!(TBDesFechaPartida.Text == ""))
        {
            VerificarFechas();
        }
    }


    private void VerificarFechas()
    {
        bool valido = false;
        LblError.Text = "";

        try
        {
            DateTime desdefecha = Convert.ToDateTime(TBDesFechaPartida.Text);
            DateTime hastafecha = Convert.ToDateTime(TBHasFechaPartida.Text);

            if (desdefecha < hastafecha)
            {
                valido = true;
            }

            else
            {
                LblError.ForeColor = System.Drawing.Color.Red;
                LblError.Text = "La fecha de Arribo debe ser mayor a la fecha de Partida";
            }
        }

        catch
        {
            LblError.ForeColor = System.Drawing.Color.Red;
            LblError.Text = "La fecha de Arribo debe ser mayor a la fecha de Partida";
        }

        if (valido)
        {
            BtnFiltrar.Enabled = true;
        }
        else
        {
            BtnFiltrar.Enabled = false;
        }
    }


    protected void DDLTerminal_SelectedIndexChanged(object sender, EventArgs e)
    {
        BtnFiltrar.Enabled = true;
        ActivoRestoFiltros();
    }


    protected void BtnFiltrar_Click(object sender, EventArgs e)
    {
        //Defino por defecto los minimos y maximos valores para que incluya todos en el filtro
        DateTime DesFechaPart = DateTime.MinValue;
        DateTime HasFechaPart = DateTime.MaxValue;


        if (TBDesFechaPartida.Text != "")
        {
            DesFechaPart = Convert.ToDateTime(TBDesFechaPartida.Text);
        }

        if (TBHasFechaPartida.Text != "")
        {
            HasFechaPart = Convert.ToDateTime(TBHasFechaPartida.Text);
        }

        try
        {
            List<Viajes> viajesfiltrados = (from unViaje in (List<Viajes>)Session["ListaViajes"]
                                            where unViaje.Terminal.Codigo == DDLTerminal.SelectedValue
                                            && unViaje.Fecha_partida >= DesFechaPart
                                            && unViaje.Fecha_partida <= Convert.ToDateTime(HasFechaPart)
                                            select unViaje).ToList<Viajes>();

            if (!String.IsNullOrEmpty(DDLCompania.Text))
            {
                viajesfiltrados = (from unViaje in (List<Viajes>)Session["ListaViajes"]
                                   where unViaje.Terminal.Codigo == DDLTerminal.SelectedValue
                                   && unViaje.Fecha_partida >= DesFechaPart
                                   && unViaje.Fecha_partida <= Convert.ToDateTime(HasFechaPart)
                                   && unViaje.Compania.Nombre == DDLCompania.Text
                                   select unViaje).ToList<Viajes>();
            }

            RepeaterViajes.DataSource = viajesfiltrados;
            RepeaterViajes.DataBind();
        }

        catch
        {
            LblError.ForeColor = System.Drawing.Color.Red;
            LblError.Text = "El filtro no arroja resultados";
        }
    }


    protected void BtnLimpiar_Click(object sender, EventArgs e)
    {
        LimpioFormulario();
    }


    private void LimpioFormulario()
    {
        DDLTerminal.ClearSelection();
        DDLCompania.ClearSelection();
        CalDesde.SelectedDates.Clear();
        CalHasta.SelectedDates.Clear();
        TBDesFechaPartida.Text = "";
        TBHasFechaPartida.Text = "";
        FiltroDestinoObligatorio();
        LblError.Text = "";

        //El listado de viajes ya son los de despues de la fecha de hoy -error de la entrega pasada
        RepeaterViajes.DataSource = Session["ListaViajes"];
        RepeaterViajes.DataBind();
    }


    private void FiltroDestinoObligatorio()
    {
        BtnFiltrar.Enabled = false;
        DDLCompania.Enabled = false;
        CalDesde.Enabled = false;
        CalHasta.Enabled = false;
        TBDesFechaPartida.Text = "";
        TBHasFechaPartida.Text = "";
    }


    private void ActivoRestoFiltros()
    {
        BtnFiltrar.Enabled = true;
        DDLCompania.Enabled = true;
        CalDesde.Enabled = true;
        CalHasta.Enabled = true;
    }
}