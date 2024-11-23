namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu primeiro nome:");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite o seu sobrenome:");
            var sobrenome = Console.ReadLine();
            Console.WriteLine("Nome Completo: {0} {1}", nome, sobrenome);
        }
    }
}