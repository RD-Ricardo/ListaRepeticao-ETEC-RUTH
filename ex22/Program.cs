using System;

namespace ex22
{
    class Program
    {
        static void Main(string[] args)
        {

            int qtdProduto = 0, contador = 1;
            double vlCaixa = 0, prProduto, vlTotal = 0,compra=0;
            while (qtdProduto >= 0)
            {
                if(contador == 1){
                    Console.Write("Digite a quantidade de dinheiro no caixa: ");
                    vlCaixa = Convert.ToDouble(Console.ReadLine());
                }
                Console.Write("\nDigite o preço do produto {0}: ", contador);
                prProduto = Convert.ToDouble(Console.ReadLine());
                while(prProduto < 0)
                {
                    Console.Write("Digite um preço maior que 0: ");
                    prProduto = Convert.ToDouble(Console.ReadLine());
                }
                Console.Write("Digite a quantidade de produtos: ");
                qtdProduto = Convert.ToInt32(Console.ReadLine());
                if(qtdProduto > 0 ){
                    compra = prProduto * qtdProduto;
                    vlTotal += compra;
                    contador++;
                }
                Console.WriteLine("-----------------------------");
            }
            if((vlTotal) > (vlCaixa * 80 / 100))
            {
                double totalPrazo = (vlTotal + (vlTotal * 10) / 100);
                Console.WriteLine("\nForma de Pagamento escolhida: A PRAZO");
                Console.WriteLine("Total a prazo: {0}", totalPrazo);
            }
            else
            {
                double totalAvista = (vlTotal - (vlTotal * 5) / 100);
                Console.WriteLine("\nForma de Pagamento escolhida: A VISTA");
                Console.WriteLine("Total a vista: {0}", totalAvista);
            }
            Console.WriteLine("Valor total dos produtos: {0}", vlTotal);
        }
    }
}
