namespace Formatacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 10.54821;
            double num2 = 54781.65874;

            Console.WriteLine($"{num1:F4}"); // decimal
            Console.WriteLine($"{num2:N2}"); // separador de milhar
            Console.WriteLine($"{num1:C2}"); // moeda
            Console.WriteLine($"{num2:E2}"); // porcentagem
            Console.WriteLine($"{num1:P2}"); // notação científica
        }
    }
}
