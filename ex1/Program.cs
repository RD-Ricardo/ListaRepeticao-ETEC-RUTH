using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double psTotal = 0, psCaixa;
            Console.WriteLine("Peso total que será carregado por um caminhão.");
            for (int i = 1; i <= 25; i++)
            {
                Console.Write("Digite o peso da caixa {0}: ", i);
                psCaixa = Convert.ToDouble(Console.ReadLine());
                psTotal += psCaixa;
            }
            Console.WriteLine("Peso total carregado pelo caminhão: {0}",psTotal);
        }
    }
}
