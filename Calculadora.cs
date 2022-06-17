using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Calculadora
    {

        public int Soma { get; set; }
        public int Subtracao { get; set; }
        public int Multiplicacao { get; set; }
        public int Divisao { get; set; }

        public abstract void Somar();
        public abstract void Subtrair();
        public abstract void Multiplicar();
        public abstract void Dividir();
    }
}
