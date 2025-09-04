namespace TEPOOExemploCamadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClienteService service = new ClienteService();
            int opcao;

            do
            {
                Console.WriteLine("=== SISTEMA DE CLIENTES (Arquitetura em Camadas) ===");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Listar Clientes");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());
                
                if (opcao == 1)
                {
                    Console.Write("Digite o nome do cliente: ");
                    string nome = Console.ReadLine();
                    try
                    {
                        service.CadastrarCliente(nome);
                        Console.WriteLine("Cliente cadastrado com sucesso!\n");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro: {ex.Message}\n");
                    }
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("\n--- Lista de Clientes ---");
                    foreach (var cliente in service.ObterClientes())
                    {
                        Console.WriteLine(cliente);
                    }
                    Console.WriteLine();
                }

            } while (opcao != 0);

            Console.WriteLine("Encerrando o sistema...");
        }
    }
}
