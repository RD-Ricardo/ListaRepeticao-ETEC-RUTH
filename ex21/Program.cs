using System;

namespace ex21
{
    class Program
    {
        static void Main(string[] args)
        {
            double pEtiqueta, totalProduto = 0;
            int cdPagamento;
            string op = "s";
            while(op == "s" && op != "n")
            {
                Console.Write("Digite o preço da Etiqueta: ");
                pEtiqueta = Convert.ToInt32(Console.ReadLine());
                totalProduto += pEtiqueta;
                Console.Write("Deseja adicionar mais Produtos: sim(s) não(n): ");
                op = Console.ReadLine().ToLower();
            }
            Console.WriteLine("\nValor da Compra {0}", totalProduto);
            Console.Write("Escolha a forma de Pagamento: ");
            Console.WriteLine("\n(1) - À vista em dinheiro ou cheque, com 10% de desconto");
            Console.WriteLine("(2) - À vista com cartão de crédito, com 5% de desconto");
            Console.WriteLine("(3) - Em 2 vezes, preço normal de etiqueta sem juros");
            Console.WriteLine("(4) - Em 3 vezes, preço de etiqueta com acréscimo de 10%");
            cdPagamento = Convert.ToInt32(Console.ReadLine());
            while (cdPagamento != 1 &&
                cdPagamento != 2 &&
                cdPagamento != 3 &&
                cdPagamento != 4)
            {
                Console.WriteLine("Digite um código de pagamento VALIDO:");
                Console.WriteLine("\n(1) - À vista em dinheiro ou cheque, com 10% de desconto");
                Console.WriteLine("(2) - À vista com cartão de crédito, com 5% de desconto");
                Console.WriteLine("(3) - Em 2 vezes, preço normal de etiqueta sem juros");
                Console.WriteLine("(4) - Em 3 vezes, preço de etiqueta com acréscimo de 10%");
                cdPagamento = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Foma de Pagamento escolhida: {0}", cdPagamento); 
        }
    }
}
