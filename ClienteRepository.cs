namespace TEPOOExemploCamadas.Data
{
    internal class ClienteRepository
    {
        private List<string> clientes = new List<string>();

        public void Adicionar(string nome)
        {
            clientes.Add(nome);
        }

        public List<string> Listar()
        {
            return clientes;
        }

        public bool RemoverCliente(int indice)
        {
            if (indice >= 0 && indice < clientes.Count)
            {
                clientes.RemoveAt(indice);
                return true;
            }
            return false;
        }

        public bool AlterarCliente(int indice, string novoNome)
{
    if (indice >= 0 && indice < clientes.Count)
    {
        clientes[indice] = novoNome;
        return true;
    }
    return false;
        }
    }
}
