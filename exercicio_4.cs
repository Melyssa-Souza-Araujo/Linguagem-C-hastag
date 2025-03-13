using System;
using system.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_4
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4, media, somaNotas = 0;

            Console.WriteLine("Coloque a primeira nota ");
            nota1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Coloque a segunda nota ");
            nota2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Coloque a terceira nota ");
            nota3 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Coloque a quarta nota ");
            nota4 = Convert.ToSingle(Console.ReadLine());

            somaNotas = nota1 + nota2 + nota3 + nota4;
            media = somaNotas / 4;
            Console.WriteLine("A média das notas é: " + media);
        }
    }
}