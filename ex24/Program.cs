using System;

namespace ex24
{
    class Program
    {
        static void Main(string[] args)
        {
            int dn,da,dr,ma,mn,mr,an,aa,ar;
            Console.Write("Digite o dia do seu aniversario: ");
            dn = Convert.ToInt32(Console.ReadLine());
            while (dn < 1 || dn > 31){
                Console.Write("Digite o valor do dia entre 1 e 31: ");
                dn = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Digite o mes do seu aniversario:");
            mn = Convert.ToInt32(Console.ReadLine());
            while(mn < 1 || mn > 12){
                Console.WriteLine("Digite um valor de 1 até 12: ");
                ma = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Digite o ano do seu aniversario:");
            an = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nDigite o dia do ano atual:");
            da = Convert.ToInt32(Console.ReadLine());
            while (da < 1 || da > 31){
                Console.WriteLine("Digite o valor do dia entre 1 e 31: ");
                da = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Digite o mes do ano atual:");
            ma = Convert.ToInt32(Console.ReadLine());
            while(ma < 1 || ma > 12){
                Console.WriteLine("Digite um valor de 1 até 12: ");
                ma = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Digite o ano atual:");
            aa = Convert.ToInt32(Console.ReadLine()); 
            if(da < dn)
                dr = (da + 30) - dn;
            else
                dr = da - dn;

            if(da < dn && ma < mn)
                mr = ((ma - 1 ) + 12) - mn;
            else if(ma < mn)
                mr = (ma + 12 ) -mn;
            else
                mr = ma - mn;
            
            
            if(ma < mn)
                ar = (aa - 1) - an;
            else
                ar = aa - an;

            Console.WriteLine("Voce tem {0} anos, {1} meses ,{2} dias", ar,mr,dr);
        }
    }
}
