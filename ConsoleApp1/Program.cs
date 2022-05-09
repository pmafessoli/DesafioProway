using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<int>();

            for (int i = 1; i < 1000000; i++)
            {
                if (!i.ToString().StartsWith("0"))
                {
                    int entradaInvertida = Inverter(i);
                    if (entradaInvertida != -1)
                    {
                        var soma = entradaInvertida + i;
                        if (soma % 2 != 0)
                        {
                            lista.Add(i);
                            Console.WriteLine(i);
                        }
                    }
                }
            }
            Console.WriteLine("Contador total:" + lista.Count);
        }

        public static int Inverter(int entrada)
        {
            string valor = entrada.ToString();
            string entradaInvertidatxt = "";
            for (int j = valor.Length; j > 0; j--)
            {
                entradaInvertidatxt += valor[j - 1];
            }
            if (entradaInvertidatxt.StartsWith("0"))
                return -1;
            return Convert.ToInt32(entradaInvertidatxt);
        }

    }
}
