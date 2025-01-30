namespace AreaDoTerreno
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            Console.WriteLine("--------------------------");
            Console.WriteLine("Calcule a Área do Terreno");
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            Console.Write("Digite a largura do terreno(m): ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite o comprimento do terreno(m): ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            area (l, c);
        }
            static void area(double l, double c)
        {
                double a = l * c;
                Console.WriteLine($"A área do terreno de {l} X {c} é de {a:F2}m² ") ;
        }
    }
}
