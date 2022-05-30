using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um Número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int fatorial = 1;
            if (numero < 0)
            {
                Console.WriteLine("Digite um número natural positivo.");
            }
            else if (numero >= 2)
            {
                for (int i = numero; i >= 1; i--)
                {
                    fatorial = fatorial * i;
                    Console.WriteLine("{0}! = {1}",i,fatorial);   
                }
            }
        }
    }
}
