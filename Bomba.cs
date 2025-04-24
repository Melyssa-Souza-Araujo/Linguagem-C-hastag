namespace aula_24_04
{
    internal class Bomba
    {
        double pressaoSuccao;
        double pressaoDescarga;
        float velocidadeFluxo;

        public double PressaoSuccao { get => pressaoSuccao; set => pressaoSuccao = value; }
        public double PressaoDescarga { get => pressaoDescarga; set => pressaoDescarga = value; }
        public float VelocidadeFluxo { get => velocidadeFluxo; set => velocidadeFluxo = value; }
        public Bomba()
        {
        }

        
    }
}