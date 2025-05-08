namespace aula_08_05
{
    internal class Funcionario1
    {
        string nome;
        string cpf;
        double salario;
        int senha;

        public Funcionario1(string nome, string cpf, double salario)
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