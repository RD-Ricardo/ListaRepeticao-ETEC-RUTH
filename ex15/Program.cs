using System;

namespace ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroEntrada = 0;
            string mensagem;
            while(numeroEntrada >= 0)
            {
                Console.WriteLine("--------------------------");
                Console.Write("Digite um número: ");
                numeroEntrada = Convert.ToInt32(Console.ReadLine());
                mensagem = numeroEntrada % 2 == 0 ? "Número par" : "Número impar";
                Console.WriteLine(mensagem);             
            }
               
            
        }
    }
}
