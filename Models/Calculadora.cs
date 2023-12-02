using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public void Dividir(double x, double y)
        {
            double numeroDividido = Math.Round((x / y), 2);
            Console.WriteLine($"{x} / {y} = {numeroDividido}");
        }

        public void Potenciacao(int x, int y)
        {
            double potencia = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {potencia}");
        }

    }
}