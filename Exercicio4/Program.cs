using System.Linq;
namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma ou mais palavras (separadas por espaços):");
            string entrada = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine("Você não digitou nenhuma palavra!");
                return;
            }

            // Divide a entrada em palavras usando espaços como separador
            string[] palavras = entrada.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("\nQuantidade de caracteres em cada palavra:");
            foreach (string palavra in palavras)
            {
                Console.WriteLine($"- \"{palavra}\": {palavra.Length} caracteres");
            }

            Console.WriteLine("\nFim do programa.");
        }
    }
}