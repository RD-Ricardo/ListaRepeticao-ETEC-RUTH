using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalHoras = 0, nmHoraDiaria,salarioBruto;
            Console.WriteLine("Salário bruto no ultimo mês.");
            for (int i = 1; i <= 30; i++)
            {
                Console.Write("Digite quantas horas trabalho no {0} dia: ",i);
                nmHoraDiaria = Convert.ToDouble(Console.ReadLine());
                totalHoras += nmHoraDiaria;
            }
            salarioBruto = totalHoras * 10;
            Console.WriteLine("Salário bruto: {0}",salarioBruto);
        }
    }
}
