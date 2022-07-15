using System;

namespace Calculadora
{
    class Program
    {
        static float suma(float num1, float num2)
        {
            float res = num1 + num2;
            return res;
        }
        static float resta(float num1, float num2)
        {
            float res = num1 - num2;
            return res;
        }
        static float mult(float num1, float num2)
        {
            float res = num1 * num2;
            return res;
        }
        static float div(float num1, float num2)
        {
            float res = num1 / num2;
            return res;
        }
        static void Main(string[] args)
        {
            float num1, num2, res;
            int op;
            
            do
            {
                Console.WriteLine("Calculadora");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                Console.WriteLine("0. Salir");
                Console.WriteLine("Seleccione una opcion valida:");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("1. Suma");
                        Console.WriteLine("Ingrese un numero:");
                        num1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese un numero:");
                        num2 = float.Parse(Console.ReadLine());
                        res = suma(num1, num2);
                        Console.WriteLine("El resultado es: " +res);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("2. Resta");
                        Console.WriteLine("Ingrese un numero:");
                        num1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese un numero:");
                        num2 = float.Parse(Console.ReadLine());
                        res = resta(num1, num2);
                        Console.WriteLine("El resultado es: " + res);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("3. Multiplicacion");
                        Console.WriteLine("Ingrese un numero:");
                        num1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese un numero:");
                        num2 = float.Parse(Console.ReadLine());
                        res = mult(num1, num2);
                        Console.WriteLine("El resultado es: " + res);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("4. Division");
                        Console.WriteLine("Ingrese un numero:");
                        num1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese un numero:");
                        num2 = float.Parse(Console.ReadLine());
                        res = div(num1, num2);
                        Console.WriteLine("El resultado es: " + res);
                        break;
                    case 5:
                        Console.WriteLine("Salir");
                        break;
                }
            } while (op!=5);
        }
    }
}
