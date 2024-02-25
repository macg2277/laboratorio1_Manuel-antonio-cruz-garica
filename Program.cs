using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Laboratorio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            double a, b ;
            double PI = 3.1416;
            bool esNumero;

            /*
             1-Área de un rectángulo. (A = b*h)
             2- Area  de un triángulo. (A = (b*h)/2)
             3- Area  de un círculo. (A = π*r²)
             4- Volumen de un cilindro. (V = π*r²*h)
             5- Volumen de una esfera. (V = (4/3)*π*r³)
             6- Salir
             */

            while (opcion != 6)
            {
                Console.WriteLine("*********Seleccione una opcion de la lista**********");
                Console.WriteLine("1-Area de un Rectangulo ");
                Console.WriteLine("2-Area de un Rentangulo");
                Console.WriteLine("3-Area de un circulo");
                Console.WriteLine("4-Volumen de un cilindro");
                Console.WriteLine("5-Volumen de una esfera");
                Console.WriteLine("6-Salir");

                // TryParse: verifica si el valor ingresado es del tipo de dato requerido, en este caso "int"
                // si es del tipo int devuelve true y asigna a la variable opcion el valor que se ingreso
                // si no es del tipo int devuelve false y le asigna 0 a la variable opcion.
                esNumero = int.TryParse(Console.ReadLine(), out opcion);

                if (esNumero)
                {
                    if (opcion == 1)
                    {
                        Console.Write("Ingrese la base : ");
                        a = Int32.Parse(Console.ReadLine());
                        Console.Write("Ingrese la altura: ");
                        b = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("El Area de un rectangulo es: {0:N2}", AreaRectangulo(a, b));
                    }
                    else if (opcion == 2)
                    {
                        Console.Write("Ingrese la base: ");
                        a = Int32.Parse(Console.ReadLine());
                        Console.Write("Ingrese la altura: ");
                        b = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("El Area del Triangulo es: {0:N2}", AreaTriangulo(a, b));
                    }

                    else if (opcion == 3)
                    {
                        Console.Write("Ingrese el radio : ");
                        a = double.Parse(Console.ReadLine());
                       
                        Console.WriteLine("El area del ciruclo es: {0:N2}", AreaCirculo(a));
                    }

                    else if (opcion == 4)
                    {
                        Console.Write("Ingrese el radio del cilindro: ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese la altura del cilindro: ");
                        b = double.Parse(Console.ReadLine());

                        Console.WriteLine("El volumen del cilindro es: {0:N2}", VolumenCilindro(a,b));
                    }
                    else if (opcion == 5)
                    {
                        Console.Write("Ingrese el radio: ");
                        a = Int32.Parse(Console.ReadLine());
                        
                        Console.WriteLine("El Volumen de la esfera es: {0:N2}", VolumenEsfera(a));
                    }

                    else if (opcion == 6)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Opcion no valida");
                    }
                }
                else
                {
                    Console.WriteLine("El valor ingresado no es valido");
                }

            }
            Console.Write("BYEEE!!!");
        }

        static double AreaRectangulo(double Ba, double Hb)
        {

            return Ba * Hb;
        }

        static Double AreaTriangulo(double Ba, double Hb)
        {

            return (Ba* Hb)/2;
        }
        static double AreaCirculo(double rA)
        {

            return rA * Math.PI;
        }

        static double VolumenCilindro(double rA,double rb)
        {

            return Math.PI* (rA*rA) *rb ;
        }

        static double VolumenEsfera(double rA)
        {
            return ((4/3) * Math.PI * (rA*rA*rA));
        }
    }


}
 