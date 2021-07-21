using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = @"C:\TestingDeleteFile";
            int ndays = 1;
            Class1 c = new Class1();
            c.file(dir, ndays);
            //string directory = @"C:\Users\DELL\AppData\Local\Temp";

            //if (Directory.Exists(directory))
            //{
            //    //if() 
            //    Console.WriteLine("exists");
            //    System.Console.ReadLine();
            //}
        }
    }
}
