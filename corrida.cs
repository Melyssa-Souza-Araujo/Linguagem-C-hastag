using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace corrida
{
    internal class Program
    {

        private const int DISTANCIA_TOTAL = 100;
        private static bool corridaFinalizada = false;
        private static readonly object lockObj = new object();

        static async Task Main(string[] args)
        {
            Console.CursorVisible = false; // Oculta o cursor para ficar mais bonito
            Console.WriteLine("🏁 Iniciando a corrida!");

            Task t1 = Correr("Carro Vermelho", 2, ConsoleColor.Red);
            Task t2 = Correr("Carro Azul", 4, ConsoleColor.Blue);
            Task t3 = Correr("Carro Verde", 6, ConsoleColor.Green);

            await Task.WhenAll(t1, t2, t3);

            Console.SetCursorPosition(0, 8);
            Console.WriteLine("Corrida finalizada!");
            Console.CursorVisible = true;
        }

        static async Task Correr(string nome, int linha, ConsoleColor cor)
        {
            Random random = new Random();
            int posicao = 0;

            while (posicao < DISTANCIA_TOTAL && !corridaFinalizada)
            {
                int passo = random.Next(1, 4); // Avança de 1 a 3 posições
                posicao += passo;
                if (posicao > DISTANCIA_TOTAL)
                    posicao = DISTANCIA_TOTAL;

                lock (lockObj)
                {
                    Console.SetCursorPosition(0, linha);
                    Console.ForegroundColor = cor;
                    Console.Write($"{nome.PadRight(15)}: ");
                    Console.ResetColor();

                    // Imprime a pista
                    for (int i = 0; i < DISTANCIA_TOTAL; i++)
                    {
                        if (i == posicao)
                            Console.Write("🚗"); // Carro na posição atual
                        else
                            Console.Write("-"); // Pista
                    }
                    Console.Write("  "); // Limpa sobra da linha

                    if (posicao >= DISTANCIA_TOTAL && !corridaFinalizada)
                    {
                        corridaFinalizada = true;
                        Console.SetCursorPosition(0, 8);
                        Console.ForegroundColor = cor;
                        Console.WriteLine($"\n🏁 {nome} venceu a corrida!\n");
                        Console.ResetColor();
                    }
                }

                await Task.Delay(200);
            }
        }
    }
}
