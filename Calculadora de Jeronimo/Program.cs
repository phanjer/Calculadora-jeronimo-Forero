using System;

namespace Calculadora_de_Jeronimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que operacion va a hacer:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Divbision");
            Console.WriteLine("5. Elevado al Cuadrado");
            Console.WriteLine("6. Raiz Cuadrada");
            Console.WriteLine("Digite el numero de acuerdo a la operacion que va a realizar");

            string option = Console.ReadLine();
            double result = 0;

            switch (option)
            {
                case "1":
                    Console.WriteLine("Ingrese un número para sumar:");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el siguiente número:");
                    int num2 = int.Parse(Console.ReadLine());
                    result = Operation(option, num1, num2);
                    break;

                case "2":
                    Console.WriteLine("Ingrese un número para restrar:");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el siguiente número:");
                    num2 = int.Parse(Console.ReadLine());
                    result = Operation(option, num1, num2);
                    break;

                case "3":
                    Console.WriteLine("Ingrese un número para multiplicar:");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el siguiente número:");
                    num2 = int.Parse(Console.ReadLine());
                    result = Operation(option, num1, num2);
                    break;

                case "4":
                    Console.WriteLine("Ingrese un número para dividir:");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el siguiente número:");
                    num2 = int.Parse(Console.ReadLine());
                    result = Operation(option, num1, num2);
                    break;

                case "5":
                    Console.WriteLine("Ingrese el número que va alevear al cuadrado:");
                    num1 = int.Parse(Console.ReadLine());
                    result = Operation(option, num1, 0);
                    break;

                case "6":
                    Console.WriteLine("Ingrese el número del que va a sacar raiz cuadrada:");
                    num1 = int.Parse(Console.ReadLine());
                    result = Operation(option, num1, 0);
                    break;
            }

            printMessage(result);
        }

        static double Operation(string option, int number1, int number2)
        {
            switch (option)
            {
                case "1":
                    return number1 + number2;

                case "2":
                    return number1 - number2;

                case "3":
                    return number1 * number2;

                case "4":
                    return number1 / number2;

                case "5":
                    return number1 * number1;

                case "6":
                    return Math.Sqrt(number1);

                default:
                    return 0;
            }
        }

        static void printMessage(double result)
        {
            Console.WriteLine("El resultado es:" + result);
        }
    }
}
