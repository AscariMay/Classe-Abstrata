using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Calcular : Calculadora
    {
        public int a { get; set; }
        public int b { get; set; }

        public override void Dividir()
        {
            try
            {
                this.Divisao = a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro!  Não é permitido divisão por zero");
            }
        }

        public override void Multiplicar()
        {
            this.Multiplicacao = a * b;
        }

        public override void Somar()
        {
            this.Soma = 2 + 5;
        }

        public override void Subtrair()
        {
            this.Subtracao = a - b;
        }
    }
}
