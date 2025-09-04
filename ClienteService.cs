namespace TEPOOEExemploCamadas.Business
{
    internal class ClienteService
    {
        private ClienteRepository _repository = new ClienteRepository();

        public void CadastrarCliente(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new System.Exception("O nome não pode ser vazio!");

            _repository.Adicionar(nome);
        }

        public List<string> ObterClientes()
        {
            return _repository.Listar();
        }
    }
}
