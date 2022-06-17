using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Calcular : Calculadora
    {
        public int primeiroNumero { get; set; }
        public int segundoNumero { get; set; }

        public override void Somar()
        {
            Console.WriteLine("Insira os número para fazer a soma");
            Console.Write("Primeiro número: ");
            primeiroNumero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo número: ");
            segundoNumero = Convert.ToInt32(Console.ReadLine());
            this.Soma = primeiroNumero + segundoNumero;
            Console.WriteLine($"Resultado da Soma: {Soma}");
        }

        public override void Subtrair()
        {
            Console.WriteLine("\nInsira os número para fazer a subtração");
            Console.Write("Primeiro número: ");
            primeiroNumero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo número: ");
            segundoNumero = Convert.ToInt32(Console.ReadLine());
            this.Subtracao = primeiroNumero - segundoNumero;
            Console.WriteLine($"Resultado da Subtração: {Subtracao}");
        }
        public override void Multiplicar()
        {
            Console.WriteLine("\nInsira os número para fazer a multiplicação");
            Console.Write("Primeiro número: ");
            primeiroNumero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo número: ");
            segundoNumero = Convert.ToInt32(Console.ReadLine());
            this.Multiplicacao = primeiroNumero * segundoNumero;
            Console.WriteLine($"Resultado da Multiplicação: {Multiplicacao}");
        }
        public override void Dividir()
        {
            Console.WriteLine("\nInsira os número para fazer a divisão");
            Console.Write("Primeiro número: ");
            primeiroNumero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo número: ");
            segundoNumero = Convert.ToInt32(Console.ReadLine());
            this.Divisao = primeiroNumero / segundoNumero;
            Console.WriteLine($"Resultado da Divisão: {Divisao}");
        }
    }
}
