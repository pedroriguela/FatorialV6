    namespace Fatorial
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Digite 1 para calcular usando Loop e 2 para Recursiva: ");
            int escolha = Convert.ToInt32(Console.ReadLine());
            int modeloCalc = 0;

            Console.WriteLine("Digite um número para ter seu fatorial: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Factorial(num));
            Console.ReadLine();

            if (escolha == 1)
            {
                modeloCalc = Fact(num);
            }
            else
            {
                modeloCalc = Factorial(num);
            }

        }
        

        public static int Fact(int num)
        {
            int resultado = 1;
            
            if ((num == 0) || (num ==1))
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