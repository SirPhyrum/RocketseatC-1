using System.Globalization;

namespace NV1
{
    internal class Calculadora
    {
        public static void Calcula()
        {
            Console.WriteLine("Digite dois números com casas decimais separados por ponto:");
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var n = n2 != 0 ? (n1 / n2).ToString(CultureInfo.InvariantCulture) : "não dividirás por 0";

            Console.WriteLine($"Soma: {(n1+n2).ToString(CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Subtração: {(n1 - n2).ToString(CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Multiplicação: {(n1 * n2).ToString(CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Divisão: {n}");
            Console.WriteLine($"Média: {((n1+n2)/2).ToString(CultureInfo.InvariantCulture)}");

            Console.ReadLine();
        }   
    }
}
