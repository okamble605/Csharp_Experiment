using System;
using System.IO;

namespace ConsoleApp12
{
    internal class Program
    {
       static void Main(string[] args)
        {
            FileStream fs = new FileStream("c:\\test.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("Enter the text which you want to write to the file");
            string str = Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
