using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsolaPrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            //EntidadesCompartidas.Companias C = new EntidadesCompartidas.Companias("Compania", "Direccion", "tel");
            Persistencia.FabricaPersistencia.getPersistenciaTerminal().Buscar_Terminal("DUR");
        }
    }
}
