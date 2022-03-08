using System;

namespace Fatorial_Funcao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            int num = int.Parse(Console.ReadLine());
            int resp = fat(num);
            Console.WriteLine($"fatorial de {num} é {resp}");
        }

        static int fat (int num)
        {
            if (num == 0)
                return 1;
            else
                return (num * (num - 1));
        }
    }
}
