using System;
using System.Collections.Generic;

namespace TEPOOEExemploCamadas.Business
{
    internal class ClienteService
    {
        private ClienteRepository _repository = new ClienteRepository();

        public void CadastrarCliente(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new Exception("O nome não pode ser vazio!");

            _repository.Adicionar(nome);
        }

        public List<string> ObterClientes()
        {
            return _repository.Listar();
        }

        // Método para alterar cliente
        public bool AlterarCliente(int indice, string novoNome)
        {
            return _repository.AtualizarCliente(indice, novoNome);
        }

        // Método para excluir cliente
        public void ExcluirCliente(int indice)
        {
            _repository.Remover(indice);
        }
    }
}
