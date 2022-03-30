    namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para ter seu fatorial: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Factorial(num));
            Console.ReadLine();
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
            return Console.WriteLine("O resultado é: ", resultado;
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