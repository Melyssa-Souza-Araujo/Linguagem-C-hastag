using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEPOOManha
{
    internal class Program
    {
        static List<string> clientes = new List<string>();
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.WriteLine("=== SISTEMA DE CLIENTES (Monolítico) ===");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Listar Cliente");
                Console.WriteLine("0 - Sair");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("Digite o nome do cliente: ");
                    string nome = Console.ReadLine();
                    clientes.Add(nome);
                    Console.WriteLine("Cliente cadastrado com sucesso!\n");
                }
                else if (opcao == 2){
                    Console.WriteLine("\n--- Lista de Clientes ---");
                    foreach (var c in clientes) 
                    { 
                        Console.WriteLine(c);
                    }
                    Console.WriteLine();
                }
            } while (opcao != 0);
            Console.WriteLine("Encerrando o sistema...");
        }
    }
}
