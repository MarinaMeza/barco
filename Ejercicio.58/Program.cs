using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio._58
{
    class Program
    {
        static void Main(string[] args)
        {
            Crucero unCrucero = new Crucero("Brasil", 3);
            Transatlantico unTransatlantico = new Transatlantico("Australia", 3);

            Pasajero pasajeroC1 = new Pasajero("Cecilia", "Meza",Rango.Cliente);
            Pasajero pasajeroC2 = new Pasajero("Albert", "Rodriguez", Rango.Cliente);
            Pasajero pasajeroC3 = new Pasajero("Susana", "Perez", Rango.Capitan);

            Pasajero pasajeroT1 = new Pasajero("Marina", "Meza", Rango.Cliente);
            Pasajero pasajeroT2 = new Pasajero("Gabriel", "Mendoza", Rango.Cocinero);
            Pasajero pasajeroT3 = new Pasajero("Fidel", "Meza", Rango.Capitan);
            Pasajero pasajeroT4 = new Pasajero("Susana", "Perez", Rango.Camarero);

            unCrucero.Ingresar(pasajeroC1);
            unCrucero.Ingresar(pasajeroC2);
            unCrucero.Ingresar(pasajeroC3);
            unCrucero.Ingresar(pasajeroT3);
            unTransatlantico.Ingresar(pasajeroT1);
            unTransatlantico.Ingresar(pasajeroT2);
            unTransatlantico.Ingresar(pasajeroT3);
            unTransatlantico.Ingresar(pasajeroT4);

            Console.ReadLine();
        }
    }
}
