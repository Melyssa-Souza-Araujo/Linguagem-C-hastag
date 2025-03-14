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
            string nomeUsuario = " ";
            char sexoUsuario = ' ';

            Console.WriteLine("Insira seu nome: ");
            nomeUsuario = Console.ReadLine();
            Console.WriteLine("Insira seu sexo (F ou M): ");
            sexoUsuario = Convert.ToChar(Console.ReadLine());

            if (sexoUsuario == 'F')
            {
                Console.WriteLine("Seu sexo é feminino");
            
            }
            else
            {
                Console.WriteLine("Seu sexo é masculino");
            }
        }
    }
}
