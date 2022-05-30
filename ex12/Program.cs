using System;

namespace ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroEntrada = 0, maiorNumero = 0;
            while(numeroEntrada >= 0)
            {
                Console.Write("Digite um número: ");
                numeroEntrada = Convert.ToInt32(Console.ReadLine());
                if(numeroEntrada > maiorNumero){
                    maiorNumero = numeroEntrada;
                }
            }
            Console.WriteLine("O maior número é {0}", maiorNumero);
        }
    }
}
