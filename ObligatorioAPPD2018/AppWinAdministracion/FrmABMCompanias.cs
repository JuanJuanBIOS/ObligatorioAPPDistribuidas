using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace AppWinAdministracion
{
    public partial class FrmABMCompanias : Form
    {
        //creo atributo que mantiene en memoria el objeto Compania con el cual se esta trabajando
        
        private Compania _objCompania = null;

        public FrmABMCompanias()
        {
            InitializeComponent();
        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {

        }

    }
}
