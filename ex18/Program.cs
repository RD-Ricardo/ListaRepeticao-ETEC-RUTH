using System;

namespace ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numeroEntrada = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while(i <= 10){
                Console.WriteLine($"{i} x {numeroEntrada} = {i * numeroEntrada}");
                i++;
            }
        }
    }
}
