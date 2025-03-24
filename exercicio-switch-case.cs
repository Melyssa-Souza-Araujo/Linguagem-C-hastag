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
            int opcao = 1;
            Console.WriteLine("- - - - - - - - - -");
            Console.WriteLine("Menu Principal");
            Console.WriteLine("- - - - - - - - - -");
            Console.WriteLine("1 - Opção 1");
            Console.WriteLine("2 - Opção 2");
            Console.WriteLine("3 - Opção 3");
            Console.WriteLine("4 - Opção 4");
            Console.WriteLine("0 - SAIR");
            Console.WriteLine("- - - - - - - - - -");
            
            Console.WriteLine("Digite uma opção: ");
            opcao = Convert.ToInt32(Console.ReadLine());
            
            switch (opcao)
            {
                case 0:
                    Console.WriteLine("Voce escolheu SAIR");
                    break;
                case 1:
                    Console.WriteLine("Voce escolheu OPCÇÃO 1");
                    break;
                case 2:
                    Console.WriteLine("Voce escolheu OPCÇÃO 2");
                    break;
                case 3:
                    Console.WriteLine("Voce escolheu OPCÇÃO 3");
                    break;
                case 4:
                    Console.WriteLine("Voce escolheu OPCÇÃO 4");
                    break;
                default:
                    Console.WriteLine("Voce escolheu uma opção inválida");
                    break;
            }
        }
    }
}