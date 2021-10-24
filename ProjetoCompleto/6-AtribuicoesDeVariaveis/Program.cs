using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6 - Atribuições de Variáveis\n");

            int idade = 26;
            int idadeVinicius = idade;

            //A variavel idadeVinicius não vai ficar seguindo o valor atribuido posteriormente.
            //Apenas vai pegar o valor atribuido na primeira vez.
            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeVinicius);

            Console.ReadLine();
        }
    }
}
