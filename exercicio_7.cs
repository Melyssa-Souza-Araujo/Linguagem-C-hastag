using System;
using system.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_7
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;

            Console.WriteLine("entre com o primeiro número");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("entre com o segundo número");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("entre com o terceiro número");
            numero3 = Convert.ToInt32(Console.ReadLine());

            if (numero1 <= numero2 + numero3 && numero2 <= numero1 + numero3 && numero3 <= numero1 + numero2)
            {
                if (numero1 == numero2 && numero1 == numero3)
                {
                    Console.WriteLine("É um triângulo equilátero");
                }
                else if (numero1 == numero2 || numero1 == numero3 || numero2 == numero3)
                {
                    Console.WriteLine("É um triângulo isósceles");
                }
                else
                {
                    Console.WriteLine("É um triângulo escaleno");
                }
            else
            {
                Console.WriteLine("Valores inválidos");
            }
        }
    }
}