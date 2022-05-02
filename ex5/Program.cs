using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fahrenheit para Celsius");
            double c;
            for (int i = 1; i <= 50; i++)
            {
                c = (i- 32) / 1.8;
                Console.WriteLine("{0} graus fahrenheit é = {1} graus celsius",i,c);
            }        
        }
    }
}
