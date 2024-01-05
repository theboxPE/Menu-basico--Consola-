using System;

namespace Funcinones2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Elija la opcion deseada");
                Console.Write("[1]Sumadora [2]Saludar [3]Par o Impar [4]Salir: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Sumadora();
                        break;
                    case 2:
                        Saludar();
                        break;
                    case 3:
                        ParImpar();
                        break;
                    case 4:
                        Salir();
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }
            } while (opcion != 4);
        }

        static void Sumadora()
        {
            Console.Write("Ingrese el 1er numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el 1er numero: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine(n1+n2);
            Console.ReadKey();
        }
        static void Saludar()
        {
            Console.WriteLine("Hola! Como estas?");
            Console.ReadKey();
        } 
        static void ParImpar()
        {
            Console.Write("Ingrese el numero: ");
            int n = int.Parse(Console.ReadLine());
            int m = n * n;
            if (n % 2 == 0)
            {
                Console.WriteLine(n+" es par y "+m+" es el cuadrado");
                Console.WriteLine("{0} es par y {1} es el cuadrado",n,m);
                Console.WriteLine($"{n} es par y {n*n} es el cuadrado");
            }
            else
                Console.WriteLine(n + " es impar");
            Console.ReadKey();
        }
        static void Salir()
        {
            Console.WriteLine("Saliendo del programa...");
            Environment.Exit(0);
        }
    }
}
