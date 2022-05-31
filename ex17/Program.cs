using System;
using System.Net;

namespace ex17
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento,area, areaTotal = 0;
            string opcao = "s";
            while(opcao == "s" && opcao != "n")
            {
                Console.Write("Digite o comprimento do comodo: ");
                comprimento = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite a largura do comodo: ");
                largura = Convert.ToDouble(Console.ReadLine());
                area =  comprimento * largura;
                areaTotal += area;
                Console.WriteLine("\nArea do comodo {0}", area);
                Console.WriteLine("----------------------------------");
                Console.Write("Deseja continuar o programa sim(s) não(n): ");
                opcao = Console.ReadLine().ToLower();
            }
            Console.WriteLine("\nArea total da casa {0}", areaTotal);
        }
    }
}
