namespace aula_08_05
{
    internal class Quadrado : Forma
    {
        int CalcularArea()
        {
            int retorno;
            retorno = this.Lado * this.Lado;
            return retorno;
        }

        float CalcularCusto(float custoPorArea)
        {
            float retorno;
            retorno = CalcularArea() * custoPorArea;
            return retorno;
        }
        public Quadrado()
        {
        }
    }
}