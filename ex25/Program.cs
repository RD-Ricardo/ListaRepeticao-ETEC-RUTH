using System;
using System.Security.Cryptography;

namespace ex25
{
    class Program
    {
        static void Main(string[] args)
        {
            int pag, he,me,hs,ms, h, m;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("- Calcular Valor estacionamento -");
            Console.WriteLine("---------------------------------");
            Console.Write("Digite a hora de ENTRADA: ");
            he = Convert.ToInt32(Console.ReadLine());
            while (he < 0 || he > 23){
                Console.Write("Digite o valor da hora de ENTRADA de 0 e 23: ");
                he = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Digite o minuto de ENTRADA: ");
            me = Convert.ToInt32(Console.ReadLine());
            while (me < 0 || he > 59){
                Console.Write("Digite o valor do minuto de ENTRADA de 0 a 59: ");
                me = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\nDigite a hora de SAIDA: ");
            hs = Convert.ToInt32(Console.ReadLine());
            while (hs < 0 || hs > 23){
                Console.Write("Digite o valor da hora de SAIDA de 0 a 23: ");
                hs = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Digite o minuto de SAIDA: ");
            ms = Convert.ToInt32(Console.ReadLine());
            while (ms < 0 || ms > 59){
                Console.Write("Digite o valor da hora de SAIDA de 0 a 59: ");
                ms = Convert.ToInt32(Console.ReadLine());
            }
            if(hs < he)
                hs = hs+24;
            if(ms < me){
                ms = ms+60;
                hs = hs - 1;
            }
            h  = hs - he;
            m  = ms - me;
            pag = h * 60 + m;

            if((pag >= 0) && (pag <= 60))
                Console.WriteLine("Valor a pagar 4 reais");
            else if((pag > 60) && (pag <= 120))
                Console.WriteLine("Valor a pagar 6 reais");
            else if((pag > 120) && (m == 0))
                Console.WriteLine("Valor a pagar {0} reais" , pag = 4 + h);
            else if((pag > 120) && (m > 0))
                Console.WriteLine("Valor a pagar {0} reais" , pag = 5 + h);
        }
    }
}
