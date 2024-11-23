using System;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor:");
            double valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            double valor2 = double.Parse(Console.ReadLine());
            double resultado = valor1 + valor2;
            Console.WriteLine("A soma entre os dois valores é: {0}", resultado);
            resultado = valor1 - valor2;
            Console.WriteLine("A subtração entre os dois valores é: {0}", resultado);
            resultado = valor1 * valor2;
            Console.WriteLine("A multiplicação entre os dois valores é: {0}", resultado);
            resultado = valor1 / valor2;
            if (valor2 == 0)
            {
                Console.WriteLine("Não é possivel fazer uma divisão por zero.");
            }
            else
            {
                Console.WriteLine("A divisão entre os dois valores é: {0}", resultado);
            }
            resultado = (valor1 + valor2) / 2;
            Console.WriteLine("A média entre os dois valores é {0}", resultado);
        }
    }
}