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
    }
}
