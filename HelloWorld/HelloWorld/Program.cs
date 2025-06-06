using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Aqui acima do programa, temos os namespaces que são como pastas que organizam as classe,
// e claro os modulos ou pacotes (using System ou algo do tipo) que são
// como bibliotecas que trazem funcionalidades adicionais para o programa, que varia de acordo
// com o que você precisa fazer.

namespace HelloWorld
{
     class Program
    {
        static void Main(string[] args)
        {
            // WriteLine é um método da classe Console que imprime uma mensagem no console,
            // em outras palavras, e uma variável que guarda texto
            // o Write ou WriteLine imprime na tela, com a diferença que o WriteLine
            // pula uma linha após imprimir, ja o Write não pula linha.

            //Exemplo de uso do WriteLine:
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("Meu nome eh Marcelo");
            //Console.ReadKey();// Aqui o ReadKey é usado para esperar que o usuário pressione uma tecla antes de fechar o console.

            // Uma coisa interessante é que o C# é uma linguagem fortemente tipada, ou seja,conhecida
            // por exigir que as variáveis sejam declaradas com um tipo específico antes de serem usadas.
            //Variaveis sao como caixas que armazenam dados, e cada tipo de dado tem suas próprias regras e características.
            // Por exemplo, se quisermos armazenar um número inteiro, devemos declarar uma variável do tipo int (1,2,3,4,5,6,7,8,9,10,...).
            // se for um número decimal(0.5f, 1.2f, 3.6f, 9.0f...), devemos usar o //float.
            //textos são armazenados em variáveis do tipo string "Fui na padaria comprar pao", que é uma sequência de caracteres.
            //bool é um tipo de dado que pode ser verdadeiro (true) ou falso (false), e é usado para armazenar valores lógicos.
            //char é um tipo de dado que representa um único caractere, como 'a', 'b', 'c', etc.

            //Exemplo pratico simples de variáveis:

            //int idade = 30; // Declarando uma variável do tipo inteiro
            //float altura = 1.75f; // Declarando uma variável do tipo float (número decimal)
            //string nome = "Marcelo"; // Declarando uma variável do tipo string (texto)
            //bool estudante = true; // Declarando uma variável do tipo bool (verdadeiro ou falso)
            //char letraInicial = 'M'; // Declarando uma variável do tipo char (caractere)

            //Console.WriteLine("Idade: " + idade);
            //Console.WriteLine("Altura: " + altura);
            //Console.WriteLine("Nome: " + nome);
            //Console.WriteLine("Estudante: " + estudante);
            //Console.WriteLine("Letra Inicial: " + letraInicial);

            //altura = 1.80f; // Alterando o valor da variável altura
            //nome = "João"; // Alterando o valor da variável nome
            //Console.WriteLine("Novo valor da altura: " + altura);
            //Console.WriteLine("Novo valor do nome: " + nome);

            ////Como vimos no terminal, os valores das variáveis foram impressos na tela,
            ////porem ainda nao podemos inserir uma entrada do usuario, veremos mais adiante, agora precisamos entender
            //// abaixo  dos console.writeline, temos certas alteracoes de variaveis para que sejam tambem exibidas no console,

            ////Agora iremos ver e entender as constantes, que são variáveis cujo valor não pode ser alterado após serem definidas.
            //// para criar uma constante, usamos a palavra-chave const seguida do tipo de dado e do nome da constante.
            ////Diferente das variáveis, as constantes devem ser inicializadas no momento da declaração e não podem ser alteradas posteriormente.
            ////Exemplo de uso de constantes:

            //const double PI = 3.14159; // Declarando uma constante do tipo double (número decimal de precisão dupla)
            //Console.WriteLine("Valor de PI: " + PI);// Imprimindo o valor da constante PI
            ////O que vimos tudo isso acima, nos permite entender como manipular dados no C#.


            // Agora vamos colocar em prática o que aprendemos sobre variáveis e constantes juntamente com a entrada do usuário.
            string nome = ""; // Declarando uma variável do tipo string para armazenar o nome do usuário
            Console.WriteLine("Digite seu nome: ");     
            nome = Console.ReadLine(); // Atribui o valor digitado pelo usuário à variável nome
            Console.WriteLine("Seu nome e:");
            Console.WriteLine(nome); // Imprime uma mensagem de boas-vindas com o nome do usuário

            Console.ReadLine();
        }

    }
}
