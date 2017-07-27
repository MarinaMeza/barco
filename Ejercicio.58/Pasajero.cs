using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._58
{   
    [Serializable]
    public class Pasajero
    {
        public string apellido;
        public string nombre;
        public Rango rango;

        public Pasajero(string pNombre, string pApellido, Rango pRango) 
        {
            this.apellido = pApellido;
            this.nombre = pNombre;
            this.rango = pRango;
        }
    }
}
