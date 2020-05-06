using System;

namespace Matematicas
{
    class Program
    {
        static void Main(string[] args)
        {
            //raiz cuadrada
            System.Console.WriteLine("la raiz cuadrada de 9 = " + Math.Sqrt(9));

            //numero mayor
            System.Console.WriteLine("el numero mas grande entere 5 y 7 = " + Math.Max (5, 7));

            //redondear
            System.Console.WriteLine("redondear el numero 8.55 = " + Math.Round(8.55));

            //quitar las decimales
            System.Console.WriteLine("sin decimales 100.15612 = " + Math.Truncate(100.15612));

            //potencia
            int numero = 3, potencia = 4;
            Double elevadoAlCuarta = Math.Pow(numero, potencia);
            System.Console.WriteLine(string.Format("{0} elevado a la potencia {1} es {2}", numero, potencia, elevadoAlCuarta));

            //poner signo
            System.Console.WriteLine("el signo de 4 = " + Math.Sign(4));

            //numero mayor sin importar el signo
            System.Console.WriteLine("el numero mayot sin importar su signo entre -7 y 6 = " + System.Math.Max(System.Math.Abs(-7), System.Math.Abs(6))); 
        }
    }
}
