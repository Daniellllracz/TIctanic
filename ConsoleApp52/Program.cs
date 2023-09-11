using ConsoleApp65;
using System;
using System.Collections.Generic;
using System.IO;


namespace ConsoleApp52
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ConsoleApp65.Kategoria> kategoriak = new List<ConsoleApp65.Kategoria>();
            StreamReader streamReader = new StreamReader(
                            path: @"..\..\src\titanic.txt",
                            encoding: System.Text.Encoding.UTF8);
            var src = streamReader;
            while (!src.EndOfStream)
            {
                string sor = src.ReadLine();
                var kat = new Kategoria(sor);
                kategoriak.Add(kat);
            }
            Console.WriteLine($"{kategoriak.Count}");
            Console.ReadKey(true);

        }
    }
}

