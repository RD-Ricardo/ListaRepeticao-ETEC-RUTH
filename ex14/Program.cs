using System;

namespace ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroEntrada, contadorPar = 0, contadorImpar = 0, contador = 0;
            string opcao = "n";
            while(opcao != "s" && opcao == "n"){
                Console.Write("Digite um número: ");
                numeroEntrada = Convert.ToInt32(Console.ReadLine());
                if(numeroEntrada % 2 == 0){
                    contadorPar++;
                }              
                if(numeroEntrada % 2 == 1){
                    contadorImpar++;
                }
                contador++;              
                Console.Write("Deseja encerrar o programa sim(s) não(n)");
                opcao = Console.ReadLine().ToLower();
            }
            Console.WriteLine("");
            Console.WriteLine("Total de números {0}", contador);
            Console.WriteLine("Números pares {0}", contadorPar);
            Console.WriteLine("Números impares {0}", contadorImpar);
        }
    }
}
