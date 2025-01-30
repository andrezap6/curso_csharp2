using System.Net.Http.Headers;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            Console.WriteLine("Digite o valor da base: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            areatriangulo(num1, num2);
        }

        static void areatriangulo(double largura, double altura)
        {
            double resultado = (largura * altura) / 2;
            Console.WriteLine($"A área do triangulo é {largura} * {altura} / 2 = {resultado:F2}m²");
        }
    }
}
