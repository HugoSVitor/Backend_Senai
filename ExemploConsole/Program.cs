using System;

namespace ExemploConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome:");
            string nomePessoa = Console.ReadLine();

            Console.WriteLine("Boa Tarde " + nomePessoa);

            Console.WriteLine("Qual é a primeira nota:");
            double primeiraNota = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual é a segunda nota:");
            double segundaNota = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual é a terceira nota:");
            double terceiraNota = double.Parse(Console.ReadLine());

            double media = (primeiraNota + segundaNota + terceiraNota) / 3 ;
            
            Console.WriteLine("A média foi de: " + Math.Round(media,1));

            if (media > 5)
            {
                Console.WriteLine("O aluno foi aprovado! ;D ");
            } else{
                Console.WriteLine("O aluno foi reprovado! ;-;");
            }
        }
    }
}
