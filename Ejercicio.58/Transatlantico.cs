using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio._58
{
    [Serializable]
    [XmlInclude(typeof(Barco))]
    public class Transatlantico : Barco,IServicioComerdor
    {
        protected List<Pasajero> _pasajeros;

        public Transatlantico(string pDestino, int pCantMaxPasajeros) 
            : base(pDestino, pCantMaxPasajeros) 
        {
            this._pasajeros = new List<Pasajero>(pCantMaxPasajeros-1);
        }

        public override List<Pasajero> Pasajeros { get { return this._pasajeros; } }

        public void ServirComida(string pComida)
        {
            Console.WriteLine("Comida a servir" + pComida);
        }

        public override void Ingresar(Pasajero pPasajero) {
            try
            {
                if (this._pasajeros.Capacity <= this._cantMaxPasajeros)
                {
                    this._pasajeros.Add(pPasajero);
                    Console.WriteLine("AGREGO Transatlantico!");
                }
                else { throw new PasajerosOverFlowException("Se alcanzó la cantidad maxima de pasajeros", this.ToString(), "Ingresar"); }

            }
            catch (PasajerosOverFlowException e)
            {
                string ruta = AppDomain.CurrentDomain.BaseDirectory + "log.txt";

                try
                {
                    StreamWriter sw = new StreamWriter(ruta, true);
                    sw.WriteLine("--------PasajerosOverFlowException--------");
                    sw.WriteLine(DateTime.UtcNow);
                    sw.WriteLine(this.GetType().Name);
                    sw.Close();
                }
                catch (Exception)
                {
                    Console.WriteLine("No se pudo escribir el archivo");
                }
            }
        }
    }
}
