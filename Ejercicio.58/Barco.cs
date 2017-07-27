using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._58
{
    [Serializable]
    public abstract class Barco
    {
        protected int _cantMaxPasajeros;
        protected bool _motorEncendido;
        protected string _destino;

        public abstract List<Pasajero> Pasajeros { get; }

        public Barco(string pDestino, int pCantMaxPasajeros) {
            this._destino = pDestino;
            this._cantMaxPasajeros = pCantMaxPasajeros;
        }

        public abstract void Ingresar(Pasajero pPasajero);

        public virtual string IndicarDestino() {
            return this._destino.ToString();
        }

        public bool EncenderMotor() {
            if (this._motorEncendido) {
                return true;
            }
            return false;
        }


    }
}
