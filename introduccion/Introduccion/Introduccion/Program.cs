using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
namespace Introduccion
{
    internal class Program
    {
        // String // string 
        // int  // int32 // int64
        // decimal 
        // float
        // bool
        // double
        // char
        // byte
        //clases 
        //
        public static int gradosCentigradosAFeherenhit(int grados)
        {

            return grados + 32;
        }
        //921 = 1      444=3
        public static int ContarDigitosPares(int n)
        {
            int contador = 0;
            if (n == 0)
                return 1;


            while (n > 0)
            {
                int d = n % 10;
                n /= 10;
                if (d % 2 == 0)
                {
                    contador++;
                }

            }

            return contador;
        }

        public static double AreaCirculo(double radio)
        {

            return Math.PI * Math.Pow(radio, 2);
        }

        public static int mayorde5Numeros(int a, int b, int c, int d, int e)
        {

            int mayor = a;
            if (mayor < b)
            {
                mayor = b;
            }
            if (mayor < c)
            {
                mayor = c;
            }
            if (mayor < d)
            {
                mayor = d;
            }
            if (mayor < e)
            {
                mayor = e;
            }

            return mayor;
        }

        public static double AreaCuadrado(double lado)
        {
            return lado * lado;
        }

        public static double PerimetroRectangulo(double baseRect, double altura)
        {
            return 2 * (baseRect + altura);
        }

        public static int ContarDigitosImpares(int n)
        {
            int contador = 0;
            if (n == 0)
                return 0;

            n = Math.Abs(n);
            while (n > 0)
            {
                int d = n % 10;
                n /= 10;
                if (d % 2 != 0)
                {
                    contador++;
                }
            }

            return contador;
        }

        public static bool EsPrimo(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public static long Factorial(int n)
        {
            if (n < 0) return 0;
            long resultado = 1;
            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        public static void Mayor5()
        {
            try
            {
                String entrada = "";
                Console.WriteLine("Mayor de 5 numeros");
                Console.Write("Ingresa a: ");
                entrada = Console.ReadLine();
                int a = int.Parse(entrada);
                Console.Write("Ingresa b : ");
                entrada = Console.ReadLine();
                int b = int.Parse(entrada);
                Console.Write("Ingresa c : ");
                entrada = Console.ReadLine();
                int c = int.Parse(entrada);
                Console.Write("Ingresa d : ");
                entrada = Console.ReadLine();
                int d = int.Parse(entrada);
                Console.Write("Ingresa e : ");
                entrada = Console.ReadLine();
                int e = int.Parse(entrada);

                int mayor = mayorde5Numeros(a, b, c, d, e);
                Console.WriteLine($"El mayor es {mayor}");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }

        }
        public static void ContarParesOpcion()
        {
            Console.WriteLine("Contar pares del numero");
            Console.WriteLine("Ingresa el numero n :");

            try
            {
                String entrada = Console.ReadLine();
                int n = int.Parse(entrada);
                int count = ContarDigitosPares(n);
                Console.WriteLine($"El numero {n} tiene {count} digitos pares");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }
        public static void Conversor()
        {
            Console.WriteLine("Conversor de grados centrigrados a farenhit");
            Console.WriteLine("Ingresa la temperatura:");

            try
            {
                String entrada = Console.ReadLine();
                int temperatura = int.Parse(entrada);
                int temperaturaF = gradosCentigradosAFeherenhit(temperatura);
                Console.WriteLine($"La temperatura en grados F es {temperaturaF}");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }
        public static void CalcularAreaCirculoOpcion()
        {
            Console.WriteLine("Calcular el area de un circulo");
            Console.Write("Ingresa el radio del circulo: ");

            try
            {
                String entrada = Console.ReadLine();

                double radio = double.Parse(entrada);
                double area = AreaCirculo(radio);

                // Mostramos el resultado formateado a 2 decimales (:F2)
                Console.WriteLine($"El area del circulo con radio {radio} es: {area:F2}");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        public static void CalcularAreaCuadradoOpcion()
        {
            Console.WriteLine("Calcular el area de un cuadrado");
            Console.Write("Ingresa el lado del cuadrado: ");

            try
            {
                String entrada = Console.ReadLine();
                double lado = double.Parse(entrada);
                double area = AreaCuadrado(lado);
                Console.WriteLine($"El area del cuadrado es: {area:F2}");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        public static void CalcularPerimetroRectanguloOpcion()
        {
            Console.WriteLine("Calcular el perimetro de un rectangulo");
            try
            {
                Console.Write("Ingresa la base: ");
                String entrada = Console.ReadLine();
                double baseRect = double.Parse(entrada);
                Console.Write("Ingresa la altura: ");
                entrada = Console.ReadLine();
                double altura = double.Parse(entrada);
                double perimetro = PerimetroRectangulo(baseRect, altura);
                Console.WriteLine($"El perimetro del rectangulo es: {perimetro:F2}");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        public static void ContarImparesOpcion()
        {
            Console.WriteLine("Contar impares del numero");
            Console.WriteLine("Ingresa el numero n :");

            try
            {
                String entrada = Console.ReadLine();
                int n = int.Parse(entrada);
                int count = ContarDigitosImpares(n);
                Console.WriteLine($"El numero {n} tiene {count} digitos impares");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        public static void VerificarPrimoOpcion()
        {
            Console.WriteLine("Si el numero es primo");
            Console.WriteLine("Ingresa el numero n :");

            try
            {
                String entrada = Console.ReadLine();
                int n = int.Parse(entrada);
                bool primo = EsPrimo(n);
                if (primo)
                {
                    Console.WriteLine($"El numero {n} es primo");
                }
                else
                {
                    Console.WriteLine($"El numero {n} no es primo");
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        public static void CalcularFactorialOpcion()
        {
            Console.WriteLine("Factorial n");
            Console.WriteLine("Ingresa el numero n :");

            try
            {
                String entrada = Console.ReadLine();
                int n = int.Parse(entrada);
                long resultado = Factorial(n);
                Console.WriteLine($"El factorial de {n} es {resultado}");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        public static void Menu()
        {
            Console.WriteLine(@"Menu de opciones 
            1. Conversor 
            2. Mayor de 5 numeros
            3. Contar pares del numero
            4. Calcular area de un circulo
            5. Realizar el area de un cuadrado
            6. Perimetro del rectangulo
            7. Contar digitos impares
            8. Si el numero es primo
            9. Factorial n
            0. Salir");
        }

        static void Main(string[] args)
        {

            while (true)
            {
                Menu();
                String opcion = Console.ReadLine();
                if (string.IsNullOrEmpty(opcion))
                    continue;
                opcion = opcion.Trim();
                if ("1".Equals(opcion))
                {
                    Conversor();
                    continue;
                }
                if ("2".Equals(opcion))
                {
                    Mayor5();
                    continue;
                }
                if ("3".Equals(opcion))
                {
                    ContarParesOpcion();
                    continue;
                }
                if ("4".Equals(opcion))
                {
                    CalcularAreaCirculoOpcion();
                    continue;
                }
                if ("5".Equals(opcion))
                {
                    CalcularAreaCuadradoOpcion();
                    continue;
                }
                if ("6".Equals(opcion))
                {
                    CalcularPerimetroRectanguloOpcion();
                    continue;
                }
                if ("7".Equals(opcion))
                {
                    ContarImparesOpcion();
                    continue;
                }
                if ("8".Equals(opcion))
                {
                    VerificarPrimoOpcion();
                    continue;
                }
                if ("9".Equals(opcion))
                {
                    CalcularFactorialOpcion();
                    continue;
                }
                if ("0".Equals(opcion))
                {
                    Console.WriteLine("Adios!");
                    break;
                }
            }
        }
    }
}