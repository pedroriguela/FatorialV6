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
            int escolha = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            int modeloCalc = 0;


            Console.WriteLine("Digite um número para ter seu fatorial: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            var stopWatch = Stopwatch.StartNew();


            if (escolha == 1)
            {
                Console.WriteLine("O modelo escolhido foi Loop");
                modeloCalc = Fact(num);
            }

            else if (escolha == 2)
            {
                Console.WriteLine("O modelo escolhido foi Recursivo");
                modeloCalc = Factorial(num);
            }

            Console.WriteLine("O fatorial de {0} é {1} usando o método {2}", num, modeloCalc, escolha);
            stopWatch.Stop();
            Console.WriteLine($"O tempo de execução foi de: {stopWatch.ElapsedMilliseconds}ms");
            Console.ReadLine();


        }


        public static int Fact(int num)
        {
            int resultado = 1;

            if ((num == 0) || (num == 1))
            {
                return 1;
            }

            for (int i = num; i > 0; i--)
            {
                resultado *= i;
            }
            return resultado;

        }

        public static int Factorial(int num)
        {

            if ((num == 0) || (num == 1))
            {
                return 1;
            }

            return num * Factorial(num - 1);
        }
    }
}