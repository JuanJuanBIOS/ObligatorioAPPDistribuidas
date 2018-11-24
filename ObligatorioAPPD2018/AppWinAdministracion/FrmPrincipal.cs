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
    public partial class FrmPrincipal : Form
    {

        //Atributo de formulario

        private Empleados _EmpLogueado;

        public FrmPrincipal(Empleados pEmp)
        {
            InitializeComponent();
            _EmpLogueado = pEmp;
        }

        private void BtnABMCompanias_Click(object sender, EventArgs e)
        {
            Form _unForm = new FrmABMCompanias();
            _unForm.ShowDialog();

        }

        private void BtnABMTerminales_Click(object sender, EventArgs e)
        {
            Form _unForm = new FrmABMTerminales();
            _unForm.ShowDialog();

        }


        private void BtnABMNacionales_Click(object sender, EventArgs e)
        {
            Form _unForm = new FrmABMNacionales(_EmpLogueado);
            _unForm.ShowDialog();
        }

        private void BtnABMInternacionales_Click(object sender, EventArgs e)
        {
            Form _unForm = new FrmABMInternacionales(_EmpLogueado);
            _unForm.ShowDialog();
        }

        private void BtnABMEmpleados_Click(object sender, EventArgs e)
        {
            Form _unForm = new FrmABMEmpleados(_EmpLogueado);
            _unForm.ShowDialog();
        }
    }
}
