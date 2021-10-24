using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;
           
            int salarioEmInteiro;

            //Casting sendo realizado aqui
            salarioEmInteiro = (int)salario;

            //numero perde a precisão. 1200,50 vira apenas 1200
            Console.WriteLine(salarioEmInteiro);

            // long é uma variavel do tipo inteiro que armazena valores dentro de 64 bits, enquanto int é 32 bits
            long idade = 13000000000;
            Console.WriteLine(idade);

            // short é uma variavel do tipo inteiro que armazena valores de 16 bits. suporta até por volta de 16000.
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            // float tem menos capacidade que o double. menos utilizado.
            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
