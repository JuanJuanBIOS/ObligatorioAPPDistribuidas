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
        private Nacionales _objNacional = null;

        public FrmABMNacionales()
        {
            InitializeComponent();
        }

        private void ActivoPorDefecto()
        {
            BtnAlta.Enabled = false;
            BtnBaja.Enabled = false;
            BtnModificar.Enabled = false;

            TBNumero.Text = "";
            CBCompania.SelectedIndex = 0;
            CBTerminal.SelectedIndex = 0;
            TBAsientos.Text = "";
            TBParadas.Text = "";
            DTPFechaPartida.Value = DateTime.Today;
            CBHoraPartida.SelectedIndex = 0;
            CBMinutosPartida.SelectedIndex = 0;
            DTPFechaArribo.Value = DateTime.Today;
            CBHoraArribo.SelectedIndex = 0;
            CBMinutosArribo.SelectedIndex = 0;

            TBNumero.Focus();

            TBNumero.Enabled = true;
            CBCompania.Enabled = false;
            CBTerminal.Enabled = false;
            TBAsientos.Enabled = false;
            TBParadas.Enabled = false;

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

            CBCompania.SelectedIndex = 0;
            CBTerminal.SelectedIndex = 0;
            TBAsientos.Text = "";
            TBParadas.Text = "";
            DTPFechaPartida.Value = DateTime.Today;
            CBHoraPartida.SelectedIndex = 0;
            CBMinutosPartida.SelectedIndex = 0;
            DTPFechaArribo.Value = DateTime.Today;
            CBHoraArribo.SelectedIndex = 0;
            CBMinutosArribo.SelectedIndex = 0;

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

        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {

        }

        private void BtnBaja_Click(object sender, EventArgs e)
        {

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeshacer_Click(object sender, EventArgs e)
        {

        }

    }
}
