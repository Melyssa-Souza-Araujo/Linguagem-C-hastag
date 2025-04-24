namespace aula_24_04
{
    internal class Caneta
    {
        string cor;
        enum Tipo
        {
            esferográfica,
            rollerball,
            gel,
            tinteiro,
            ponta_feltro
        }

        Tipo tipoCaneta;
        public Caneta( string cor)
        {
            this.cor = cor;
        }

        public string Cor { get => cor; set => cor = value; }
        private Tipo TipoCaneta { get => tipoCaneta; set => tipoCaneta = value; }
    }
}