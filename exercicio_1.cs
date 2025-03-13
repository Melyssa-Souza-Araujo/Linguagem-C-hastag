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
            string nomeAluno = " ";
            int anoNascimento = 0;
            int idadeAluno = 0;
            const int ANO_ATUAL = 2025;

            Console.WriteLine("Qual o nome do aluno: ");
            nomeAluno = Console.ReadLine();
            Console.WriteLine("Qual o ano de nascimento: ");
            anoNascimento = Convert.ToInt32(Console.ReadLine());
            
            idadeAluno = ANO_ATUAL - anoNascimento;

            if (idadeAluno >= 18)
            {
                Console.WriteLine("É maior de idade");
            
            }
            else
            {
                Console.WriteLine("É menor de idade");
            }
        }
    }
}