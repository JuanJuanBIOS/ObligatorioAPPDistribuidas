using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;

namespace ConsolaParaPrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Companias _unaCompania = null;

            _unaCompania = Logica.FabricaLogica.getLogicaCompania().Buscar_Compania("EGA");
        }
    }
}
