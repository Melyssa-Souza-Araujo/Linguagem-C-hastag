namespace aula_24_04
{
    internal class Conta
    {
        string numero;
        string cliente;
        double saldo; 
        public string Numero { get => numero; set => numero = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public double Saldo { get => saldo; set => saldo = value; }

        void Depositar(double valor) { }
        void Sacar(double valor) { }
        void FazerPix(double valor) { }

        public Conta()
        {
        }

        
    }
}