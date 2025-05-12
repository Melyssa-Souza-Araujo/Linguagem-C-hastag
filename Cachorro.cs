namespace aula_08_05
{
    internal class Cachorro : Animal
    {

        public Cachorro(string nome) : base(nome)
        { 
        }
        
        public string FazerBarulho()
        {
            return "Au Au";
        }
        
    }
}