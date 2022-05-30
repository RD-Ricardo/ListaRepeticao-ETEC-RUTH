using System;

namespace ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            double felisberto = 1.1;
            double anacleto =  1.5;
            int anos = 0;
            while(anacleto > felisberto)
            {    
                anacleto += 0.020;
                felisberto += 0.030;
                anos++;
            }
            Console.WriteLine("{0} Anos necessarios para ele ser maior", anos);
        }
    }
}
