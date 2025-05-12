using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_08_05
{
    internal class Program
    {
        static void Main(string args)
        {
            Cachorro brownie = new Cachorro("Brownie");
            Console.WriteLine(brownie.FazerBarulho());
            Cachorro aysha = new Cachorro("Aysha");
            Console.WriteLine(aysha.FazerBarulho());
            Gato pandora = new Gato("pandora");
            Console.WriteLine(pandora.FazerBarulho());
        }
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario("Júlio", "0001");
            funcionario1.Exibirdados();
            Funcionario funcionario2 = new Funcionario("Marcos", "0002");
            funcionario1.Exibirdados();
            Funcionario funcionario3 = new Funcionario("Juliana", "0003");
            funcionario1.Exibirdados();
            Funcionario funcionario4 = new Funcionario("Laura", "0004");
            funcionario1.Exibirdados();
            FuncionarioNovo funcionarionovo1 = new FuncionarioNovo();
            Gerente gerente1 = new Gerente();
            Forma forma1 = new Forma();
            Quadrado quadrado1 = new Quadrado();
            Animal animal = new Animal();
            Cachorro cachorro1 = new Cachorro();
            Gato gato1 = new Gato();
        }
    }
}
