using System;

namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é sua idade");
            int idadePessoa = int.Parse(Console.ReadLine());

            int idadeMeses = idadePessoa * 12;
            int idadeDias = idadePessoa * 365;
            int idadeHoras = idadePessoa * 24;
            int idadeMinutos = idadeHoras * 60;

            Console.WriteLine("Sua idade em minutos é: " + idadeMinutos);
            Console.WriteLine("Sua idade em horas é: " + idadeHoras); 
            Console.WriteLine("Sua idade em dias é: " + idadeDias );
            Console.WriteLine("Sua idade em meses é: " + idadeMeses);
        }
    }
}
