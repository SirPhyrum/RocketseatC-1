using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NV1;

public class BoasVindas
{
    public static void Saudacao()
    {
        Console.Write("Digite o nome da pessoa: ");
        string nome = Console.ReadLine();
        Console.Write("Digite a mensagem de boas vindas: ");
        string boasvindas = Console.ReadLine();

        Console.WriteLine($"Olá {nome}! {boasvindas}");

        Console.ReadLine();
    }
}




