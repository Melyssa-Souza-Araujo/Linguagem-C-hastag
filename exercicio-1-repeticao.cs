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
           const float PRECO_ALUNO = 0.30F;
           const float PRECO_NAO_ALUNO = 0.50F;
           float resultado = 0F;
           string resposta = "";

           Console.WriteLine("Você é um aluno? Responda com sim ou não");
           resposta = Console.ReadLine();

           if (resposta == "sim")
           {
               for (int i = 1; i <= 100; i++)
               {
                   Console.WriteLine("Tabela de preço de Xerox para alunos");
                   resultado = PRECO_ALUNO * i;
                   Console.WriteLine(PRECO_ALUNO + " * " + i + " = " + resultado);
               }
           }
           if (resposta == "não")
           {
               for (int i = 1; i <= 100; i++)
               {
                   Console.WriteLine("Tabela de preço de Xerox");
                   resultado = PRECO_NAO_ALUNO * i;
                   Console.WriteLine(PRECO_NAO_ALUNO + " * " + i + " = " + resultado);
               }
           }
         }
    }
}
