using System;
using System.IO;
using Newtonsoft.Json;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Novo
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\Treinamento 3\source\repos\Novo\Trabalho.json";
            string readText = File.ReadAllText(path);
            var pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(readText);

            foreach (var p in pessoas)
            {
                Console.WriteLine(p);
            }

            Console.Write("Para alterar um registro digite (S) para sim ou (N) para não: ");
            var soun = Console.ReadLine().ToUpper();
            while (!(soun.Contains("S") || soun.Contains("N")))
            {
                Console.Write("Digite uma opção válida: ");
                soun = Console.ReadLine().ToUpper();
            }
            if (soun == "S" || soun == "s")
            {
                Console.Write("\nDigite uma posição para apagar o registro de alguma pessoa: ");
                var pos = Console.ReadLine();
                var item = pessoas.Single(r => r.Index == pos);

                pessoas.Remove(item);
            }
            foreach (var p in pessoas)
            {
                Console.WriteLine(p);
            }

            string path2 = @"C:\Users\Treinamento 3\source\repos\Novo\Trabalho2.json";

            
            Guid g = Guid.NewGuid();
            using (StreamWriter sw = File.AppendText(path2))
            {
                var pessoas2 = JsonConvert.SerializeObject(pessoas);
                sw.WriteLine(pessoas2); 
            }
        }
    }
}
