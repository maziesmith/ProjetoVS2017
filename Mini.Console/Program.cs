using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Projeto de Estudo 
//Fonte: https://www.youtube.com/watch?v=s7GxuVY2Z-0&t=0s&index=44&list=WL
//Canal: Como Programar Melhor
//05 de julho de 2018

namespace Mini.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var origem = string.Empty;
            var destino = string.Empty;

            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].StartsWith("/o="))
                {
                    origem = args[i].Split('=')[1];
                }else if(args[i].StartsWith("/d="))
                {
                    destino = args[i].Split('=')[1];
                }
            }

            System.Console.Out.WriteLine("Minimalizando ...");

            var dadosOrigem = File.ReadAllText(origem);
            var dadosDestino = dadosOrigem.Replace(Environment.NewLine, "");

            dadosDestino = string.Join(" ", dadosDestino.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries));

            File.WriteAllText(destino, dadosDestino);

            System.Console.ReadKey();


        }
    }
}
