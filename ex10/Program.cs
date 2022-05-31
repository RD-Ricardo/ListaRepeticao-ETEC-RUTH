using System;
using System.Diagnostics.CodeAnalysis;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdProduto, finalLista,prCompra, total = 0;
            double prPrpduto;
            Console.Write("Digite Quantas compra deseja fazer: ");
            finalLista = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= finalLista; i++)
            {
                Console.WriteLine("-------------------------------------");
                Console.Write("Digite a quantidade do {0} produto: ", i);
                qtdProduto = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite a preço do {0} produto: ", i);
                prPrpduto = Convert.ToDouble(Console.ReadLine());
                if(qtdProduto  > 0 && prPrpduto > 0)
                {
                    prCompra = qtdProduto * qtdProduto;
                    total += prCompra;
                }
                else
                {
                    Console.WriteLine("-------------------------------------");
                    i--;
                    Console.Write("Digite novamente a quantidade: ");
                    qtdProduto = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite o preço da compra: ");
                    prPrpduto = Convert.ToDouble(Console.ReadLine());
                }
            }
            Console.WriteLine("Total gasto {0}", total);
        }
    }
}
