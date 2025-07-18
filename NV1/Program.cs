using System;

namespace NV1;

internal class Program
{
    static void Main()
    {

        int x = 0;

        while (x == 0)
        {
            Console.Clear();
            Console.WriteLine("Digite o número referente a opção que deseja:\r\n" +
                "1 Mensagem de boas vindas\r\n" +
                "2 Nome e Sobrenome\r\n" +
                "3 Calculos com dois números\r\n" +
                "4 Contador de caracteres\r\n" +
                "5 Verificador de placa de veículo\r\n" +
                "6 Exibição de data\r\n" +
                "0 Sair\r\n");

            int n = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (n)
            {
                case 0: 
                    x = 1;
                    Console.WriteLine("Tchau!");
                    break;

                case 1: BoasVindas.Saudacao(); break;

                case 2: Nome.Concatena(); break;

                case 3: Calculadora.Calcula(); break;

                case 4: ContadorCaracteres.ContaC(); break;

                case 5: ValidadorPlaca.Valida(); break;

                case 6: ExibeData.menudata(); break;

                default: Console.WriteLine("Opção inválida"); break;
            }
        }

    }
}