using System;

namespace aula_24_04
{
    internal class Alunos
    {
        string nome;
        int idade;

        public enum Tipo
        {
            MB,
            B,
            R,
            I
        }

        Tipo tipoNota;
               
            public string Nome { get => nome; set => nome = value; }
            public int Idade { get => idade; set => idade = value; }
            private Tipo TipoNota { get => tipoNota; set => tipoNota = value; }

        public Alunos()
        {
          
            Nome = "Desconhecido";
            Idade = 0;
            tipoNota = Tipo.MB;
        }

         public void Exibirdados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Nota: {TipoNota}");
        }

    }
}