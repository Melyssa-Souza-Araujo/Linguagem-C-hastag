using System;
using system.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_6
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            float peso = 0F;
            float altura = 0F;
            float imc = 0F;

            Console.WriteLine("Coloque seu peso ");
            peso = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Coloque sua altura ");
            nota2 = Convert.ToSingle(Console.ReadLine());

            imc = peso / (altura * altura);
            Console.WriteLine("O seu IMC é: " + imc);
        }
    }
}