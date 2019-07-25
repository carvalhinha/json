using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using Newtonsoft.Json;

namespace Novo
{
    class Menu
    {
        public void telaMenu()
        {
            List<Pessoa> registro = new List<Pessoa>();

            Console.Write("Para alterar um registro digite (S) para sim ou (N) para não: ");
            var soun = Console.ReadLine().ToUpper();
            while (!(soun.Contains("S") || soun.Contains("N")))
            {
                Console.Write("Digite uma opção válida: ");
                soun = Console.ReadLine().ToUpper();
            }
            if (soun == "S" || soun == "s")
            {
                Console.Write("\nDigite uma posição (index) para apagar o registro de alguma pessoa: ");
                int pos = int.Parse(Console.ReadLine());

                if (pos == 0)
                {
                    registro.Remove(registro[pos]);
                    Console.WriteLine($"posição {pos} Removida");
                }
                else
                    Console.WriteLine("Posição não removida, a posição é invalida: ");

                foreach (var r in registro)
                {
                    Console.WriteLine(r);
                }
            }
            else
                Console.WriteLine("Você não alterou nada");
        }
    }
}
