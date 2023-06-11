using System;

public static class StaticClass
{
    public static void PrintMessage()
    {
        Console.WriteLine("This is a static class.");
    }
}

public class NonStaticClass
{
    public void PrintMessage()
    {
        Console.WriteLine("This is a non-static class.");
    }
}

class Program
{
    static void Main(string[] args)
    {
         StaticClass.PrintMessage();

       NonStaticClass nonStaticObject = new NonStaticClass();

       nonStaticObject.PrintMessage();

        Console.ReadKey();
    }
}
