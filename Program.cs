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
                Console.WriteLine("3 - Excluir Cliente");
                Console.WriteLine("4 - Atualizar Cliente");
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
                    var clientes = service.ObterClientes();
                    for (int i = 0; i < clientes.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} - {clientes[i]}");
                    }
                    Console.WriteLine();
                }
                else if (opcao == 3)
                {
                    Console.Write("Digite o nome do cliente a ser excluído: ");
                    string nome = Console.ReadLine();
                    try
                    {
                        service.ExcluirCliente(nome);
                        Console.WriteLine("Cliente excluído com sucesso!\n");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro: {ex.Message}\n");
                    }
                }
                else if (opcao == 4)
                {
                    var clientes = service.ObterClientes();

                    if (clientes.Count == 0)
                    {
                        Console.WriteLine("Não há clientes para atualizar.\n");
                    }
                    else
                    {
                        Console.WriteLine("\n--- Atualizar Cliente ---");
                        for (int i = 0; i < clientes.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} - {clientes[i]}");
                        }

                        Console.Write("Digite o número do cliente que deseja atualizar: ");
                        int indice = int.Parse(Console.ReadLine()) - 1;

                        Console.Write("Digite o novo nome: ");
                        string novoNome = Console.ReadLine();

                        if (service.AlterarCliente(indice, novoNome))
                        {
                            Console.WriteLine("Cliente atualizado com sucesso!\n");
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida.\n");
                        }
                    }
                }

            } while (opcao != 0);

            Console.WriteLine("Encerrando o sistema...");
        }
    }
}
