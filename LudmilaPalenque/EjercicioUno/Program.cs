using System;

namespace EjercicioUno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());
            float resto;
            int resultado;
            double resultadoCuadrado = 0;
            if (num1 == num2)
            {
                resultadoCuadrado = Math.Pow(num1, 2);
                Console.WriteLine("El cuadrado del numero es: " + resultadoCuadrado );

            }
            if (num1%num2==0)
            {
                resultado = num1 - num2;
                Console.WriteLine("El resultado de la resta es: " + resultado);
            }
          
            else
            {

                if (true)
                {
                    resto = num1 % num2;
                    Console.WriteLine($"El resto es: {resto}");
                }

                if (resto > 3)
                {
                    Console.WriteLine("El resto es mayor a 3. ");
                }

            }


            Console.ReadKey();

        }
    }
}
