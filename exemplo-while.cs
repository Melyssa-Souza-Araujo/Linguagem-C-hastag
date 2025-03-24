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
            int valor2 = 0;
            int resultado = 0;
            
            Console.WriteLine("Entre com o primeiro valor: ");
            valor1 = Convert.ToInt32(Console.ReadLine());
            
            while (valor1 != 0)
            {
                Console.WriteLine("Entre com o segundo valor: ");
                valor2 = Convert.ToInt32(Console.ReadLine());
            
                resultado = valor2 / valor1;
                Console.WriteLine("Resultado " + resultado);
            
                Console.WriteLine("Entre com o primeiro valor: ");
                valor1 = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}