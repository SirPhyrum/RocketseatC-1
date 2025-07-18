using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NV1
{
    internal class Nome
    {
        public static void Concatena()
        {
            Console.Write("Digite o primeiro nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o sobrenome: ");
            string sobrenome = Console.ReadLine();

            string nomecompleto = nome + ' ' + sobrenome;

            Console.WriteLine($"Nome completo: {nomecompleto}");

            Console.ReadLine();
        }
    }
}
