namespace aula_08_05
{
    internal class Animal
    {
        string nome;
        string raca;

        public Animal() { }
        
        public Animal(string nome)
        {
            Nome = nome;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Raca { get => raca; set => raca = value; }

        public string Locomover() 
        {
            return "VRUMMMMM";
        }
        public string FazerBarulho()
        {
            return "MMMMMMM";
        }
        
    }
}