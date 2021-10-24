using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11 - Calcula Poupança 2\n");

            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                // valorInvestido = valorInvestido + (valorInvestido * 0.0036)
                // essa maneira de se escrever o codigo abaixo é mais simplificada, mas é igual a escrever o codigo acima comentado
                valorInvestido *= 1.0036;

                Console.WriteLine("Após " + contadorMes + " meses você terá R$ " + valorInvestido);
            }

            Console.ReadLine();
        }
    }
}
