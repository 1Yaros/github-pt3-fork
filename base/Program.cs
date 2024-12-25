using System;
using Models;  // Importa la classe Vehicle des de Models

class Program
{
    static void Main(string[] args)
    {
        // Crear un objecte Vehicle
        Vehicle vehicle1 = new Cotxe("Model A", "Tor", 2024, 1199.0, 4);

        // Mostrar la informació del vehicle
        vehicle1.MostrarInformacio();

        // Crear un altre objecte Vehicle
        Vehicle vehicle2 = new Cotxe("Model S", "Tor", 1982, 999.0, 4);
        
        // Mostrar la informació del segon vehicle
        vehicle2.MostrarInformacio();
    }
}
