using System;

namespace Empleado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Ingrese su nombre por favor ");
            string nombre = Console.ReadLine();

            Console.WriteLine(" Por favor ingrese el numero de años");
            int antiguedad = int.Parse(Console.ReadLine());

            Console.WriteLine(" Por favor ingrese la cantidad de horas trabajadas en el mes ");
            int cantidadhoras = int.Parse(Console.ReadLine());

            Console.WriteLine(" Por favor ingrese el valor de la hora");
            double valorhora = double.Parse(Console.ReadLine());

            int bono =  antiguedad * 50000;
            double totalpagarhora = cantidadhoras * valorhora;
            double totalcobrar = bono + totalpagarhora;
            double descuento = totalcobrar * 0.15;
            double valorneto = totalcobrar - descuento;


            Console.WriteLine(nombre);
            Console.WriteLine(" La cantidad de años en la enpresa es :" + antiguedad );
            Console.WriteLine(" Valor de la hora es : + valor hora ");
            Console.WriteLine(" Total a cobrar en bruto es: " + totalcobrar);
            Console.WriteLine(" El descuento es : " + descuento);
            Console.WriteLine("valor a cobrar es "); 



        }
    }
}
