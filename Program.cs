using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Calcular calcular = new Calcular();

                calcular.Somar();
                calcular.Subtrair();
                calcular.Multiplicar();
                calcular.Dividir();
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro! Apenas números inteiros");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro!  Não é permitido divisão por zero");
            }
        }
    }
}
