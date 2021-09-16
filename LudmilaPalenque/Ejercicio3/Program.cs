using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;
            int kilos;
            string sabor;
            int cantidadKilosTotal = 0;
            int bolsaLiviana = int.MaxValue;
            string saborBolsaLiviana = "";
            int cantidadBolsasCarne = 0;
            int kilosCarne = 0;
            int promedioKilos = 0;
            
            do
            {
                Console.WriteLine("Ingrese el sabor (Solo se acepta carne/pollo/vegetales): ");
                sabor = Console.ReadLine();
                Console.WriteLine("Ingrese cuantos kilos quiere comprar (0 a 500k): ");
                kilos = int.Parse(Console.ReadLine());
                
  
                if ((kilos < 500 && kilos>0) && (sabor == "carne" || sabor == "pollo" || sabor == "vegetales"))
                {
                    if (kilos > 0 && kilos < 500)
                    {
                        cantidadKilosTotal++;
                        promedioKilos += kilos;






                    }
                    if (kilos < bolsaLiviana)
                    {
                        bolsaLiviana = kilos;
                        saborBolsaLiviana = sabor;

                    }
                    if ((sabor == "carne") && (kilos > 0 && kilos < 500))
                    {
                        cantidadBolsasCarne++;
                        kilosCarne += kilos;

                    }

                }









                cantidad++;
            } while (cantidad < 10); 


                
               
            Console.WriteLine($"El promedio de los kilos totales es: {promedioKilos/cantidadKilosTotal} ");
            Console.WriteLine($"La bolsa mas liviana es {bolsaLiviana} y es del sabor {saborBolsaLiviana}");
            Console.WriteLine($"La cantidad de bolsas de carne es {cantidadBolsasCarne} y el promedio de kilos sabor carne es {kilosCarne / cantidadBolsasCarne}");

            Console.ReadKey();
        }
    }
}
