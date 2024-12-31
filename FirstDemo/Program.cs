// See https://aka.ms/new-console-template for more information
using FirstDemo;
using System;
using System.Text.RegularExpressions;
internal class Program: Ints
{
    private static void Main(string[] args)
    {
        Ints ints = new Ints();
        ints.num1 = 3;
        ints.num2 = 4;
        int sum = ints.num1 + ints.num2;
        Console.WriteLine($"Sum of {ints.num1} and {ints.num2} is {sum}");
    }
}

public class Ints
{
    public int num1;
    public int num2;
}