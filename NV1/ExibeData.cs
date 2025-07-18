using System.Globalization;

namespace NV1
{
    internal class ExibeData
    {
        public static void menudata()
        {
            int x = 0;
            while (x == 0)
            {
                Console.Clear();

                Console.WriteLine("Digite um número de 1 a 4 para selecionar uma das opções abaixo para a exibição da data:");
                Console.WriteLine("1 Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos\r\n" +
                    "2 Apenas a data no formato (01/03/2024)\r\n" +
                    "3 Apenas a hora no formato de 24 horas\r\n" +
                    "4 A data com o mês por extenso\r\n" +
                    "0 Sair\r\n");

                int n = int.Parse(Console.ReadLine());

                DateTime dt = DateTime.UtcNow.AddHours(-3);

                Console.Clear();

                switch (n)
                {
                    case 0: 
                        x = 1;
                        Console.WriteLine("Tchau!");
                        break;

                    case 1: Console.WriteLine(dt.ToString("F", new CultureInfo("pt-BR"))); break;

                    case 2: Console.WriteLine(dt.ToString("d", new CultureInfo("pt-BR"))); break;

                    case 3: Console.WriteLine(dt.ToString("HH")); break;

                    case 4: Console.WriteLine(dt.ToString("d MMMM yyyy")); break;

                    default: Console.WriteLine("Nenhuma opção válida"); break;

                }
                Console.ReadLine();
            }
        }
    }
}
