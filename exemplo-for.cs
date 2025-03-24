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
           int resultado = 0;
            
           Console.WriteLine("Entre com o 1° valor: ");
           valor1 = Convert.ToInt32(Console.ReadLine());
           for (int i = 0; i <= 10; i++)
           {
                resultado = i * valor1;
                Console.WriteLine( valor1 + " * " + i + " = " + resultado);
            }
            Console.WriteLine("Saindo do programa...");
        }
    }
}