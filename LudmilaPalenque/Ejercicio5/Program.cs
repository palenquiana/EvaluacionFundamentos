using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            char respuesta;
            int cantVaronesAprobados = 0;
            int sumaMenoresEdad = 0;
            int cantMenoresEdad = 0;
            int sumaAdolescentes = 0;
            int cantAdolescentes = 0;
            int cantMayores = 0;
            int sumaMayores = 0;
            int cantSexoM = 0;
            int sumaSexoM = 0;
            int cantSexoF = 0;
            int sumaSexoF = 0;
            int cantSexoX = 0;
            int sumaSexoX = 0;


            do
            {
                Console.WriteLine("Ingrese el nombre del estudiante: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la edad: ");
                int edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el sexo: ");
                char sexo = char.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la nota del final: ");
                int nota = int.Parse(Console.ReadLine());

                if ((edad>0 && edad<18 ||edad>18 ) && (sexo== 'm' || sexo=='f' || sexo == 'x') && (nota>1 && nota<10))
                {
                    if (sexo=='m'&& nota>=7)
                    {
                        cantVaronesAprobados++;
                    }
                    if (edad<18)
                    {
                        cantMenoresEdad++;
                        sumaMenoresEdad += nota;
                    }
                    if (edad>12 && edad<18)
                    {
                        cantAdolescentes++;
                        sumaAdolescentes += nota;

                        
                    }
                    if (edad>18)
                    {
                        cantMayores++;
                        sumaMayores += nota;

                    }
                    if (sexo=='m')
                    {
                        cantSexoM++;
                        sumaSexoM += nota;
                    }
                    if (sexo=='f')
                    {
                        cantSexoF++;
                        sumaSexoF += nota;


                    }
                    if (sexo=='x')
                    {
                        cantSexoX++;
                        sumaSexoX += nota;

                    }
                   


                }
                Console.WriteLine("Dese continuar? s/n");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta=='s');
            Console.WriteLine($"La cantidad de varones aprobados es: {cantVaronesAprobados}");
            Console.WriteLine($"El promedio de notas de los menores de edad: {sumaMenoresEdad/cantMenoresEdad}");
            Console.WriteLine($"El promedio de notas de los adolescentes: {sumaAdolescentes/cantAdolescentes}");
            Console.WriteLine($"El promedio de notas de los mayores: {sumaMayores/cantMayores}");
            Console.WriteLine($"El promedio de notas de sexo femenino es {sumaSexoF/cantSexoF}. Promedio sexo masculino {sumaSexoM/cantSexoM} y el promedio del sexo no binario es {sumaSexoX/cantSexoX}");

            Console.ReadKey();
        }
    }
}
