using System;
using System.Diagnostics;
using System.Threading;

namespace Fatorial
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Digite 1 para calcular usando Loop e 2 para Recursiva: ");
            var typedString = Console.ReadLine();
            bool parseSuccess = int.TryParse(typedString, out int result);


            if (parseSuccess)
                Console.WriteLine("\n Modelo de cálculo escolhido com sucesso!");

            else
                Console.WriteLine("Ops, você digitou um número inválido, por favor digite 1 para Loop e 2 para Recursiva.");
            Console.WriteLine();
            
            int tipoAlgoritmo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            long modeloCalc = 0;


            Console.WriteLine("Digite um número para ter seu fatorial: ");
            long numDigitado = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\n");

            var stopWatch = Stopwatch.StartNew();


            if (tipoAlgoritmo == 1)
            {
                Console.WriteLine("O modelo escolhido foi Loop");
                modeloCalc = CalcularFatorialUsandoLoop(numDigitado);
            }

            else if (tipoAlgoritmo == 2)
            {
                Console.WriteLine("O modelo escolhido foi Recursivo");
                modeloCalc = CalcularFatorialUsandoRecursividade(numDigitado);
            }

            Console.WriteLine("O fatorial de {0} é {1} usando o método {2}", numDigitado, modeloCalc, tipoAlgoritmo);
            stopWatch.Stop();
            Console.WriteLine($"O tempo de execução foi de: {stopWatch.ElapsedMilliseconds}ms");
            Console.ReadLine();
                
        }


        public static long CalcularFatorialUsandoLoop(long numDigitado)
        {
            long resultado = 1;

            if ((numDigitado == 0) || (numDigitado == 1))
            {
                return 1;
            }

            for (long i = numDigitado; i > 0; i--)
            {
                resultado *= i;
            }
            return resultado;

        }

        public static long  CalcularFatorialUsandoRecursividade(long numDigitado)
        {

            if ((numDigitado == 0) || (numDigitado == 1))
            {
                return 1;
            }

            return numDigitado * CalcularFatorialUsandoRecursividade(numDigitado - 1);
        }
    }
}