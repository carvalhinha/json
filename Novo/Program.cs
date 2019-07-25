using System;
using System.IO;
using Newtonsoft.Json;
using System.Text;
using System.Collections.Generic;

namespace Novo
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu console = new Menu();            

            string path = @"C:\Users\Treinamento 3\source\repos\Novo\Trabalho.json";

            string readText = File.ReadAllText(path);
           
            var pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(readText);


            foreach (var p in pessoas)
            {
                Console.WriteLine(p);
            }

            console.telaMenu();
        }
    }
}
