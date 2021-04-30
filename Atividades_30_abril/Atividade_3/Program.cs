using System;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu salário atual?");
            int salarioAtual = int.Parse(Console.ReadLine());

            if (salarioAtual > 500)
            {
                Console.WriteLine("Você não possui o direito ao aumento! :(");
            }
            
            if (salarioAtual < 500 ) 
            {
                int numeroPorcentagem = 30 * salarioAtual;
                int adicaoSalario = numeroPorcentagem / 100;
                int novoSalario = adicaoSalario + salarioAtual;

                Console.WriteLine("Seu novo salário é de: " + novoSalario) ;
            }

            if (salarioAtual == 500 ) 
            {
                int numeroPorcentagem = 30 * salarioAtual;
                int adicaoSalario = numeroPorcentagem / 100;
                int novoSalario = adicaoSalario + salarioAtual;

                Console.WriteLine("Seu novo salário é de: " + novoSalario) ;
            }

        }
    }
}
