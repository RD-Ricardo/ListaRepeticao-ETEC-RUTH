using System;

namespace ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = 0, total = 0, entrada;
            Console.Write("Digite um número: ");
            entrada = Convert.ToInt32(Console.ReadLine());
            while(entrada > 0)
            {
                total += entrada;
                qtd += 1;
                Console.Write("Digite um número: ");
                entrada = Convert.ToInt32(Console.ReadLine());   
            }
            Console.WriteLine("Quantidade de números digitados: {0}",qtd);
            Console.WriteLine("Soma dos números digitados: {0}",total);
            Console.WriteLine("A média desses números é: {0}",total / qtd);
        }
    }
}
