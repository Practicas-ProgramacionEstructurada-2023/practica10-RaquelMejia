using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Calculo del factorial de un numero.");
                Console.WriteLine("2. Suma de números enteros hasta n.");
                Console.WriteLine("3. Calculo de la serie de Fibonacci.");
                Console.WriteLine("4. Declaracion y asiganción de un arreglo");
                Console.WriteLine("5. Inicializando de un arreglo en la declaracion");
                Console.WriteLine("6. Arreglo de cadenas (strings).");
                Console.WriteLine("7. Salir");
                Console.Write("\nIngrese su opcion: ");

                if (int. TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                    case 1:
                        int num = 6;
                        long resultado = Factorial(num);
                        Console.WriteLine($"El factorial de {num} es {resultado}");
                        break;

                    case 2:
                        int NumEnt = 5;
                        int ResultadoEn = SumarNumeros(NumEnt);
                        Console.WriteLine($"La suma de los numeros enteros desde 1 hasta {NumEnt} es {ResultadoEn}");
                        break;

                    case 3:
                        int NumFibo = 10;
                        for (int i = 0; i < NumFibo; i++)
                        {
                            Console.Write(Fibonacci(i)  + " " );
                        }
                        break;

                    case 4:
                        int[] numeros = new int[5]; //Declaracion de un arreglo de enteros con 5 enteros con 5 elementos
                        numeros[0] = 10;
                        numeros[0] = 20;
                        numeros[0] = 30;
                        numeros[0] = 40;
                        numeros[0] = 50;

                        //Acceder a los elemntos del arreglo
                        Console.WriteLine("El primer elemento del arreglo es: " + numeros[0]);
                        Console.WriteLine("El segundo elemento del arreglo es: " + numeros[1]);
                        break;
                    case 5:
                        int[] numeross = { 10, 20, 30, 40, 50 }; //Inicializando de un arreglo de enteros


                        //Acceder a los elementos del arreglo
                        Console.WriteLine("El primer elemento del arreglo es: " + numeross[0]);
                        break;

                    case 6:

                        string[] nombres = { "Juan", "María", "Carlos", "Ana"};


                        //Recorrido del arreglo de cadenas
                        foreach (string nombre in nombres)
                        {
                            Console.WriteLine("Nombre:" + nombre);
                        }
                        break;

                    case 7:

                        Console.WriteLine("\nSaliendo del programa .....");
                        break;
                    }
                }

                else
                {
                    Console.WriteLine("\nOpcion no valida. Intente de nuevo.");
                }

            } while (opcion !=7);

        }//Fin del Main

        static long Factorial(int n)
        {
            if (n <=1)
            
                return 1;

            else 
                return n * Factorial(n - 1);
            
        }

        static int SumarNumeros(int n)
        {
            if (n <= 0)
                return 0;

            else
                return n +  SumarNumeros(n -1);
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
            
    }
}