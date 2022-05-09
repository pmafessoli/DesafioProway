using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número.");
            var numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o tamanho do vetor");
            var tamanho = Convert.ToInt32(Console.ReadLine());
            int[] vetor;
            vetor = new int[tamanho];
            var contmax = 0;
            for(int i = 0; i < tamanho; i++)
            {
                Console.WriteLine($"Digite o valor da posição {i} vetor.");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
