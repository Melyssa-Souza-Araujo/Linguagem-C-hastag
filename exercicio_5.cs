using System;
using system.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_5
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            int nota1 = 0; 
            int nota2 = 0; 
            int nota3 = 0; 
            int nota4 = 0; 
            float media = 0F;

            Console.WriteLine("Coloque a primeira nota ");
            nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Coloque a segunda nota ");
            nota2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Coloque a terceira nota ");
            nota3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Coloque a quarta nota ");
            nota4 = Convert.ToInt32(Console.ReadLine());

            media = ((nota1 * 2) + (nota2 * 2) + (nota3 * 3) + (nota4 * 3)) / (2 + 2 + 3 +2);
            Console.WriteLine("A média ponderada das notas é: " + media);
        }
    }
}