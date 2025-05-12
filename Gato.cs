namespace aula_08_05
{
    internal class Gato : Animal
    {
        public Gato(string nome) : base(nome)
        { 
        }
        
        public string FazerBarulho()
        {
            return "Miau";
        }
        
    }
}