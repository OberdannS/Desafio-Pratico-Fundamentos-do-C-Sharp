namespace Exercicio1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o seu nome:");
        var nome = Console.ReadLine();
        Console.WriteLine("Olá {0}! Seja muito bem-vindo!", nome);
    }
}