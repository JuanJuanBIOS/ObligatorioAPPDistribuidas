using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;
using Logica;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Viajes> _lista = null;

            _lista = FabricaLogica.getLogicaViaje().Listar_Todos_Viajes();
        }
    }
}
