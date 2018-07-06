using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mini.Classes;

//Projeto de Estudo 
//Fonte: https://www.youtube.com/watch?v=s7GxuVY2Z-0&t=0s&index=44&list=WL
//Canal: Como Programar Melhor
//05 de julho de 2018

namespace Mini.Console
{
    public static class Program
    {

        static void Main(string[] args)
        {
            System.Console.Out.WriteLine("Minimalizando ...");

            MinimizadorC.Minimatizar(args);

            System.Console.ReadKey();


        }
    }
}
