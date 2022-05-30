using System;

namespace ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double numero,maiorNumero = 0,menorValor = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Digite o {0} número: ",i);
                numero = Convert.ToDouble(Console.ReadLine());
                if(i == 1){
                    maiorNumero = numero; 
                    menorValor = numero;  
                }
                if(numero > maiorNumero){ 
                    maiorNumero = numero;
                }
                if(numero < menorValor){
                   menorValor = numero; 
                }
            }
            Console.WriteLine("\nO maior valor é: {0}", maiorNumero);
            Console.WriteLine("\nO menor valor é: {0}", menorValor);
        }
    }
}
