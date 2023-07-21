namespace ConsoleDesafiosFor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            #region Basica


            // Escreva um programa em C# que imprima todos os números de 1 a 10 usando um loop for.

            Console.WriteLine("Escrever um programa que imprima numeros de 1 a 10.");

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            Console.Clear();


            // Escreva um programa em C# que imprima todos os números pares entre 1 e 20 usando um loop for.

            Console.WriteLine("Um programa que imprime os numeros pares entre o numero 1 e o numero 20.");

            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            Console.Clear();


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

            // Crie um programa que imprima todos os elementos de uma lista de strings utilizando um loop foreach.

            Console.WriteLine(" Um programa que imprime os elementos de uma lista de strings, usando loop foreach : ");

            List<string> listastringUm = new List<string>() { "A", "B", "C", "D", "E", "F", "G" };
            foreach (string str in listastringUm)
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();
            Console.Clear();

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


            // Escreva um programa em C# que imprima os números ímpares entre 1 e 10 usando um loop foreach em uma lista.
            Console.WriteLine(" Um programa que escreve os numeros ímpares entre 1 e 10 em um loop foreach em uma lista : ");

            for (int i = 1; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            Console.Clear();


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




            #endregion Basica
            


            #region Intermediario

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


            int maior = int.MaxValue;
            int menor = int.MinValue;

            foreach (int numeross in listex17)
            {

            }
            // Terminar código



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


            
            #endregion Intermediario
            

            #region Avancado


            //   Crie um programa que ordena um array de números usando o algoritmo de ordenação de bolha com um loop for.
            // Inacabado

            Console.WriteLine(" Um programa que ordena um array de numeros usando o algoritmo de ordenação de bolha com um loop for");


            // Escreva um programa que encontre o caminho mais curto em um labirinto usando o algoritmo de busca em profundidade e um loop for.



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

            // Crie um programa que calcule a média, a variância e o desvio padrão de uma lista de números usando loops for.


            // Faça um programa que leia uma string e a imprima sem espaços usando um loop foreach.

            Console.WriteLine(" Um programa que leia uma string e imprima a mesma sem espaços usando um loop foreach. . .");
            Console.WriteLine(" Digite uma frase ou palavra com espaçamento..");
            var palavracomespaco = Console.ReadLine();

            //var palavraSemEspaco = palavracomespaco.Replace(" ", "");

            foreach (var c in palavracomespaco.Replace(" ", ""))
            {
                Console.WriteLine($" A frase sem os espaçamentos é : {c}");
            }

            Console.ReadKey();
            Console.Clear();




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
        }

        // Crie um programa que leia um número n e imprima o n-ésimo número primo usando um loop for.



        #endregion Avancado
    }
}
