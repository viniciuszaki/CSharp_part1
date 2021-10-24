using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e Textos\n");

            // character
            char primeiraLetra = ' ';
            Console.WriteLine(primeiraLetra);

            // Testando a tabela ASC
            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            // Testando tabela ASC com operação e Casting
            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            // Manipulação STRING
            string titulo = "Alura Cursos de Tecnologia " + 2020;
            Console.WriteLine(titulo);

            string cursosProgramacao = 
@"- .NET
- JavaScript
- JAVA";

            Console.WriteLine(cursosProgramacao);

            Console.ReadLine();
        }
    }
}
