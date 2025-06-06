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
            //int a = 30;
            //int b = 7;
            //// Adição
            //int soma = a + b;
            //Console.WriteLine("Soma: " + soma);
            //// Subtração
            //int subtracao = a - b;
            //Console.WriteLine("Subtração: " + subtracao);
            //// Multiplicação
            //int multiplicacao = a * b;
            //Console.WriteLine("Multiplicação: " + multiplicacao);
            //// Divisão
            //int divisao = a / b;
            //Console.WriteLine("Divisão: " + divisao);
            // Módulo (resto da divisão)
            //int modulo = a % b;
            //Console.WriteLine("Módulo: " + modulo);
            //// Incremento
            //a++;
            //Console.WriteLine("Incremento de a: " + a);
            //// Decremento
            //b--;
            //Console.WriteLine("Decremento de b: " + b);
            //Console.ReadKey(); // Espera o usuário pressionar uma tecla antes de fechar o console

            int NumeroQualquer = 40 + 10 - 30;
            int Multiplicacao = 10 * 5;
            float Divisao = 10.8f / 2f; // Usando 'f' para indicar que é um float 

            int teste = 5 + 6 * 2 - 3 / 1; // Operadores aritméticos com precedência
            // 6 // 2 // = 3.0 int
            // 5 / 2 // = 2.5 float

            Console.WriteLine("Resultado da soma: " + NumeroQualquer);
            Console.WriteLine("Resultado da multiplicação: " + Multiplicacao);
            Console.WriteLine("Resultado da divisão: " + Divisao);  
            Console.WriteLine("Resultado do teste com operadores aritméticos: " + teste);

            Console.ReadLine(); // Espera o usuário pressionar Enter antes de fechar o console

        }
    }
}
