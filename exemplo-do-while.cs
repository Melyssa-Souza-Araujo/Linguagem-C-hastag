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
           int valor1 = 0;
 
            do
            {
                Console.WriteLine("Insira um valor");
                valor1 = Convert.ToInt32(Console.ReadLine());
            }
            while (valor1 < 100);
            Console.WriteLine("Valor inválido");
        }
    }
}