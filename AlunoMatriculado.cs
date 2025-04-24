namespace aula_24_04
{
    internal class AlunoMatriculado
    {
        string matricula;
        string nome;
        float np1;
        float np2;
        float trabalho;

        public string Matricula { get => matricula; set => matricula = value; }
        public string Nome { get => nome; set => nome = value; }
        public float Np1 { get => np1; set => np1 = value; }
        public float Np2 { get => np2; set => np2 = value; }
        public float Trabalho { get => trabalho; set => trabalho = value; }

        public double CalcularMedia()
        {
            duble retorno = 0;
            retorno = ((Np1 * 2.5) + (Np2 * 2.5) + (Trabalho * 2)) / 7;
            return retorno;
        }

        public double CalcularValorFaltanteProvaFinal()
        {
            double retorno = 0;
            if(CalcularMedia() <= 7){
                retorno = (10 - CalcularMedia());
            }
            return retorno;
        }

        public AlunoMatriculado()
        {
        }

        
    }
}