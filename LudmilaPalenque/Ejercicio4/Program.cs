using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar;
            int cantRojos = 0;
            int cantRojosPrecioMayor = 0;
            int cantVehiculosPrecioMenor = 0;
            int precioMayor = int.MinValue;
            string colorDelMasCaro = "";
            int cantPromedio = 0;
            int sumaProm = 0;
            int promedio = 0;
            do
            {
                Console.WriteLine("Ingrese el color del vehículo (Sólo se admite verde/rojo/amarillo) : ");
                string color = Console.ReadLine();
                Console.WriteLine("Ingrese el precio del vehículo: ");
                int precio = int.Parse(Console.ReadLine());

                if ((color == "verde" || color == "rojo" || color == "amarillo") && (precio<10000 && precio>0))
                {
                   
                    if (precio > 0 && precio < 10000)
                    {
                        cantPromedio++;
                        sumaProm += precio;
                        promedio = sumaProm / cantPromedio;


                    }

                    if (color == "rojo")
                    {
                        cantRojos++;

                    }
                    if (color == "rojo" && precio > 5000)
                    {
                        cantRojosPrecioMayor++;

                    }
                    if (precio < 5000)
                    {
                        cantVehiculosPrecioMenor++;
                    }
                    if (precio > precioMayor)
                    {
                        precioMayor = precio;
                        colorDelMasCaro = color;
                    }
                }
              

                Console.WriteLine("Desea continuar? s/n");
                continuar = char.Parse(Console.ReadLine());
            } while (continuar=='s');
            Console.WriteLine($"La cantidad de autos rojos es: {cantRojos}");
            Console.WriteLine($"La cantidad de rojos con precio mayor a 5000: {cantRojosPrecioMayor}");
            Console.WriteLine($"La cantidad de vehículos con precio inferior a 5000: {cantVehiculosPrecioMenor}");
            Console.WriteLine($"Promedio de vehículos ingresados: {promedio}");
            Console.WriteLine($"El vehículo mas caro es {precioMayor} y su color es {colorDelMasCaro} .");

            Console.ReadKey();
           
        }
    }
}
