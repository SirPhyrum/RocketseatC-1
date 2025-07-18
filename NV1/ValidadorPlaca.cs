using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NV1
{
    internal class ValidadorPlaca
    {
        public static void Valida()
        {
            Console.Write("Digite os 7 caracteres da placa do carro: ");
            string placa = Console.ReadLine();

            bool valido;
            try
            {
                if (placa.Length == 7)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        if (char.IsLetter(placa[i]))
                        {
                        }
                        else
                            throw new Exception("A placa digitada não possui três letras no início.");
                    }

                    for (int i = 3; i <= 6; i++)
                    {
                        if (char.IsDigit(placa[i]))
                        {

                        }
                        else
                            throw new Exception("A placa digitada não possui quatro números no final.");
                    }
                    valido = true;
                }
                else
                {
                    throw new Exception("A placa digitada não possui sete digitos.");
                }
            }
            catch (Exception e)
            {
                valido = false;
                Console.WriteLine(e.Message);
            }

            Console.WriteLine($"Placa padrão BR pré 2019: {valido}");

            Console.ReadLine();
        }
    }
}
