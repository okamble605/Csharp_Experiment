using System;
using System.IO;

namespace ConsoleApp12
{
    internal class Program
    {
       static void Main(string[] args)
        {
            string fname;                 //Declaring a string variable
            string mname;                 //Declaring a string variable
            string lname;                 //Declaring a string variable
            Console.WriteLine("Enter your first name");
            fname = Console.ReadLine();
            Console.WriteLine("Enter your middle name");
            mname = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            lname = Console.ReadLine();
            string completename = fname + "\t" + mname + "\t" + lname; //Concatenating the string values
            Console.WriteLine("Your complete name is " + completename);
            Console.WriteLine("                                     ");
            Console.WriteLine("Your name in UPPERCASE is " + completename.ToUpper()); //Converting to UPPERCASE
            Console.WriteLine("                                     ");
            Console.WriteLine("Your name in LOWERCASE is " + completename.ToLower()); //Converting to UPPERCASE
            Console.WriteLine("           ");
            Console.WriteLine("Enter the new first name with which you want to replace your previous first name");
            string newname = Console.ReadLine();
            Console.WriteLine("Your First name contains " + fname.Length + " Characters");

            Console.WriteLine("Your new name is " + completename.Replace(fname, newname)); //Replacing string           



            string str1 = "6566.45";
            string str2 = "098.120";
            Single sngl1 = Convert.ToSingle(str1);
            Single sngl2 = Convert.ToSingle(str2);
            Console.WriteLine("Single 1 = {0}", sngl1);
            Console.WriteLine("Single 2 = {0}", sngl2);
           
            double x = Convert.ToDouble(str1);
            double y = Convert.ToDouble(str2);

            Console.WriteLine("Double 1 = {0}", x);
            Console.WriteLine("Double 2 = {0}", y);
        }
    }
}
