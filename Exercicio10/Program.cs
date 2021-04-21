using System;

namespace Exercicio10 {
    class Program {
        static void Main(string[] args) {
            try {
                Console.Write("Digite a ordem da matriz: ");
                string[] ordem = Console.ReadLine().Split(' ');
                int linhas = int.Parse(ordem[0]);
                int colunas = int.Parse(ordem[1]);
                int[,] matrix = new int[linhas, colunas];

                for (int i = 0; i < matrix.GetLength(0); i++) {
                    Console.WriteLine();

                    for (int j = 0; j < matrix.GetLength(1); j++) {
                        Console.Write(" _ ");
                    }
                }
                Console.WriteLine(); Console.WriteLine();
                Console.WriteLine("Digite no formato apresentado acima separados por espaço");
                Console.WriteLine(); Console.WriteLine();

                for (int i = 0; i < matrix.GetLength(0); i++) {
                    string[] linhas1 = Console.ReadLine().Split(' ');

                    for (int j = 0; j < matrix.GetLength(1); j++) {
                        matrix[i, j] = int.Parse(linhas1[j]);
                    }
                }
                Console.WriteLine();
                Console.Write("digite um valor pra procurar os sentindos: ");
                int s = int.Parse(Console.ReadLine());

                Console.WriteLine();
                for (int i = 0; i < matrix.GetLength(0); i++) {
                    Console.WriteLine();
                    for (int j = 0; j < matrix.GetLength(1); j++) {
                        Console.Write(matrix[i, j] + " ");
                    }
                }
                Console.WriteLine();
                for (int i = 0; i < matrix.GetLength(0); i++) {
                    for (int j = 0; j < matrix.GetLength(1); j++) {

                        if (s == matrix[i, j]) {
                            Console.WriteLine();
                            Console.WriteLine($"Posição: [{i} , {j}]");
                            if (j + 1 <= colunas)
                                Console.WriteLine("Direita: " + matrix[i, j + 1]);
                            if (j - 1 <= colunas)
                                Console.WriteLine("Esquerda: " + matrix[i, j - 1]);
                            if (i - 1 <= linhas)
                                Console.WriteLine("Cima: " + matrix[i + 1, j]);
                            if (i + 1 <= linhas)
                                Console.WriteLine("Baixo: " + matrix[i + 1, j]);
                        }
                    }
                }
            } catch (IndexOutOfRangeException e) {
                Console.WriteLine(e.Message);
            } catch (InvalidCastException e) {
                Console.WriteLine(e.Message);
            } catch (FormatException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
