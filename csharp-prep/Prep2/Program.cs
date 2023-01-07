using System;

class Program
{
  static void Main(string[] args)
  {
    // Console.WriteLine("Hello Prep2 World!");
    Console.Write("Enter a number for a grade: ");
    string gradeValue = Console.ReadLine();

    int x = int.Parse(gradeValue);
    // int a = 90;
    // int b = 80;
    // int c = 70;
    if (x >= 90)
    {
      Console.WriteLine("you have an A");
    }
    else if (x >= 80 && x < 90)
    {
      Console.WriteLine("you have an B");
    }
    else if (x >= 70 && x < 80)
    {
      Console.WriteLine("you have an C");
    }
    else if (x >= 60 && x < 70)
    {
      Console.WriteLine("you have an D");
    }
    else if (x <= 60)
    {
      Console.WriteLine("you have an F");
    }

  }
}