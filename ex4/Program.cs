using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalHoras = 0, nmHoraDiaria,salarioBruto = 0;
            Console.WriteLine("Salário no bruto no ultimo mês.");
            for (int i = 1; i <= 30; i++)
            {
                Console.Write("Digite a quantas horas trabalho no {0} dia: ",i);
                nmHoraDiaria = Convert.ToDouble(Console.ReadLine());
                salarioBruto = nmHoraDiaria * 10 ;
            }
            
            Console.WriteLine("Salário bruto: {0}",salarioBruto);
        }
    }
}
