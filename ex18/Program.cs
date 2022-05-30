using System;

namespace ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numeroEntrda = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while(i <= 10){
                Console.WriteLine($"{i} x {numeroEntrda} = {i * numeroEntrda}");
                i++;
            }
        }
    }
}
