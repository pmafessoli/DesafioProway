using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o limite de alunos atrasados");
            int limiteAlunsoAtrasados = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite total de alunos na aula");
            int totalAlunos = Convert.ToInt32(Console.ReadLine());
            var alunos = new List<string>(totalAlunos);
            var cont = 0;
            for (int i = 0; i <= totalAlunos - 1; i++)
            {
                Console.WriteLine($"Digite o tempo de chegada do aluno {i + 1}");
                alunos.Add(Console.ReadLine());
                if (Convert.ToInt32(alunos[i]) > 0)
                    cont++;
            }
            if (cont > limiteAlunsoAtrasados)
                Console.WriteLine($"Aula cancelada devido ao excesso de alunos ausentes.");
            else
                Console.WriteLine($"A aula ocorrerá normalmente pois o número de alunos atrasados não ultrapassou o limite.");
        }



    }
}
