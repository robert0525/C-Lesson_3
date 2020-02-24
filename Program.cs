using System;

class Program
{

    static void MyMethod() 
    {
        int total = 0;
        Console.WriteLine("total in MyMethod:");
        Console.WriteLine(total);
    }
    static void Main(string[] args)
    {
        int total = 5;
        total += 10;
        MyMethod();
        Console.WriteLine("total in Main:");
        Console.WriteLine(total);

    }
}
