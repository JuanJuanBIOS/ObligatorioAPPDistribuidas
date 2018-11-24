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
    public partial class FrmABMNacionales : Form
    {
        private Empleados _EmpLogueado;

        private Nacionales _objNacional = null;

        private List<Companias> _objListaCompanias = new AppWinAdministracion.WSTerminalRef.WSTerminal().Listar_Companias().ToList();
        private List<Terminales> _objListaTerminales = new AppWinAdministracion.WSTerminalRef.WSTerminal().Listar_Terminales().ToList();

        public FrmABMNacionales(Empleados pEmp)
        {
            InitializeComponent();
            _EmpLogueado = pEmp;
            CBCompania.DataSource = _objListaCompanias;
            CBCompania.ValueMember = "Nombre";
            CBCompania.SelectedIndex = -1;
            CBTerminal.DataSource = _objListaTerminales;
            CBTerminal.ValueMember = "Codigo";
            CBTerminal.SelectedIndex = -1;
        }

        private void ActivoPorDefecto()
        {
            BtnAlta.Enabled = false;
            BtnBaja.Enabled = false;
            BtnModificar.Enabled = false;

            TBNumero.Text = "";
            CBCompania.SelectedIndex = -1;
            CBTerminal.SelectedIndex = -1;
            TBAsientos.Text = "";
            TBParadas.Text = "";
            DTPFechaPartida.Value = DateTime.Today;
            CBHoraPartida.SelectedIndex = -1;
            CBMinutosPartida.SelectedIndex = -1;
            DTPFechaArribo.Value = DateTime.Today;
            CBHoraArribo.SelectedIndex = -1;
            CBMinutosArribo.SelectedIndex = -1;

            TBNumero.Focus();

            TBNumero.Enabled = true;
            CBCompania.Enabled = false;
            CBTerminal.Enabled = false;
            TBAsientos.Enabled = false;
            TBParadas.Enabled = false;
            DTPFechaPartida.Enabled = false;
            CBHoraPartida.Enabled = false;
            CBMinutosPartida.Enabled = false;
            DTPFechaArribo.Enabled = false;
            CBHoraArribo.Enabled = false;
            //CBMinutosArribo.Enabled = false;

            TBNumero.Focus();

            _objNacional = null;
        }


        private void ActivoActualizacion()
        {
            BtnAlta.Enabled = false;
            BtnBaja.Enabled = true;
            BtnModificar.Enabled = true;

            CBCompania.Text = _objNacional.Compania.Nombre;
            CBTerminal.Text = _objNacional.Terminal.Codigo;
            TBAsientos.Text = Convert.ToString(_objNacional.Asientos);
            TBParadas.Text = Convert.ToString(_objNacional.Paradas);
            DTPFechaPartida.Value = _objNacional.Fecha_partida.Date;
            CBHoraPartida.SelectedIndex = _objNacional.Fecha_partida.Hour;
            CBMinutosPartida.SelectedIndex = _objNacional.Fecha_partida.Minute;
            DTPFechaArribo.Value = _objNacional.Fecha_arribo.Date;
            CBHoraArribo.SelectedIndex = _objNacional.Fecha_arribo.Hour;
            CBMinutosArribo.SelectedIndex = _objNacional.Fecha_arribo.Minute;

            TBNumero.Enabled = false;
            CBCompania.Enabled = true;
            CBTerminal.Enabled = true;
            TBAsientos.Enabled = true;
            TBParadas.Enabled = true;
            DTPFechaPartida.Enabled = true;
            CBHoraPartida.Enabled = true;
            CBMinutosPartida.Enabled = true;
            DTPFechaArribo.Enabled = true;
            CBHoraArribo.Enabled = true;
            CBMinutosArribo.Enabled = true;
        }


        private void ActivoAgregar()
        {
            BtnAlta.Enabled = true;
            BtnBaja.Enabled = false;
            BtnModificar.Enabled = false;

            CBCompania.SelectedIndex = -1;
            CBTerminal.SelectedIndex = -1;
            TBAsientos.Text = "";
            TBParadas.Text = "";
            DTPFechaPartida.Value = DateTime.Today;
            CBHoraPartida.SelectedIndex = -1;
            CBMinutosPartida.SelectedIndex = -1;
            DTPFechaArribo.Value = DateTime.Today;
            CBHoraArribo.SelectedIndex = -1;
            CBMinutosArribo.SelectedIndex = -1;

            TBNumero.Enabled = false;
            CBCompania.Enabled = true;
            CBTerminal.Enabled = true;
            TBAsientos.Enabled = true;
            TBParadas.Enabled = true;
            DTPFechaPartida.Enabled = true;
            CBHoraPartida.Enabled = true;
            CBMinutosPartida.Enabled = true;
            DTPFechaArribo.Enabled = true;
            CBHoraArribo.Enabled = true;
            CBMinutosArribo.Enabled = true;
        }

        private void TBNumero_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Viajes _unNacional = null;

                _unNacional = new AppWinAdministracion.WSTerminalRef.WSTerminal().Buscar_Viaje(Convert.ToInt32(TBNumero.Text));

                if (_unNacional == null)
                {
                    this.ActivoAgregar();
                }
                else if (_unNacional is Internacionales)
                {
                    LblError.Text = "El viaje ingresado corresponde a un viaje internacional";
                }
                else
                {
                    _objNacional = (Nacionales)_unNacional;
                    this.ActivoActualizacion();
                }
            }

            catch (System.Web.Services.Protocols.SoapException ex)
            {
                int aux = ex.Message.IndexOf("ERROR: ");
                LblError.Text = ex.Message.Substring(aux, 80);
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
                Nacionales _unNacional = new Nacionales();
                _unNacional.Numero = Convert.ToInt32(TBNumero.Text);
                _unNacional.Compania = (Companias)CBCompania.SelectedItem;
                _unNacional.Terminal = (Terminales)CBTerminal.SelectedItem;
                _unNacional.Asientos = Convert.ToInt32(TBAsientos.Text);
                _unNacional.Paradas = Convert.ToInt32(TBParadas.Text);
                
                DateTime _Fechapartida = new DateTime(DTPFechaPartida.Value.Year, DTPFechaPartida.Value.Month, DTPFechaPartida.Value.Day, CBHoraPartida.SelectedIndex, CBMinutosPartida.SelectedIndex, 0);
                DateTime _Fechaarribo = new DateTime(DTPFechaArribo.Value.Year, DTPFechaArribo.Value.Month, DTPFechaArribo.Value.Day, CBHoraArribo.SelectedIndex, CBMinutosArribo.SelectedIndex, 0);

                _unNacional.Fecha_partida = _Fechapartida;
                _unNacional.Fecha_arribo = _Fechaarribo;

                _unNacional.Empleado = _EmpLogueado;

                new AppWinAdministracion.WSTerminalRef.WSTerminal().Alta_Viaje(_unNacional);
                LblError.Text = "Viaje Nacional dado de alta con éxito";

                this.ActivoPorDefecto();
            }

            catch (System.Web.Services.Protocols.SoapException ex)
            {
                int aux = ex.Message.IndexOf("ERROR: ");
                LblError.Text = ex.Message.Substring(aux, 80);
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
                new AppWinAdministracion.WSTerminalRef.WSTerminal().Eliminar_Viaje(_objNacional);
                LblError.Text = "Viaje Nacional eliminado con éxito";

                this.ActivoPorDefecto();
            }

            catch (System.Web.Services.Protocols.SoapException ex)
            {
                int aux = ex.Message.IndexOf("ERROR: ");
                LblError.Text = ex.Message.Substring(aux, 80);
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
                _objNacional.Numero = Convert.ToInt32(TBNumero.Text);
                _objNacional.Compania = (Companias)CBCompania.SelectedItem;
                _objNacional.Terminal = (Terminales)CBTerminal.SelectedItem;
                _objNacional.Asientos = Convert.ToInt32(TBAsientos.Text);
                _objNacional.Paradas = Convert.ToInt32(TBParadas.Text);

                DateTime _Fechapartida = new DateTime(DTPFechaPartida.Value.Year, DTPFechaPartida.Value.Month, DTPFechaPartida.Value.Day, CBHoraPartida.SelectedIndex, CBMinutosPartida.SelectedIndex, 0);
                DateTime _Fechaarribo = new DateTime(DTPFechaArribo.Value.Year, DTPFechaArribo.Value.Month, DTPFechaArribo.Value.Day, CBHoraArribo.SelectedIndex, CBMinutosArribo.SelectedIndex, 0);

                _objNacional.Fecha_partida = _Fechapartida;
                _objNacional.Fecha_arribo = _Fechaarribo;

                _objNacional.Empleado = _EmpLogueado;

                new AppWinAdministracion.WSTerminalRef.WSTerminal().Modificar_Viaje(_objNacional);
                LblError.Text = "Viaje Nacional modificado con éxito";

                this.ActivoPorDefecto();
            }

            catch (System.Web.Services.Protocols.SoapException ex)
            {
                int aux = ex.Message.IndexOf("ERROR: ");
                LblError.Text = ex.Message.Substring(aux, 80);
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
            _objNacional = null;
            this.ActivoPorDefecto();
        }

    }
}
