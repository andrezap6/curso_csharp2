namespace EX015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string genero;

            Console.WriteLine("Digite o gênero: ");
            genero = Console.ReadLine().ToUpper();

            while (genero != "F" && genero != "M")
            {
                Console.Write("Digite o genero: ");
                genero = Console.ReadLine().ToUpper();
            }

            Console.WriteLine("Bem-vindos e bem vindas ao curso de C#!");
        }
    }
}
