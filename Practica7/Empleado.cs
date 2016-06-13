using System;
using System.Collections.Generic;
using System.Text;

namespace Practica7
{
    public class Empleado
    {
        #region Variables
        string nif;
        string nombre;
        int categoria;
        int numHijos;
        int numTrienios;
        #endregion

        #region Contructores
        public Empleado()
        {           
        }

        public Empleado(string nif, string nombre, int categoria, int numHijos, int numTrienios)
        {
            this.nif = nif;
            this.nombre = nombre;
            this.categoria = categoria;
            this.numHijos = numHijos;
            this.numTrienios = numTrienios;
        }
        #endregion

        #region Propiedades
        public string NIF
        {
            get
            {
                return nif;
            }
            set
            {
                nif = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public int Categoria
        {
            get
            {
                return categoria;
            }
            set
            {                
                categoria = value;
            }
        }

        public int NumHijos
        {
            get
            {
                return numHijos;
            }
            set
            {               
                numHijos = value;
            }
        }

        public int NumTrienios
        {
            get
            {
                return numTrienios;
            }
            set
            {                
                numTrienios = value;
            }
        }
        #endregion
    }
}
