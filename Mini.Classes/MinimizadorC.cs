using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Mini.Classes;

namespace Mini.Classes
{
    public class MinimizadorC
    {
        public static void Minimatizar(string[] args)
        {
            var origem = string.Empty;
            var destino = string.Empty;

            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].StartsWith("/o="))
                {
                    origem = args[i].Split('=')[1];
                }
                else if (args[i].StartsWith("/d="))
                {
                    destino = args[i].Split('=')[1];
                }
            }

            var dadosOrigem = File.ReadAllText(origem);
            var dadosDestino = dadosOrigem.Replace(Environment.NewLine, "");

            dadosDestino = string.Join(" ", dadosDestino.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries));

            File.WriteAllText(destino, dadosDestino);
        }

    }
}
