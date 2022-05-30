using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double prProduto, totalProduto = 0,totalQtd = 0,aux,totalGasto = 0;
            int qtdProduto;
            Console.WriteLine("Total gasto da empresa de 45 produtos diferentes");
            for (int i = 1; i <= 45; i++)
            {   
                Console.Write("Digite a QUANTIDADE DO PRODUTO {0}: ",i);
                qtdProduto = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o PREÇO DO PRODUTO {0}: ",i);
                prProduto = Convert.ToDouble(Console.ReadLine());
                aux =  totalQtd * totalProduto;
                totalGasto += aux;
            }
            Console.WriteLine("Total gasto da EMPRESA: {0}",totalGasto);

        }
    }
}
