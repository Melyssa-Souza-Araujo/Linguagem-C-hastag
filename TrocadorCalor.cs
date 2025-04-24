namespace aula_24_04
{
    internal class TrocadorCalor
    {
        double areaSuperficie;
        float diametroTubo;
        double comprimentoTubo;
        float pressaoTubo;
        float pressaoRevestimento;

        public double AreaSuperficie { get => areaSuperficie; set => areaSuperficie = value; }
        public float DiametroTubo { get => diametroTubo; set => diametroTubo = value; }
        public double ComprimentoTubo { get => comprimentoTubo; set => comprimentoTubo = value; }
        public float PressaoTubo { get => pressaoTubo; set => pressaoTubo = value; }
        public float PressaoRevestimento { get => pressaoRevestimento; set => pressaoRevestimento = value; }
        public TrocadorCalor()
        {
        }

        
    }
}