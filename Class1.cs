using System;
using System.IO;

namespace ConsoleApp3
{
    class Class1
    {
        public void file(string dir, int ndays)
        {
            //dir = @"C:\Users\DELL\AppData\Local\Temp";
            //ndays = 3;
            string[] Files = Directory.GetFiles(dir);
            foreach (string f in Files)
            {
                if (File.Exists(f) && dir.Length > 5)
                {
                    FileInfo fi = new FileInfo(f);
                    if (fi.LastAccessTime <= DateTime.Now.AddDays(ndays))
                    {
                        fi.Delete();
                    }
                }
                else
                {
                    Console.WriteLine("file not exist or string length is less than 5");
                }

            }
        }




    }
}

