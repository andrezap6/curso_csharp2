using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            char resposta;
            bool mostrar = false;

            Console.WriteLine("Digite um número inteiro: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Deseja mostrar os cálculos? (s/n): ");
            resposta = Convert.ToChar(Console.ReadLine().ToLower());

            if (resposta == 's') { mostrar = true; }

            Console.WriteLine(fatorial(num, mostrar));

        }

        static int fatorial(int n, bool show = false)
        {
            int f = 1;

            for (int i = 1; i <= n; i++)
            {
                if (show)
                {
                    Console.WriteLine(i);
                    if (i < n)
                    {
                        Console.Write(" x ");
                    }
                    else
                    {
                        Console.Write(" = ");
                    }
                }
                f *= i;
            }

            return f;
        }
    }
}
