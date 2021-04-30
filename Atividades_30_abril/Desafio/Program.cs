using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira sua idade:");
            int idade = int.Parse(Console.ReadLine());

            if (idade < 8)
            {
                Console.WriteLine("Você faz parte da categoria Infantil A");
            }

            if (idade < 11)
            {
                Console.WriteLine("Você faz parte da categoria Infantil B");
            }

            if (idade < 14)
            {
                Console.WriteLine("Você faz parte da categoria Juvenil A");
            }

            if (idade < 18)
            {
                Console.WriteLine("Você faz parte da categoria Juvenil B");
            }

            if (idade > 17)
            {
                Console.WriteLine("Você faz parte da categoria Sênior");
            }
        }
    }
}
