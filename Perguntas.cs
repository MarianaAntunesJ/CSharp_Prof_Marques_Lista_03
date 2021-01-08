using System;

namespace Lista_03
{
    class Perguntas
    {
        static void ExibirNxN(int[,] vetor, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($" {vetor[i, j]} |");
                }
                Console.WriteLine("");
            }
        }

        static void ExibirNxP(int[,] vetor, int n, int p)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    Console.Write($" {vetor[i, j]} |");
                }
                Console.WriteLine("");
            }
        }

        static int[,] CriaVetorNxNRandom(int n)
        {
            Random random = new Random();
            int[,] vetor = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    vetor[i, j] = random.Next(1, 100);
                }
            }
            return vetor;
        }

        static int[,] CriaVetorNxPRandom(int n, int p)
        {
            Random random = new Random();
            int[,] vetor = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    vetor[i, j] = random.Next(1, 100);
                }
            }
            return vetor;
        }

        static public void Pergunta01()
        {
            Console.WriteLine("Digite o valor de N: ");
            int n = int.Parse(Console.ReadLine());
            int[,] vetor1 = CriaVetorNxNRandom(n);
            int[,] vetor2 = CriaVetorNxNRandom(n);
            int[,] vetorSaida = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    vetorSaida[i, j] = vetor1[i, j] + vetor2[i, j];
                    Console.Write($" {vetorSaida[i, j]} |");
                }
                Console.WriteLine("");
            }
        }

        static public void Pergunta02()
        {
            Console.WriteLine("Digite o valor de N: ");
            int n = int.Parse(Console.ReadLine());
            int[,] vetor = CriaVetorNxNRandom(n);
            int[,] vetorTransposto = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    vetorTransposto[j, i] = vetor[i, j];
                }
            }
            ExibirNxN(vetor, n);
            Console.WriteLine("");
            ExibirNxN(vetorTransposto, n);
        }

        static public void Pergunta03()
        {
            Console.WriteLine("Digite o valor de N: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de P: ");
            int p = int.Parse(Console.ReadLine());

            int[,] vetor = CriaVetorNxPRandom(n, p);

            Console.WriteLine("Digite o valor de K: ");
            int k = int.Parse(Console.ReadLine());

            bool encontrado = false;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    if (vetor[i, j] == k)
                    {
                        Console.WriteLine($"O elemento {k} está na linha {i}, coluna {j}");
                        encontrado = true;
                    }
                }
            }

            if (!encontrado)
                Console.WriteLine($"Elemento {k} não encontrado.");
        }

        static public void Pergunta04()
        {
            Console.WriteLine("Digite o valor de N: ");
            int n = int.Parse(Console.ReadLine());
            int[,] vetor = CriaVetorNxNRandom(n);
            string tabulacao;
            for (int i = 0; i < (n - 1); i++)
            {
                for (int j = (i + 1); j < n; j++)
                {
                    tabulacao = new String('\t', i);
                    Console.Write($"{tabulacao} {vetor[i, j]} |   ");
                }
                Console.WriteLine("");
            }
        }

        static public void Pergunta05()
        {
            Console.WriteLine("Digite o valor de N: ");
            int n = int.Parse(Console.ReadLine());
            int[,] vetor = CriaVetorNxNRandom(n);

            Console.WriteLine("\nDiagonal principal: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (i == j)
                        Console.WriteLine($" {vetor[i, j]} |");
                }
            }

            Console.WriteLine("\nDiagonal secundária: ");
            for (int i = n; i >= 0; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j == n - 1)
                        Console.WriteLine($" {vetor[i, j]} |");
                }
            }
        }

        static public void Pergunta06()
        {
            Console.WriteLine("Digite o valor de N: ");
            int n = int.Parse(Console.ReadLine());
            double[,] vetor = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i < j)
                        vetor[i, j] = ((2 * i) + (6 * j)) - 1;
                    else if (i == j)
                        vetor[i, j] = (5 * (Math.Pow(i, 2))) - 2;
                    else if (i > j)
                        vetor[i, j] = (4 * (Math.Pow(i, 3))) + (5 * (Math.Pow(j, 2))) + 1;
                }
            }
            Exibir(vetor, n);

            void Exibir(double[,] vetor, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($" {vetor[i, j]} |");
                    }
                    Console.WriteLine("");
                }
            }
        }

        static public void Pergunta07()
        {
            Console.WriteLine("Digite o valor de N: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de P: ");
            int p = int.Parse(Console.ReadLine());

            int[,] vetor = CriaVetorNxPRandom(n, p);
            ExibirNxP(vetor, n, p);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    if (vetor[i, j] % 2 == 0)
                        vetor[i, j] *= 5;
                    else
                        vetor[i, j] *= 3;
                }
            }
            ExibirNxP(vetor, n, p);
        }

        static public void Pergunta08()
        {
            Console.WriteLine("Digite o valor de N: ");
            int n = int.Parse(Console.ReadLine());

            int[,] vetor1 = CriaVetorNxNRandom(n);
            int[,] vetor2 = CriaVetorNxNRandom(n);

            int contador = 0;
            bool encontrado = false;

            for (int k = 0; k < n; k++)
            {
                for (int l = 0; l < n; l++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (vetor1[k, l] == vetor2[i, j])
                            {
                                contador++;
                                encontrado = true;
                                break;
                            }
                        }
                        if (encontrado)
                            break;
                    }
                }
            }

            ExibirNxN(vetor1, n);
            Console.WriteLine("");
            ExibirNxN(vetor2, n);

            Console.WriteLine($"A porcentagem de elementos da Matriz 01, " +
                              $"que aparecem na matriz 02 é de {((double)contador / (n * n)) * 100:F2}%");
        }

        static public void Pergunta09()
        {
            Console.WriteLine("Digite o valor de N: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de P: ");
            int p = int.Parse(Console.ReadLine());

            int[,] vetor = CriaVetorNxPRandom(n, p);

            ExibirNxP(vetor, n, p);
            bool encontrado = false;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    if (Primo(vetor[i, j]))
                    {
                        Console.WriteLine($"O Elemento {vetor[i, j]} na " +
                            $"posição linha {i}, coluna {j} é primo.");
                        encontrado = true;
                    }
                }
            }

            if (!encontrado)
                Console.WriteLine("Não há primos nesta matriz.");

            bool Primo(int numero)
            {
                int qntDivisores = 0;

                for (int i = 1; i <= (int)(numero / 2); i++)
                    if (numero % i == 0)
                    {
                        qntDivisores++;
                        if (qntDivisores > 1)
                            return false;
                    }
                return true;
            }
        }

        static public void Pergunta10()
        {
            Console.WriteLine("Digite o valor de N: ");
            int n = int.Parse(Console.ReadLine());
            int[,] vetor1 = CriaVetorNxNRandom(n);
            int[,] vetor2 = CriaVetorNxNRandom(n);
            int[,] vetorFinal = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        vetorFinal[i, j] += vetor1[i, k] * vetor2[k, j];

                    }
                }
            }
            ExibirNxN(vetorFinal, n);
        }
    }
}
