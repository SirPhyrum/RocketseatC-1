using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NV1
{
    internal class ContadorCaracteres
    {
        public static void ContaC()
        {
            Console.Write("Digite a(s) palavra(s): ");
            string palavra = Console.ReadLine();

            string[] split = palavra.Split(' ');
            string caracteres = "";

            foreach (string s in split)
                caracteres = caracteres + s;

            Console.WriteLine($"Número de caracteres válidos: {caracteres.Length}");

            Console.ReadLine();
        }
    }
}
