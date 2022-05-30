using System;

namespace ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroEntrada, menorNumero = 0,contador = 0;
            string opcao = "s";
            while(opcao == "s" && opcao != "n")
            {
                contador++;
                Console.Write("Digite um número: ");
                numeroEntrada = Convert.ToInt32(Console.ReadLine());
                if(contador == 1){
                    menorNumero = numeroEntrada;
                }
                if(numeroEntrada < menorNumero){
                    menorNumero = numeroEntrada;
                }
                Console.Write("Deseja continuar o programa sim(s) não(n): ");
                opcao = Console.ReadLine().ToLower();
            }
            Console.WriteLine("\nO menor numero é {0}", menorNumero);
        }
    }
}
