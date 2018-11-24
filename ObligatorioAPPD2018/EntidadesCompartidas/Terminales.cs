using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    [Serializable]
    public class Terminales
    {
        //Atributos
        private string _codigo;
        private string _ciudad;
        private string _pais;
        private List<string> _facilidades;

        //Propiedades
        public string Codigo
        {
            get { return _codigo; }

            set
            {
                if (value.Length == 3)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (!Char.IsLetter(Convert.ToChar(value.Substring(i, 1))))
                        {
                            throw new Exception("ERROR: El código de la terminal debe constar de tres letras");
                        }
                    }
                    _codigo = value;
                }
                else
                {
                    throw new Exception("ERROR: El código ingresado debe constar de 3 letras");
                }
            }
        }

        public string Ciudad
        {
            get { return _ciudad; }

            set
            {
                if (value.Length <= 50)
                {
                    _ciudad = value;
                }
                else
                {
                    throw new Exception("ERROR: El nombre de la ciudad no puede contener más de 50 caracteres");
                }
            }
        }

        public string Pais
        {
            get { return _pais; }

            set
            {
                if (value == "Argentina" || value == "Brasil" || value == "Paraguay" || value == "Uruguay")
                {
                    _pais = value;
                }
                else
                {
                    throw new Exception("ERROR: El país debe pertenecer al MERCOSUR");
                }
            }
        }

        public List<string> ListaFacilidades
        {
            get { return _facilidades; }
            set
            {
                if (value != null)
                {
                    _facilidades = value;
                }
                else
                {
                    throw new Exception("ERROR: La lista de facilidades ingresada no es válida");
                }
            }
        }


        //Constructor
        public Terminales(string pCodigo, string pCiudad, string pPais, List<string> pFacilidades)
        {
            Codigo = pCodigo;
            Ciudad = pCiudad;
            Pais = pPais;
            ListaFacilidades = pFacilidades;
        }

        //Constructor por defecto
        public Terminales()
        {
        }
    }
}
