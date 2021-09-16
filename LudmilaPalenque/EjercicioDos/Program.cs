using System;

namespace EjercicioDos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el continente al que quiere viajar: ");
            string continente = Console.ReadLine();
            bool validaC = ValidaContinente(continente);
            Console.WriteLine("Ingrese el metodo de pago: ");
            string metodoPago = Console.ReadLine();
            bool validaP = ValidaPago(metodoPago);
            Console.WriteLine("Ingrese la cantidad de dias: ");
            int cantidadDias = int.Parse(Console.ReadLine());
            int precioDia = 100;
            float descuento = 0;
            int precioTotal = cantidadDias * precioDia;
            float resultadoDescuento = 0;
            bool flag = true;
            float otroMedio = 0;
            float resultadoOtroMedio = 0;
            do
            {
                if (validaP && validaC )
                {
                    switch (continente)
                    {
                        case "America":

                            descuento = precioTotal * 0.15f;
                            resultadoDescuento = (float)precioTotal - descuento;
                            Console.WriteLine($"El precio final con 15% de descuento es: ${resultadoDescuento}");
                            if (metodoPago == "debito")
                            {
                                float descuentoDebito = (resultadoDescuento * 0.1f);
                                float resultadoDescuentoDebito = resultadoDescuento - descuentoDebito;
                                Console.WriteLine($"Al pagar con debito, usted obtiene un descuento del 10%, lo cual el importe final es: ${resultadoDescuentoDebito}");
                            }
                            if (metodoPago == "cheque")
                            {
                                float recargoCheque = resultadoDescuento * 0.15f;
                                float resultadoRecagoCheque = recargoCheque + resultadoDescuento;
                                Console.WriteLine($"Al pagar con cheque se recarga un 15% de impuesto, lo cual el monto final es: ${resultadoRecagoCheque}");


                            }

                            break;
                        case "Africa":
                        case "Oceania":
                            descuento = precioTotal * 0.3f;
                            resultadoDescuento = precioTotal - descuento;
                            Console.WriteLine($"El precio total con el 30% de descuento es: ${resultadoDescuento}");
                            if (metodoPago == "mercado pago" || metodoPago == "efectivo")
                            {
                                float descuentoMPE = resultadoDescuento * 0.15f;
                                float resultadoMPE = resultadoDescuento - descuentoMPE;
                                Console.WriteLine($"Al pagar con Mercado Pago o efectivo, usted obtiene un descuento del 15%, lo cual el importe final es ${resultadoMPE}");
                            }
                            if (metodoPago == "cheque")
                            {
                                float recargoCheque = resultadoDescuento * 0.15f;
                                float resultadoRecagoCheque = recargoCheque + resultadoDescuento;
                                Console.WriteLine($"Al pagar con cheque se recarga un 15% de impuesto, lo cual el monto final es: ${resultadoRecagoCheque}");


                            }
                            break;
                        case "Europa":
                            descuento = precioTotal * 0.2f;
                            resultadoDescuento = precioTotal - descuento;
                            Console.WriteLine($"El precio final con 20% de descuento es: ${resultadoDescuento}");
                            if (metodoPago == "debito")
                            {
                                float descuentoDebito = resultadoDescuento * 0.15f;
                                float resultadoDescDebito = resultadoDescuento - descuentoDebito;
                                Console.WriteLine($"Al pagar con debito usted obtiene un descuento del 20% lo cual el importe final es: ${resultadoDescDebito}");

                            }
                 
                            if (metodoPago == "mercado pago")
                            {
                                float descuentoMP = resultadoDescuento * 0.10f;
                                float resultadoMP = resultadoDescuento - descuentoMP;
                                Console.WriteLine($"Al pagar con Mercado Pago usted obtiene un descuento del 10% lo cual el importe final es ${resultadoMP}");

                            }
                            else if (metodoPago == "credito" || metodoPago== "efectivo" || metodoPago =="leliq" || metodoPago=="cheque")
                            {
                      
                                otroMedio = resultadoDescuento * 0.5f;
                                resultadoOtroMedio = resultadoDescuento - otroMedio;
                                Console.WriteLine($"Al pagar con otro medio usted obtiene un descuento del 5% lo cual el importe final es ${resultadoOtroMedio}");

                                if (metodoPago == "cheque")
                                {
                                    float recargoCheque = resultadoOtroMedio * 0.15f;
                                    float resultadoRecagoCheque = recargoCheque + resultadoOtroMedio;
                                    Console.WriteLine($"Al pagar con cheque se recarga un 15% de impuesto, lo cual el monto final es: ${resultadoRecagoCheque}");


                                }
                            }

                   


                            break;

                        default:
                            float recargo = precioTotal * 0.20f;
                            float resultadoRecargo = precioTotal + recargo;
                            Console.WriteLine($"En otros continentes tiene un recago del 20%, lo cual el importe final es: ${resultadoRecargo}");
                            if (metodoPago == "cheque")
                            {
                                float recargoCheque = resultadoRecargo * 0.15f;
                                float resultadoRecagoCheque = recargoCheque + resultadoRecargo;
                                Console.WriteLine($"Al pagar con cheque se recarga un 15% de impuesto, lo cual el monto final es ${resultadoRecagoCheque}");


                            }
                            break;
                    }
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Ingrese un continente o metodo de pago valido.");
                    break;
                }





            } while (flag);









            Console.ReadKey();
        }


        static bool ValidaContinente(string continente) 
        {
            if (continente == "America" || continente=="Asia" || continente== "Europa" || continente == "Africa" || continente== "Oceania" )
            {
                return true;
            }
            return false;
        }

        static bool ValidaPago(string pago) 
        {
            if (pago == "debito" || pago == "credito" || pago == "efectivo" || pago == "mercado pago" || pago== "cheque" || pago == "leliq")
            {
                return true;

            }
            return false;
        }
    }

}
