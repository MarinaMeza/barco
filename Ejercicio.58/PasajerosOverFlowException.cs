﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._58
{
    class PasajerosOverFlowException : Exception
    {
        protected Exception _excepcionInterna;
        protected string _nombreClase;
        protected string _nombreMetodo;

        public PasajerosOverFlowException(string mensaje, string clase, string metodo) 
            : this(mensaje, clase, metodo, null)
        {

        }

        public PasajerosOverFlowException(string mensaje, string clase, string metodo, Exception innerException)
            : base(mensaje, innerException)
        {
            this._excepcionInterna = innerException;
            this._nombreClase = clase;
            this._nombreMetodo = metodo;
        }

        public Exception ExcepcionInterna { get { return this._excepcionInterna; } }
        public string NombreClase { get { return this._nombreClase; } }
        public string NombreMetodo { get { return this._nombreMetodo; } }
    }
}
