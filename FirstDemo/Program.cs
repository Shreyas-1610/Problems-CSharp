// See https://aka.ms/new-console-template for more information
using FirstDemo;
using System;
using System.Text.RegularExpressions;
internal class Program: Ints
{
    private static void Main(string[] args)
    {
        //Program ints = new Program();
        //ints.num1 = 3;
        //ints.num2 = 4;
        //int sum = ints.num1 + ints.num2;
        //Console.WriteLine($"Sum of {ints.num1} and {ints.num2} is {sum}");

        //string str = "Shreyas is going Hyderabad";
        //string ans = Reverse.Words(str);
        //Console.WriteLine(ans);

        //int[] array = { 12,12,12,12,12};
        //int ans = Sum.ArraySum(array);
        //Console.WriteLine(ans);

        //int c = 30;
        //Temp.Converssion(c);

        // var watch = System.Diagnostics.Stopwatch.StartNew();
        //WithoutLoop.PrintNumber(1);
        //watch.Stop();
        //var elapsedMs = watch.ElapsedMilliseconds;
        //Console.WriteLine($"Elapsed time in milliseconds: {elapsedMs}");

        //int year = 2000;
        //int month = 10;
        //int date = 30;
        //IncDate.next(year, month, date);

        //int a = 1, b = 2;
        //Console.WriteLine($"Before swapping:a = {a},b = {b}");
        //GenericImpl.swap(ref a, ref b);
        //Console.WriteLine($"After swapping:a = {a},b = {b}");

        //GenericImplTwo<int> intBox = new GenericImplTwo<int>();
        //intBox.Add(1);
        //intBox.Add(2);
        //intBox.Add(3);
        //intBox.Display();
        //int[] arr = {12,33,44,1,50};
        //int[] ans = RemoveArray.ArrElement(arr,4);
        //foreach(int i in ans)
        //{
        //    Console.Write(i+" ");
        //}

        //RandomAvg.Average();

        //Height.GetCat(149);

        //Iterations.Print();

        //int[] arr = { 12,100,444,4420,120};
        //int ans = Smallest.Difference(arr);
        //Console.WriteLine(ans);

        //CreateF.readF();

        //Operations.FindOp();
        //Line.FindSingleLine();

        //Console.WriteLine("Enter hours: ");
        //int hour  = int.Parse(Console.ReadLine());
        //Hour.ConvertToS(hour);

        Console.WriteLine("Enter first number");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number");
        int n2 = int.Parse(Console.ReadLine());
        Calculate.N1N2(n1, n2);
    }
}

public class Ints
{
    public int num1;
    public int num2;
}