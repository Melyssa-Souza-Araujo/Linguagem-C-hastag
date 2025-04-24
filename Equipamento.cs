namespace aula_24_04
{
    internal class Equipamento
    {
        string nome;
        string fabricante;
        double peso;
        double custo;

        public string Nome { get => nome; set => nome = value; }
        public string Fabricante { get => fabricante; set => fabricante = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Custo { get => custo; set => custo = value; }
        public Equipamento()
        {
        }

        
    }
}