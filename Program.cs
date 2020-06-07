using System;

namespace programa1
{
    class Program
    {
        static void Main(string[] args)
        {
           float a = args.Length;
            for (int i = 0; i < a; i++)
            {
                string text = System.IO.File.ReadAllText(@args[i]);
                text= text.Replace(" ", ",");
                System.Console.WriteLine("Archivo No. : " +(i+1));
                System.Console.WriteLine(text+"\n");
                
            }

        }
    }
}
