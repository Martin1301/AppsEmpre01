using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_001
{
    internal class Program
    {
        //Función para calcular la suma de 2 números enteros
        static int Suma(int a, int b)
        {
            return a + b;
        }

        //Función para calcular la resta de 2 números enteros
        static int Resta(int a, int b)
        {
            return a - b;
        }

        //Función para calcular el producto de 2 números enteros
        static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        //Función para calcular la divisíón de 2 números enteros
        static int Dividir(int a, int b)
        {
            return a/b;
        }

        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }

        //Procedimiento que imprime imprimir los 10 primeros números primos.
        static void Primos()
        {

            //variable que contiene el numero que se está probando
            int n = 2;
            //variable que contiene el total de numeros primos encontrados
            int total = 1;

            //iterar mientras el total de numeros primos no se mayor a 10
            while (total <= 10)
            {

                //variable que indica si un numero es primo o no
                Boolean esPrimo = true;

                //se divide el numero (n) entre todos los numeros anterios a el
                //si el modulo de la division es 0 significa que el numero no es primo
                //y se marca la variable esPrimo = false y se termina el ciclo for
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }

                }

                //si despues de ejecutar el ciclo for la variable esPrimo sigue
                //teniendo un valor true entonces se imprime el numero y se incrementa
                // el contador de numeros encontrados total++
                if (esPrimo)
                {
                    Console.WriteLine(n);
                    total++;
                }
                //se incrementa para evaluar el siguiente número
                n++;
            }

        }

        //Procedimiento para convertir de Fahrenheit a Celsius
        static int Celcius(int f)
        {
            return (5*(f - 32)) / 9;
        }

        //Procedimiento para convertir de Celsius a Fahrenheit
        static int Fahrenheit(int c)
        {
            return (9*c/5)+32;
        }

        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[3] Producto de dos números");
                Console.WriteLine("[4] División de dos números");
                Console.WriteLine("[5] Resta de  dos números enteros");
                Console.WriteLine("[6] Imprimir los 10 primeros números primos");
                Console.WriteLine("[7] Convertir temperatura de Fahrenheit a Celsius");
                Console.WriteLine("[8] Convertir temperatura de Celsius a Fahrenheit");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El producto de {0} y {1} es {2}", x, y, Multiplicar(x, y));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La división de {0} y {1} es {2}", c, d, Dividir(c, d));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Ingrese el primer número");
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int m = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", g, m, Resta(g, m));
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Calculando...");
                        Primos();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Ingrese la temperatura a convertir de grado Fahrenheit a Celsius");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La Temperatura en Celsius es {0}",Celcius(f));
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Ingrese la temperatura a convertir de grado Celsius a Fahrenheit");
                        int z = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La Temperatura en Fahrenheit es {0}",Fahrenheit(z));
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));

        }

    }
}
