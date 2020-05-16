using System;

namespace Leet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite algo.....");
            string frase1 = Console.ReadLine();
            string frase2 = frase1.Replace("a","4").Replace("e","3").Replace("l","1").Replace("o","0").Replace("t","7").Replace("s","5");

            Console.WriteLine(frase2);
        }
    }
}
