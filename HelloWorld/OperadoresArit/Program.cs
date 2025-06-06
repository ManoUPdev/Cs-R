using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresArit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de uso de operadores aritméticos
            int a = 10;
            int b = 5;
            // Adição
            int soma = a + b;
            Console.WriteLine("Soma: " + soma);
            // Subtração
            int subtracao = a - b;
            Console.WriteLine("Subtração: " + subtracao);
            // Multiplicação
            int multiplicacao = a * b;
            Console.WriteLine("Multiplicação: " + multiplicacao);
            // Divisão
            int divisao = a / b;
            Console.WriteLine("Divisão: " + divisao);
            // Módulo (resto da divisão)
            int modulo = a % b;
            Console.WriteLine("Módulo: " + modulo);
            // Incremento
            a++;
            Console.WriteLine("Incremento de a: " + a);
            // Decremento
            b--;
            Console.WriteLine("Decremento de b: " + b);
            Console.ReadKey(); // Espera o usuário pressionar uma tecla antes de fechar o console
        }
    }
}
