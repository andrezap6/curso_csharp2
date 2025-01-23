using System;
using static System.Net.Mime.MediaTypeNames;

namespace EX014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("**************************************: ");
            Console.Write("Digite um número e aparecerá a tabuada: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i ++)
            {
                Console.WriteLine("{0} X {1} = {2}", num, i, num * i);
            }
           

        }
            
    }
}
