using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcular calcular = new Calcular();

            Console.WriteLine("Insira os número para fazer a soma");
            calcular.a = Convert.ToInt32(Console.ReadLine());
            calcular.b = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Insira os número para fazer a subtracao");
            calcular.a = Convert.ToInt32(Console.ReadLine());
            calcular.b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira os número para fazer a multiplicação");
            calcular.a = Convert.ToInt32(Console.ReadLine());
            calcular.b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira os número para fazer a divisão");
            calcular.a = Convert.ToInt32(Console.ReadLine());
            calcular.b = Convert.ToInt32(Console.ReadLine());

            calcular.Somar();
            calcular.Subtrair();
            calcular.Multiplicar();
            calcular.Dividir();

            Console.WriteLine();
            Console.WriteLine($"Resultado da Soma: {calcular.Soma}");
            Console.WriteLine($"Resultado da Subtração: {calcular.Subtracao}");
            Console.WriteLine($"Resultado da Multiplicação: {calcular.Multiplicacao}");
            Console.WriteLine($"Resultado da Divisão: {calcular.Divisao}");
        }
    }
}
