using System;
//Create a function that takes the number of wins, draws and losses, and calculates the number of points a football team has obtained so far.
// Rule - wins get 5 points, draws get 2 point and losses get 0 points
class Result
{
    public static void Main2()
    {
        Result answer=new Result();
        answer.Records();
    }
        internal void Records()
    {
        Result obj= new Result();
        Console.Write("Enter the number of wins: ");
        int wins = Int32.Parse(Console.ReadLine());
        Console.Write("Enter the number of draws: ");
        int draws = Int32.Parse(Console.ReadLine());
        Console.Write("Enter the number of loss: ");
        int loss = Int32.Parse(Console.ReadLine());
        int result = obj.CalculateTeamPoint(wins, draws, loss);
        Console.WriteLine($"Team earned {result} point in the session");
    }

    
    int CalculateTeamPoint(int wins, int draws, int loss)
    {
        int totalPoint = 0;
        for (int i=1; i<=wins; i++)
        {
            totalPoint += 5;
        }

        for (int i=1; i<=draws; i++)
        {
            totalPoint += 2;
        }
        return totalPoint;
    }
}