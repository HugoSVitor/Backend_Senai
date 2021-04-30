using System;

namespace Atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coloque o ano de seu nascimento: ");
            int anoDeNacismento = int.Parse(Console.ReadLine());
            int anoAtual = DateTime.Now.Year;
             
            int idadePessoa = anoAtual - anoDeNacismento;
            int idadeSemana = idadePessoa * 52;

            Console.WriteLine("Sua idade é: " + idadePessoa);
            Console.WriteLine("Sua idade em semanas é: " + idadeSemana);
        }
    }
}
