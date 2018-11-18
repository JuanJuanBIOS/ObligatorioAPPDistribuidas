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
    public partial class FrmABMInternacionales : Form
    {
        private Empleados _EmpLogueado;

        private Internacionales _objInternacional = null;

        private List<Companias> _objListaCompanias = new AppWinAdministracion.WSTerminalRef.WSTerminal().Listar_Companias().ToList();
        private List<Terminales> _objListaTerminales = new AppWinAdministracion.WSTerminalRef.WSTerminal().Listar_Terminales().ToList();

        public FrmABMInternacionales(Empleados pEmp)
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
            CBServicio.Checked = false;
            DTPFechaPartida.Value = DateTime.Today;
            CBHoraPartida.SelectedIndex = -1;
            CBMinutosPartida.SelectedIndex = -1;
            DTPFechaArribo.Value = DateTime.Today;
            CBHoraArribo.SelectedIndex = -1;
            CBMinutosArribo.SelectedIndex = -1;
            TBDocumentacion.Text = "";

            TBNumero.Focus();

            TBNumero.Enabled = true;
            CBCompania.Enabled = false;
            CBTerminal.Enabled = false;
            TBAsientos.Enabled = false;
            CBServicio.Enabled = false;
            DTPFechaPartida.Enabled = false;
            CBHoraPartida.Enabled = false;
            CBMinutosPartida.Enabled = false;
            DTPFechaArribo.Enabled = false;
            CBHoraArribo.Enabled = false;
            //CBMinutosArribo.Enabled = false;
            TBDocumentacion.Enabled = false;

            TBNumero.Focus();

            _objInternacional = null;
        }


        private void ActivoActualizacion()
        {
            BtnAlta.Enabled = false;
            BtnBaja.Enabled = true;
            BtnModificar.Enabled = true;

            CBCompania.Text = _objInternacional.Compania.Nombre;
            CBTerminal.Text = _objInternacional.Terminal.Codigo;
            TBAsientos.Text = Convert.ToString(_objInternacional.Asientos);
            CBServicio.Checked = _objInternacional.Servicio;
            DTPFechaPartida.Value = _objInternacional.Fecha_partida.Date;
            CBHoraPartida.SelectedIndex = _objInternacional.Fecha_partida.Hour;
            CBMinutosPartida.SelectedIndex = _objInternacional.Fecha_partida.Minute;
            DTPFechaArribo.Value = _objInternacional.Fecha_arribo.Date;
            CBHoraArribo.SelectedIndex = _objInternacional.Fecha_arribo.Hour;
            CBMinutosArribo.SelectedIndex = _objInternacional.Fecha_arribo.Minute;
            TBDocumentacion.Text = _objInternacional.Documentacion;

            TBNumero.Enabled = false;
            CBCompania.Enabled = true;
            CBTerminal.Enabled = true;
            TBAsientos.Enabled = true;
            CBServicio.Enabled = true;
            DTPFechaPartida.Enabled = true;
            CBHoraPartida.Enabled = true;
            CBMinutosPartida.Enabled = true;
            DTPFechaArribo.Enabled = true;
            CBHoraArribo.Enabled = true;
            CBMinutosArribo.Enabled = true;
            TBDocumentacion.Enabled = true;
        }


        private void ActivoAgregar()
        {
            BtnAlta.Enabled = true;
            BtnBaja.Enabled = false;
            BtnModificar.Enabled = false;

            CBCompania.SelectedIndex = -1;
            CBTerminal.SelectedIndex = -1;
            TBAsientos.Text = "";
            CBServicio.Checked = false;
            DTPFechaPartida.Value = DateTime.Today;
            CBHoraPartida.SelectedIndex = -1;
            CBMinutosPartida.SelectedIndex = -1;
            DTPFechaArribo.Value = DateTime.Today;
            CBHoraArribo.SelectedIndex = -1;
            CBMinutosArribo.SelectedIndex = -1;
            TBDocumentacion.Text = "";

            TBNumero.Enabled = false;
            CBCompania.Enabled = true;
            CBTerminal.Enabled = true;
            TBAsientos.Enabled = true;
            CBServicio.Enabled = true;
            DTPFechaPartida.Enabled = true;
            CBHoraPartida.Enabled = true;
            CBMinutosPartida.Enabled = true;
            DTPFechaArribo.Enabled = true;
            CBHoraArribo.Enabled = true;
            CBMinutosArribo.Enabled = true;
            TBDocumentacion.Enabled = true;
        }

        private void TBNumero_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Viajes _unInternacional = null;

                _unInternacional = new AppWinAdministracion.WSTerminalRef.WSTerminal().Buscar_Viaje(Convert.ToInt32(TBNumero.Text));

                if (_unInternacional == null)
                {
                    this.ActivoAgregar();
                }
                else if (_unInternacional is Nacionales)
                {
                    LblError.Text = "El viaje ingresado corresponde a un viaje nacional";
                }
                else
                {
                    _objInternacional = (Internacionales)_unInternacional;
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
                Internacionales _unInternacional = new Internacionales();
                _unInternacional.Numero = Convert.ToInt32(TBNumero.Text);
                _unInternacional.Compania = (Companias)CBCompania.SelectedItem;
                _unInternacional.Terminal = (Terminales)CBTerminal.SelectedItem;
                _unInternacional.Asientos = Convert.ToInt32(TBAsientos.Text);
                _unInternacional.Servicio = CBServicio.Checked;

                DateTime _Fechapartida = new DateTime(DTPFechaPartida.Value.Year, DTPFechaPartida.Value.Month, DTPFechaPartida.Value.Day, CBHoraPartida.SelectedIndex, CBMinutosPartida.SelectedIndex, 0);
                DateTime _Fechaarribo = new DateTime(DTPFechaArribo.Value.Year, DTPFechaArribo.Value.Month, DTPFechaArribo.Value.Day, CBHoraArribo.SelectedIndex, CBMinutosArribo.SelectedIndex, 0);

                _unInternacional.Fecha_partida = _Fechapartida;
                _unInternacional.Fecha_arribo = _Fechaarribo;
                _unInternacional.Documentacion = TBDocumentacion.Text;

                _unInternacional.Empleado = _EmpLogueado;

                new AppWinAdministracion.WSTerminalRef.WSTerminal().Alta_Viaje(_unInternacional);
                LblError.Text = "Viaje Internacional dado de alta con éxito";

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

        private void BtnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                new AppWinAdministracion.WSTerminalRef.WSTerminal().Eliminar_Viaje(_objInternacional);
                LblError.Text = "Viaje Internacional eliminado con éxito";

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
                _objInternacional.Numero = Convert.ToInt32(TBNumero.Text);
                _objInternacional.Compania = (Companias)CBCompania.SelectedItem;
                _objInternacional.Terminal = (Terminales)CBTerminal.SelectedItem;
                _objInternacional.Asientos = Convert.ToInt32(TBAsientos.Text);
                _objInternacional.Servicio = CBServicio.Checked;

                DateTime _Fechapartida = new DateTime(DTPFechaPartida.Value.Year, DTPFechaPartida.Value.Month, DTPFechaPartida.Value.Day, CBHoraPartida.SelectedIndex, CBMinutosPartida.SelectedIndex, 0);
                DateTime _Fechaarribo = new DateTime(DTPFechaArribo.Value.Year, DTPFechaArribo.Value.Month, DTPFechaArribo.Value.Day, CBHoraArribo.SelectedIndex, CBMinutosArribo.SelectedIndex, 0);

                _objInternacional.Fecha_partida = _Fechapartida;
                _objInternacional.Fecha_arribo = _Fechaarribo;
                _objInternacional.Documentacion = TBDocumentacion.Text;

                _objInternacional.Empleado = _EmpLogueado;

                new AppWinAdministracion.WSTerminalRef.WSTerminal().Modificar_Viaje(_objInternacional);
                LblError.Text = "Viaje Internacional modificado con éxito";

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
            _objInternacional = null;
            this.ActivoPorDefecto();
        }
    }
}
