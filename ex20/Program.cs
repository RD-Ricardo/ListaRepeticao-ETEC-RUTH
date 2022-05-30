using System;

namespace ex20
{
    class Program
    {
        static void Main(string[] args)
        {
            double hrTrabalhadas, vlHora, salarioBruto = 0, impostoRenda, vlDescontoInss, salarioLiquido = 0;
            string op = "s";
            while (op == "s")
            { 
                Console.Write("Digite o valor da hora trabalhada: ");
                vlHora = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite horas trabalhadas: ");
                hrTrabalhadas = Convert.ToDouble(Console.ReadLine());
                salarioBruto = vlHora * hrTrabalhadas;
                vlDescontoInss = salarioBruto - (salarioBruto  * 0.11);
                if(vlDescontoInss <= 900)
                    impostoRenda = 0;
                else if(vlDescontoInss > 900 && vlDescontoInss <= 1800)
                    impostoRenda = ((vlDescontoInss * 15) / 100) - 135;
                else
                    impostoRenda = ((vlDescontoInss * 27.5) / 100) - 360;
                
                salarioLiquido = vlDescontoInss - impostoRenda;
                Console.WriteLine("\nSalário Bruto: " + salarioBruto);
                Console.WriteLine("Salário Líquido: " + salarioLiquido);
                Console.Write("Deseja calcular outro funcionario? sim(s) não(não): ");
                op = Console.ReadLine().ToLower();
                while(op != "n" && op != "s"){
                    Console.Write("Digite uma opção valida sim(s) não(n): ");
                    op = Console.ReadLine().ToLower();
                }
                Console.WriteLine("------------------------------");
            }
        }
    }
}
 