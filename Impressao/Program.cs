namespace Impressao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            escreva("Andreza Pereira Santos");
            Console.WriteLine();
            escreva("Curso C#");
            Console.WriteLine();
            escreva("Bem-Vindo");
            Console.WriteLine();
        }

        static void escreva(string texto)
        {
            char caracter = '*'; // Caracter que será impresso
            int tamanho = texto.Length + 4; // Tamanho da linha
            string linha = new string(caracter, tamanho); // Criar uma linha com o caracter informado
            string textoCentralizado = texto.PadLeft(2 + texto.Length).PadRight(tamanho); // Texto impresso centralizado
            Console.WriteLine(linha);
            Console.WriteLine(textoCentralizado);
            Console.WriteLine(linha); 
        }
    }
}
