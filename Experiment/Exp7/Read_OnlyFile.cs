using System;
using System.IO;

namespace ConsoleApp12
{
    internal class Program
    {
        public void ReadData()
        {
            try
            {
                using (FileStream fs = new FileStream("c:\\test.txt", FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        Console.WriteLine("Program to show content of test file");
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found. Please make sure the file exists.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.ReadData();

            Console.WriteLine("\nPress Enter to exit.");
            Console.ReadLine();
        }
    }
}
