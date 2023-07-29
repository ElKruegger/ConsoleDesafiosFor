﻿using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace ConsoleDesafiosFor
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Basica
            /*
            // Exercicio 1.
            // Escreva um programa em C# que imprima todos os números de 1 a 10 usando um loop for.

            Console.WriteLine("Escrever um programa que imprima numeros de 1 a 10.");

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            Console.Clear();

            // Exercicio 2
            // Escreva um programa em C# que imprima todos os números pares entre 1 e 20 usando um loop for.

            Console.WriteLine("Um programa que imprime os numeros pares entre o numero 1 e o numero 20.");

            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            Console.Clear();

            // Exercicio 3
            // Crie um programa que multiplique todos os números em um array de 5 elementos usando um loop for.
            Console.WriteLine(" Um programa que multiplica todos os nuemros de umarrayde 5 elementos em um loop : ");
            int[] numeros = { 2, 4, 6, 8, 10 };
            int resultado = 1;

            for (int i = 0; i < numeros.Length; i++)
            {
                resultado *= numeros[i];
            }

            Console.WriteLine("O resultado da multiplicação é: " + resultado);

            Console.ReadKey();
            Console.Clear();

            // Exercicio 4
            // Escreva um programa que peça ao usuário para digitar 10 números e, em seguida, use um loop for para somar todos eles e imprimir o resultado.
            Console.WriteLine(" Insira 10 números no console onde todos eles serão somados e os resultados exibidos já somados :");

            // Estudar esse pedaço de código
            List<int> listaUm = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Número " + i + ": ");
                string input = Console.ReadLine();
                int numero = int.Parse(input);
                listaUm.Add(numero);
            }
            // Estudar código acima

            int resultadoSoma = 1;

            for (int i = 0; i < listaUm.Count; i++)
            {
                resultadoSoma *= listaUm[i];
            }
            Console.WriteLine($" O resultado da multiplicação é {resultadoSoma}");
            Console.ReadKey();
            Console.Clear();



            // Exercicio 5
            // Crie um programa em C# que imprima a tabuada de qualquer número escolhido pelo usuário utilizando o loop for.

            Console.WriteLine(" Digite um número pra acessar a tabuada no loop for :");
            int numerotabuada = int.Parse(Console.ReadLine());
            Console.WriteLine($" Tabuada de numero {numerotabuada} : ");
            for (int i = 0; i <= 10; i++)
            {
                int multiplicacao = numerotabuada *= i;
                Console.WriteLine($"{numerotabuada} X {i} = {multiplicacao}");
            }
            Console.ReadKey();
            Console.Clear();

            // Exercicio 6
            // Crie um programa que imprima todos os elementos de uma lista de strings utilizando um loop foreach.

            Console.WriteLine(" Um programa que imprime os elementos de uma lista de strings, usando loop foreach : ");

            List<string> listastringUm = new List<string>() { "A", "B", "C", "D", "E", "F", "G" };
            foreach (string str in listastringUm)
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();
            Console.Clear();

            // Exercicio 7
            // Faça um programa que peça ao usuário para digitar 5 nomes. Armazene esses nomes em uma lista e use um loop foreach para imprimir todos os nomes.
            Console.WriteLine(" Digite 5 nomes para o programa, eles serão listados por um foreach ;) ");

            List<string> listadenomes = new List<string>();
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Nome " + i + ": ");
                string inputnome = Console.ReadLine();
                string nome = inputnome;
                listadenomes.Add(nome);

            }
            foreach (var nomeinput in listadenomes)
            {
                Console.WriteLine(nomeinput);
            }
            Console.ReadKey();
            Console.Clear();


            // Exercicio 8
            // Escreva um programa em C# que imprima os números ímpares entre 1 e 10 usando um loop foreach em uma lista.
            Console.WriteLine(" Um programa que escreve os numeros ímpares entre 1 e 10 em um loop foreach em uma lista : ");

            for (int i = 1; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            Console.Clear();


            // Exercicio 9
            // Crie um programa que multiplique todos os números em um array de 5 elementos usando um loop foreach.

            Console.WriteLine(" Um programa que multiplica todos os numeros de um array de 5 elementos usando um loop foreach :");

            List<int> listaDois = new List<int>() { 1, 2, 4, 8, 12 };
            int resultadolistadois = 1;
            foreach (var somadosnumeros in listaDois)
            {
                resultadolistadois *= somadosnumeros;
                Console.WriteLine(resultadolistadois);
            }
            Console.ReadKey();
            Console.Clear();


            // Exercicio 10
            // Crie um programa que peça ao usuário para digitar vários nomes até que ele digite "pare". Em seguida, use um loop foreach para imprimir todos os nomes.
            Console.WriteLine(" Um programa que peça ao usuario para digitar varios numes até que seja digitado PARE, em seguida o programa lista os nomes.");


            List<string> listEx10 = new List<string>();
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Nome " + i + ": ");
                string inputnomeEx10 = Console.ReadLine();
                string nomesEx10 = inputnomeEx10;
                listEx10.Add(nomesEx10);

                if (inputnomeEx10 == "pare")
                {
                    foreach (var fraseslista in listEx10)
                    {
                        Console.WriteLine(fraseslista);
                    }
                }
            }

            Console.ReadKey();
            Console.Clear();


            */

            #endregion Basica



            #region Intermediario
            /*
            // // Exercicio 11
            // Crie um programa que leia uma matriz de 10x10 e imprima todos os seus elementos usando loops for aninhados.
            Console.WriteLine("A seguir um programa que lê uma matriz 10x10 e imprime todos os seus elementos usando loops for aninhados");

            int[,] array10x10 = new int[10, 10];
            int valor = 1;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    int elementos = array10x10[i, j] = valor;
                    valor++;
                    Console.WriteLine($"{elementos} :  ");
                }

                Console.WriteLine();
            }
            Console.ReadKey();
            Console.Clear();


            // Exercicio 12
            // Escreva um programa que calcule a soma dos números em uma matriz 2D usando loops for aninhados.
            int[,] calculoarray = new int[10, 10];
            int valorExDois = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    int elementosexdois = calculoarray[i, j] = valorExDois;
                    valorExDois++;
                    valorExDois += elementosexdois;
                    Console.WriteLine($"{elementosexdois} :");

                }
            }

            // Exercicio 13
            // Crie um programa que peça ao usuário para inserir 5 nomes e 5 idades correspondentes. Em seguida, use um loop foreach para imprimir o nome e a idade de cada pessoa.
            Console.WriteLine(" Um programa que pede ao usuario 5 nomes e 5 idades correspondentes, em seguida, um loop foreach para cada nome e a idade da pessoa : ");
            Console.WriteLine(" Digite um nome : ");
            List<string> listNomeEx11 = new List<string>();
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($" Nome: {i} : ");
                string inputnomeEx11 = Console.ReadLine();
                string nomesEx11 = inputnomeEx11;
                listNomeEx11.Add(nomesEx11);
            }

            Console.WriteLine(" Agora digite as idades : ");


            List<int> listIdadeEx11 = new List<int>();
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($" Idade: {i} : ");
                int inputidadeEx11 = Convert.ToInt32(Console.ReadLine());
                int idadesEx11 = inputidadeEx11;
                listIdadeEx11.Add(idadesEx11);
            }

            foreach (var colnomes in listNomeEx11)
            {
                Console.WriteLine($" Nomes : {colnomes}");


            }
            foreach (var colidade in listIdadeEx11)
            {
                Console.WriteLine($" Idades : {colidade}");
            }

            // Exercicio 14
            // Escreva um programa em C# que some todos os números ímpares em uma lista usando um loop foreach.

            Console.WriteLine(" Um programa que some todos os numeros impares de uma lista usando loop foreach");

            List<int> ListImpares = new List<int>() { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };
            int SomaImpares = 0;

            foreach (var nmrimpar in ListImpares)
            {
                if (nmrimpar % 2 != 0)
                {
                    SomaImpares += nmrimpar;
                }

            }
            Console.WriteLine($"Lista dos impares somados{SomaImpares}");


            // Exercicio 15
            //Crie um programa que peça ao usuário para digitar um número n e depois use um loop for para calcular o fatorial de n.
            Console.WriteLine("Um programa que peça ao usuario pra digitar um numero n e depois use um loop pra calcular o fatorial de N");
            Console.WriteLine("Digite um número...");
            int nmrinserido = Convert.ToInt32(Console.ReadLine());
            int nmrfatorial = 1;

            if (nmrinserido <= 0)
            {
                Console.WriteLine(" O número não é fatorial, não pode ser calculado.");
            }
            else
            {
                for (int i = 1; i < nmrinserido; i++)
                {
                    nmrfatorial *= i;
                }

                Console.WriteLine($"O fatorial de {nmrinserido} é {nmrfatorial}");
            }

            // Exercicio 16
            //Escreva um programa que inverta uma string usando um loop for.

            Console.WriteLine(" Um programa que inverte uma string usando loop for. . . socorro Deus");
            Console.WriteLine("Digite uma frase ai. . . ");
            var inputpalavra = Console.ReadLine();

            string inverterstring = "";

            for (int i = inputpalavra.Length - 1; i >= 0; i--)
            {
                inverterstring += inputpalavra[i];
            }
            Console.WriteLine($"A palavra invertida é {inverterstring}");
            Console.ReadKey();
            Console.Clear();




            // Exercicio 17
            //  Crie um programa que leia uma lista de números do usuário e imprima o menor e o maior número da lista usando loops for ou foreach.
            Console.WriteLine("Um programa que leia uma lista de numeros do usuario e imprima o menor e o maior numero da lista usando loop for ou foreach");
            Console.WriteLine(" Usuário, digite uma sequência de números para armazenar...");


            List<int> listex17 = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Número " + i + ": ");
                string inputN17 = Console.ReadLine();
                int numeroex17 = int.Parse(inputN17);
                listex17.Add(numeroex17);
            }

            int maior = listex17[0];
            int menor = listex17[0];

            for (int i = 1; i < listex17.Count; i++)
            {
                if (listex17[i] > maior)
                {
                    maior = listex17[i];
                }
                if (listex17[i] < menor)
                {
                    menor = listex17[i];
                }
            }

            Console.WriteLine($" O maior numero da lista é {maior} e o menor número é {menor}");
            Console.ReadKey();
            Console.Clear();


            // Exercicio 18
            // Faça um programa que leia uma string e conte o número de vogais na string usando um loop foreach.

            Console.WriteLine(" Um programa que le uma string e conte o numero de vogais usando um loop foreach");
            Console.WriteLine(" Digite uma frase...");
            string inputuser = Console.ReadLine().ToLower();

            int contadorVogal = 0;

            foreach (char caractere in inputuser)
            {
                if ("aeiou".Contains(caractere))
                {
                    contadorVogal++;
                }
            }
            Console.WriteLine($"O numero de vogais é de : {contadorVogal}");
            Console.ReadKey();
            Console.Clear();

            // Exercicio 19
            //Crie um programa que peça ao usuário para digitar um número n e então imprima a sequência de Fibonacci até o n-ésimo termo usando um loop for.


            Console.WriteLine("Um programa que pede um Número e imprime a sequencia de fibonacci até o n-ésimo termo usando um loop for!");
            Console.WriteLine("Digite um número...");
            int x = 1, y = 0, z = 0;
            int n = 0;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                z = x + y;
                Console.WriteLine(z);
                y = x;
                x = z;
            }
            Console.ReadLine();
            Console.Clear();


            // Exercicio 20
            // Escreva um programa que leia uma string e a imprima em ordem reversa usando um loop foreach.

            Console.WriteLine("Um programa que lê uma string e imprime a ordem reversa usando loop foreach");
            Console.WriteLine(" Digite uma palavra para o programa. . . ");
            var inputstring = Console.ReadLine();

            var listStr = inputstring.ToList();
            string stringinvertida = "";
            foreach (var palavra in listStr)
            {
                stringinvertida = palavra + stringinvertida;

            }
            Console.WriteLine(stringinvertida);
            Console.ReadKey();
            Console.Clear();


            */
            #endregion Intermediario


            #region Avancado
            /*
            
            // Exercicio 21
            //   Crie um programa que ordena um array de números usando o algoritmo de ordenação de bolha com um loop for.
            // https://www.youtube.com/watch?v=bzwD7qDC-FY


            int[] ArrX = new int[] { 1, 7, 4, 6, 2, 3, 1, 9, 10, 40, 23, 44, 55, 100 };
            foreach (var nmrDesordenado in ArrX)
            {
                Console.WriteLine(nmrDesordenado);
            }
            Console.WriteLine(" Um programa que ordena um array de numeros usando o algoritmo de ordenação de bolha com um loop for");
            metodosfor.bubbleSort(ArrX);
            foreach (var nmrOrdenado in ArrX)
            {
                Console.WriteLine(nmrOrdenado);
            }
            Console.ReadKey();
            Console.Clear();
            */


            // Exercicio 22
            // Escreva um programa que encontre o caminho mais curto em um labirinto usando o algoritmo de busca em profundidade e um loop for.


            
            // Exercicio 23
            // Base do código : https://cursos.alura.com.br/forum/topico-pegar-numeros-primos-de-uma-lista-214928
            // Faça um programa que peça ao usuário para inserir uma série de números e então use um loop for para encontrar todos os números primos na série.
            Console.WriteLine(" Um programa que peça uma serie de numeros e use um loop for pra encontrar todos os numeros primos na serie");
            Console.WriteLine(" Digite uma série de numeros divididos por espaçamento..");
            var InputEx23 = Console.ReadLine();
            var InputSplitado = InputEx23.ToString().Split(' ');

            for (int i = 0; i < InputSplitado.Length; i++)
            {
                int numero = Convert.ToInt32(InputSplitado[i]);

                if (metodosfor.Eprimo(numero))
                {
                    Console.WriteLine($"{numero} é um número primo");
                }
            }
            Console.ReadKey();
            Console.Clear();



            // Exercicio 24
            //Escreva um programa que leia uma string e imprima o número de palavras na string usando um loop foreach.
            // Aulas do garcia !

            Console.WriteLine(" Um programa que leia uma string e leia o numero de palavras na string usando um loop foreach");
            Console.WriteLine(" Digite uma frase, palavra, etc...");
            var frase = Console.ReadLine();
            char[] separadores = { ' ', ',', '.' };

            string[] palavrasSplit = frase.Split(separadores);
            int contadorpalavras = 0;

            foreach (var c in palavrasSplit)
            {
                contadorpalavras++;
            }
            Console.WriteLine($" A frase contém {contadorpalavras} palavras. . . ");
            Console.ReadKey();
            Console.Clear();

            
            // Exercicio 25

            // Crie um programa que calcule a média, a variância e o desvio padrão de uma lista de números usando loops for.
            Console.WriteLine(" Um programa que calcula a média, a variância e o desvio padrao de uma lista de numeros usando loops for");
            List<double> listex25 = new List<double>() { 10, 15, 20, 30, 45, 50 };
            // Média
            double soma = 0;
            foreach (double numero in listex25)
            {
                soma += numero;
            }
            double media = soma / listex25.Count;

            // variança capeta
            double somaDosQuadradosDasDiferencas = 0;
            foreach (double numero in listex25)
            {
                double diferenca = numero - media;
                somaDosQuadradosDasDiferencas += diferenca * diferenca;
            }
            double variancia = somaDosQuadradosDasDiferencas / listex25.Count;

            // desvio padrao
            // classe Math por que não tankei a matematica no braço
            double desvioPadrao = Math.Sqrt(variancia); 

            Console.WriteLine($"Números: {string.Join(", ", listex25)}");
            Console.WriteLine($"Média: {media}");
            Console.WriteLine($"Variância: {variancia}");
            Console.WriteLine($"Desvio Padrão: {desvioPadrao}");


            // Exercicio 26
            // Faça um programa que leia uma string e a imprima sem espaços usando um loop foreach.

            Console.WriteLine(" Um programa que leia uma string e imprima a mesma sem espaços usando um loop foreach. . .");
            Console.WriteLine(" Digite uma frase ou palavra com espaçamento..");
            var palavracomespaco = Console.ReadLine();
            palavracomespaco = palavracomespaco.Replace(" ", "");

            Console.WriteLine($" A frase sem os espaçamentos é : {palavracomespaco}");

            Console.ReadKey();
            Console.Clear();



            // Exercicio 27
            // Escreva um programa em C# que leia uma lista de números e imprima a soma dos números pares e a soma dos números ímpares usando um loop for.
            Console.WriteLine(" Um programa que le uma lista de numeros e imprime a soma dos numeros pares e impares usando for");
            Console.WriteLine("Digite uma lista de números separados por espaços:");
            string[] numerosString = Console.ReadLine().Split(' ');

            int somaPares = 0;
            int somaImpares = 0;

            foreach (string numeroString in numerosString)
            {
                if (int.TryParse(numeroString, out int numero))
                {
                    if (numero % 2 == 0)
                    {

                        somaPares += numero;
                    }

                    else
                    {

                        somaImpares += numero;
                    }

                }
                else
                {
                    Console.WriteLine($"Valor inválido: '{numeroString}'. Ignorando.");
                }
            }

            Console.WriteLine($"Soma dos números pares: {somaPares}");
            Console.WriteLine($"Soma dos números ímpares: {somaImpares}");

            Console.ReadKey();
            Console.Clear();


            // Exercicio 28
            // Crie um programa que leia um número n e imprima o n-ésimo número primo usando um loop for.

            Console.WriteLine(" Um programa que lê um numero n e imprime o n-ésimo numero primo usando loop for ");
            Console.WriteLine(" Digite um número !");
            var nmrPrimo = Convert.ToInt32(Console.ReadLine());

            int contador = 0;
            int NmrAtual = 2;

            while (contador < NmrAtual)
            {
                if (metodosfor.Eprimo(NmrAtual))
                {
                    contador++;
                }

                NmrAtual++;
            }

            Console.WriteLine($"O {NmrAtual}-ésimo número primo é: {NmrAtual - 1}");
            Console.ReadKey();
            Console.Clear();

            // Exercicio 29
            // Faça um programa que leia uma string e conte o número de cada letra na string usando um loop foreach.
            Console.WriteLine(" Um programa que leia uma string e conte o numero de cada letra na string usando loop foreach");
            Console.WriteLine(" Digite uma palavra : ");
            string inputPalavra = Console.ReadLine();
            inputPalavra = inputPalavra.ToLower();
            inputPalavra.ToCharArray();
            Dictionary<char, int> contadorLetras = new Dictionary<char, int>();
            foreach (char c in inputPalavra)
            {
                if (char.IsLetter(c) && char.IsLower(c))
                {
                    if (contadorLetras.ContainsKey(c))
                    {
                        contadorLetras[c]++;
                    }
                    else
                    {
                        contadorLetras[c] = 1;
                    }
                }
            }
            foreach(var letra in contadorLetras)
            {
                Console.WriteLine($" Letra : {letra.Key} aparece : {letra.Value} vezes / vez :  ");
            }
            Console.ReadKey();
            Console.Clear();



            // Exercicio 30
            // Escreva um programa em C# que leia um texto e encontre a palavra mais frequente no texto usando um loop foreach.

            Console.WriteLine(" Um programa em c# que leia um texto e encontre a palavra mais frequente no texto usando um loop foreach");

            string texto = " o cachorro atravessa a rua, rua essa onde há outro cachorro, cachorro este igual aquele cachorro que briga com outros cachorros ";

            var textoseparado = texto.Replace(',', ' ').Split(' ');

            int contadorText = 0;


            foreach (var cachorro in textoseparado)
            {
                if (cachorro == "cachorro")
                {
                    contadorText++;
                }
            }

            Console.WriteLine($" O número de vezes que a palavra  aparece é de {contadorText} vezes.");
            Console.ReadKey();
            Console.Clear();

        }
    }
    #endregion Avancado
}

