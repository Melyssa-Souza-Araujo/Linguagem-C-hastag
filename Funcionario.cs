using static System.Net.Mime.MediaTypeNames;
using System;

namespace aula_08_05
{
    internal class Funcionario
    {
        string nome;
        string matricula;
        static int contador;
        public Funcionario(string nome, string matricula)
                {
                    Nome = nome;
                    Matricula = matricula;
                    AdicionarFuncionario();
                }

        public string Nome { get => nome; set => nome = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        

        public void Exibirdados()
        { 
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Matricula: " + Matricula);
            Console.WriteLine("Quantidade " + contador);
        }
        public void AdicionarFuncionario()
        {
            Console.WriteLine("Adicionando o funcionário " + ++contador);
        }



    }
}