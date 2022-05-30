using System;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero,maiorNumero = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Digite o {0} número: ",i);
                numero = Convert.ToDouble(Console.ReadLine());
                if(i == 1)
                {
                    maiorNumero = numero;
                }
                if(numero > maiorNumero)
                {
                    maiorNumero = numero;
                }
            }
            Console.WriteLine("O maior numero é: {0}", maiorNumero);
        }
    }
}
