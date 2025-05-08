using static System.Net.Mime.MediaTypeNames;
using System;

namespace aula_08_05
{
    internal class Funcionario
    {
        /*string nome;
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
        }*/

        string nome;
        string cpf;
        double salario;
        int senha;

        public Funcionario(string nome, string cpf, double salario)
        {
            Nome = nome;
            Cpf = cpf;
            Salario = salario;
        }


        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public double Salario { get => salario; set => salario = value; }
        public int Senha { get => senha; set => senha = value; }

        public bool Autenticar(int senha)
        {
            return true;
        }

    }
}