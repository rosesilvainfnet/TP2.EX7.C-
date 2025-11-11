using System;

public class VerificadorParImpar
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Verificador de Paridade ---");

        Console.Write("Digite um número inteiro: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int numero))
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine("\n=============================================");
                Console.WriteLine($"O número {numero} é PAR.");
                Console.WriteLine("=============================================");
            }
            else
            {
                Console.WriteLine("\n=============================================");
                Console.WriteLine($"O número {numero} é ÍMPAR.");
                Console.WriteLine("=============================================");
            }
        }
        else
        {
            Console.WriteLine("\nErro: Entrada inválida. Por favor, digite um número inteiro.");
        }
    }
}