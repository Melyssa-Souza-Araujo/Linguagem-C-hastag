using System;
using system.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_1
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            double precoAluno = 0.30D;
 double precoNaoAluno = 0.50;
 double valorAluno = 0;
 double valorNaoAluno = 0;

 Console.WriteLine("Tabela de Preços da Copiadora");
 Console.WriteLine("- - - - - - - - - - - -");
 Console.WriteLine("| Quantidade | Aluno (R$) | Não Aluno (R$) |");
 Console.WriteLine("- - - - - - - - - - - -");

 for (int i = 1; i <= 100; i++)
 {
     valorAluno = i * precoAluno;
     valorNaoAluno = i * precoNaoAluno;
     Console.WriteLine("| " + i + " | " + valorAluno + " | " + valorNaoAluno + " |");
 }
 Console.WriteLine("- - - - - - - - - - - -");
         }
    }
}
