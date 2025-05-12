namespace aula_08_05
{
    internal class Gerente : FuncionarioNovo
    {
        int qtdFuncionario;
        public Gerente() : base()
        {
        }

        public int QtdFuncionario { get => qtdFuncionario; set => qtdFuncionario = value; }

        public void CancelarOperação() { }
    }
}