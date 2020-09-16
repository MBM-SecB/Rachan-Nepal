using System;
//Given two numbers, write C# method that returns true if sum of both numbers is greater than 500. Otherwise returns false.
class SumTwo
{
    public static void Main1()
    {
        SumTwo result=new SumTwo();
        result.Sums();
    }
     void Sums()
  {
    Console.Write("Enter first number: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Enter second number: ");
    int b = int.Parse(Console.ReadLine());
    bool ans = a + b > 500;
    Console.WriteLine($"Result: {ans}");
  }
}