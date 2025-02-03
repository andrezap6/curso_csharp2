using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace votacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nasc;
            Console.WriteLine("Digite o ano de nascimento: ");
            nasc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(voto(nasc));
        }

        static string voto(int ano)
        {
            // int dia = dataAtual.Day;
            // int mes = dataAtual.Month;
            //int hora = dataAtual.Hour;
            //int minuto = dataAtual.Minute;
            //int segundo = dataAtual.Second; */

            DateTime dataAtual = DateTime.Now;
            int anoAtual = dataAtual.Year;
            int idade = anoAtual - ano;

            if (idade < 16) 
            {
                return $"Com {idade} anos, você não vota.";
            }
            else if (idade > 18 && idade < 70)
            {
                return $"Com {idade} anos, seu voto é obrigatório.";
            }
            else
            {
                return $"Com {idade} anos, seu voto é opcional.";
            }   

        }

    }
}
