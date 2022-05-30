using System;

namespace exOperario
{
    class Program
    {
        static void Main(string[] args)
        {
            int c, n,e, salarioHora, salarioExcedente = 0, salarioTotal;
            string opcao;
            do{
                Console.Write("Digite o código: ");
                c = int.Parse(Console.ReadLine());
                Console.Write("Digite o números de horas: ");
                n = int.Parse(Console.ReadLine());
                
                salarioHora = n * 10;

                if(n > 50){
                    e = n - 50;
                    salarioExcedente = e * 20; 
                } 
                else{
                    e = 0;
                }
                salarioTotal = salarioHora + salarioExcedente;
                Console.WriteLine("");
                Console.WriteLine("Salário Total {0}", salarioTotal);
                Console.WriteLine("Salário Hora {0}", salarioHora);
                Console.WriteLine("Salário Excedente {0}", salarioExcedente);
                Console.WriteLine("");
                Console.Write("Deseja encerrar o programa sim(s) não(n): ");
                opcao = Console.ReadLine().ToLower();

            }while(opcao == "n" && opcao != "s");
        }   
    }
}


