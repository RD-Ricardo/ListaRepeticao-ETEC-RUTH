using System;

namespace ex23
{
    class Program
    {
        static void Main(string[] args)
        {
           double salario = 0, salarioNovo, gastoEmpresa =0, diferencaSalario;
           while(salario >= 0)
           {
                Console.Write("Digite o salario do funcionário: ");
                salario = Convert.ToDouble(Console.ReadLine());
                if(salario > 0)
                {
                    if(salario < 500)
                        salarioNovo = ((salario * 15)/  100) + salario;
                    else if(salario >= 500 && salario <= 1000)
                        salarioNovo = ((salario * 10)/ 100)+ salario;
                    else
                        salarioNovo = ((salario *5) / 100) + salario;

                    diferencaSalario = salarioNovo - salario;
                    gastoEmpresa += diferencaSalario;
                    Console.WriteLine("Reajuste de salario: {0}", salarioNovo);
                }
           }
           Console.WriteLine("Valor gasto pela empresa: {0}", gastoEmpresa);
        }
    }
}
