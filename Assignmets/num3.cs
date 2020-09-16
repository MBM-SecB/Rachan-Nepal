//Creates a function that takes a two word string separated by space and returns the concatenated first characters of both the words.
// E.g. GetInitials("Bishnu Rawal") => "BR" GetInitials("Alex Wales") => "AW"
using System;
class FirstUpper
{
       public static void Main()
    {
        Console.Write("!!Please Seperate First and last Name by space!! Enter your full Name : ");
        string name = Console.ReadLine();
        Console.WriteLine(name);
        FirstUpper answer=new FirstUpper();
        string res=answer.GetInitials(name);
        Console.WriteLine($"The initials are: {res}");
    }
    internal string GetInitials(string name)
    {
        string initials = "";
        initials += name[0];
        for (int i = 0; i < name.Length - 1; i++)
        {
            if (name[i] == ' ')
            {
                initials += name[i + 1];
            }
        }
        return initials.ToUpper();
    }
}