using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace question_6_evaluation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Copy contents from file1 to file2
            File.Copy("sample1.txt", "sample2.txt");
            Console.WriteLine(File.ReadAllText("sample2.txt"));




            var file = File.ReadAllText(@"C:\Users\mohanabhaskar.parla\source\repos\question 6 evaluation\question 6 evaluation\bin\Debug\sample2.txt");

            FileInfo filetodecrypt = new FileInfo(file);

            filetodecrypt.Encrypt(); //Encrypt



            filetodecrypt.Decrypt(); //Decrypt



        }

    }
}

