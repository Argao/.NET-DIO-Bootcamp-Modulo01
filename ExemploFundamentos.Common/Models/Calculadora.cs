using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
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
            Console.WriteLine($"{x} X {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("Não é possível dividir por zero!");
            }
            else
            {
                Console.WriteLine($"{x} / {y} = {x / y}");
            }
        }

        public void Potencia(int x, int y)
        {
            Console.WriteLine($"{x} ^ {y} = {Math.Pow(x, y)}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de ({angulo}º) = {Math.Round(seno, 4)}");
        }

        public void Cosseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double cosseno = Math.Cos(radiano);
            Console.WriteLine($"Cosseno de ({angulo}º) = {Math.Round(cosseno, 4)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de ({angulo}º) = {Math.Round(tangente, 4)}");
        }

        public void RaizQuadrada(double x)
        {
            if (x < 0)
            {
                Console.WriteLine("Não é possível calcular a raiz quadrada de um número negativo!");
            }
            else
            {
                Console.WriteLine($"Raiz quadrada de {x} = {Math.Sqrt(x)}");
            }
        }

    }
}