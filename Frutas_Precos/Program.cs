using System.Reflection.Metadata;

namespace Frutas_Precos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] frutas = { "Banana", "Maçã", "Morango", "Uva", "Melancia", "Abacaxi", "Laranja", "Pera", "Mamão", "Manga" };
            double[] precos = { 3.50, 2.80, 4.50, 5.00, 6.00, 4.00, 3.00, 2.50, 3.00, 4.00 };

            for (int i = 0; i < frutas.Length; i++)
            {
                Console.WriteLine("A fruta " + frutas[i] + " custa R$ " + precos[i]);
            }

            Console.WriteLine("A fruta mais cara é: " + frutas[4] + " e custa R$ " + precos[4]);
            double precos_maior = precos.Max();
            Console.WriteLine("A fruta barata é : " + frutas[7] + " e custa R$ " + precos[7]);
            double precos_menor = precos.Min();
 

            Console.WriteLine("Primeira fruta em ordem alfabética: " + frutas[0]);
            string frutas_maior = frutas.Max();
            Console.WriteLine("Última fruta em ordem alfabética: " + frutas[3]);
            string frutas_menor = frutas.Min();
        }
    }
}
