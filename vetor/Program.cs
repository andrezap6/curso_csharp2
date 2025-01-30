
/*
double[] reais = { 4.5, 3.2, 7.85, 10.64, -5.34, 2.1, -9.0 };
for (int i = 0; i < reais.Length; i++)
{
    Console.WriteLine(reais[i]);
}

double reias_maior = reais.Max();   
double reais_menor = reais.Min();

Console.WriteLine("O maior valor é: " + reias_maior);
Console.WriteLine("O menor valor é: " + reais_menor);
*/

{
    string[] nomes = { "Maria", "João", "Pedro", "Carla", "Ana", "José", "zeferina" };

    for (int i = 0; i < nomes.Length; i++)
    {
        if (i < nomes.Length - 1)
        {
            Console.Write(nomes[i] + ", ");
        }
        else
        {
            Console.Write(nomes[i] + ".");
        }
    }

    Console.WriteLine();
    string nome_primeiro = nomes.First();
    string nome_ultimo = nomes.Last();
    Console.WriteLine("O primeiro nome é: " + nome_primeiro);
    Console.WriteLine("O último nome é: " + nome_ultimo);
    string nomes_maior = nomes.Max();
    string nomes_menor = nomes.Min();
    Console.WriteLine("O primeiro nome em ordem alfabética é: " + nomes_menor);
    Console.WriteLine("O último nome em ordem alfabética é: " + nomes_maior);
}


 





                    