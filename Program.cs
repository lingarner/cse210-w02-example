using System;
using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {

        // this list can only hold strings
        List<string> names = new List<string>();

        // adding strings to the list
        names.Add("Bob");
        names.Add("Bill");
        names.Add("Sue");

        // easy way to print a list using ForEach
        names.ForEach(name => Console.Write(name + " "));

        // this is the preferred way if you already know what is going
        // into the list 
        string aString = "a";
        List<string> stuff = new List<string>{aString, "b", "c", "d"};


        // Using char when you use 'single quotes'
        char aSingleCharacter = 'a';
        Console.WriteLine($"This is a single character: {aSingleCharacter}");

        int x = 5;
        int y = 7;
        int result = Adder(x, y); //12
        Console.Write($"{x} + {y} = {result}");

    }

    // Creating Functions
    static int Adder(int a, int b)
    {
        return a + b;
    }




}