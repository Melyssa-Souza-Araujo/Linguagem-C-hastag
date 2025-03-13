using System;
using system.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            string nomeFuncionario = " ";
            int metaAtual = 0;
            const float META_SEMANA = 15000F;

            Console.WriteLine("Qual o nome do funcionário: ");
            nomeFuncionario = Console.ReadLine();
            Console.WriteLine("Entre com os valores das vendas da semana: ");
            metaAtual = Convert.ToSingle(Console.ReadLine());

            if (metaAtual < META_SEMANA)
            {
                Console.WriteLine("Infelizmesnte a sua meta não foi atingida");
            
            }
            else
            {
                Console.WriteLine("Você bateu a meta, parabéns");
            }
        }
    }
}