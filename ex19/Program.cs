using System;
using Microsoft.VisualBasic;

namespace ex19
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int idade = 1;
            int totalPessoas = 0, otimo = 0,bom = 0, regular = 0, ruim =0, pessimo =0;
            while(idade >= 1)
            {
                contador++;
                string op;
                Console.Write("Digite sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a opnião do filme");
                Console.Write("(A)  - Otimo \n(B) - Bom \n(C)- Regular \n(D) - Ruim \n(E) - Pessimo \nRespota: ");
                op = Console.ReadLine().ToLower();
                if(op == "a"){
                    otimo++;
                }
                if(op == "b"){
                    bom++;
                }
                if(op == "c"){
                    regular++;
                }
                if(op == "d"){
                    ruim++;
                }
                 if(op == "e"){
                    pessimo++;
                }
                totalPessoas++;
            }
        }
    }
}
