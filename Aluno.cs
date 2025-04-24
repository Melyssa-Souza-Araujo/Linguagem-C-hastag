namespace aula_24_04
{
    internal class Aluno    
    {
        string nome;
        string ra;
        float t1;
        float t2;
        float p1;
        float p2;

        public string Nome { get => nome; set => nome = value; }
        public string Ra { get => ra; set => ra = value; }
        public float T1 { get => t1; set => t1 = value; }
        public float T2 { get => t2; set => t2 = value; }
        public float P1 { get => p1; set => p1 = value; }
        public float P2 { get => p2; set => p2 = value; }

        float CalcularMedia()
        {
            return 0f;
        }
        public Aluno()
        {

        }
    }
}