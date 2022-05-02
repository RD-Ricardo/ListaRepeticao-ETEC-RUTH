using System;
namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double nmHoraDiarias, totalHoras = 0;
            Console.WriteLine("HORAS TRABALHADAS NO MES");
            for (int i = 1; i <= 30; i++)
            {
                Console.Write("Digite a quantas horas trabalho no {0} dia: ",i);
                nmHoraDiarias = Convert.ToDouble(Console.ReadLine());
                totalHoras += nmHoraDiarias;
            }
            Console.WriteLine("Total de horas trabalhadas no ultimo mes: ",totalHoras);
        }
    }
}
