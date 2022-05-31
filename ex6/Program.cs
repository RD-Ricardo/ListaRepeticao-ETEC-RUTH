using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,somaTotal = 0;
            Console.Write("Digite o somatorio: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0} + {1}",i,somaTotal);
                somaTotal += i;
            }
            Console.WriteLine("O somatorio é {0}", somaTotal);
        }
    }
}
