using System;

namespace SweetnSalty
{
  class Program
  {
    static void Main(string[] args)
    {
      //initialize sweet variable for multiples of 3 only
      int sweet = 0;
      //initialize salty variable for multiples of 5 only
      int salty = 0;
      //initialize sweetNSalty variable for multiples of 3 and 5
      int sweetnSalty = 0;
      //Go through all numbers from 1 - 1000
      for (int i = 1; i <= 1000; i++)
      {
        //Print sweet’nSalty and increment the value if the number is a multiple of 3 and 5.
        if (i % 3 == 0 && i % 5 == 0)
        {
          Console.Write("sweet’nSalty ");
          sweetnSalty++;
        }
        //Print salty and increment the value if the number is a multiple of 5.
        else if (i % 5 == 0)
        {
          Console.Write("salty ");
          salty++;
        }
        //Print sweet and increment the value if the number is a multiple of 3.
        else if (i % 3 == 0)
        {
          Console.Write("sweet ");
          sweet++;
        }
        //Print the number if it is not a multiple of 3 or 5.
        else
          Console.Write(i + " ");
        //After 10 values are printed, write a new line.
        if (i % 10 == 0)
          Console.WriteLine();
      }
      //Prints out how many sweets, saltys, and sweet’nSaltys have been printed out
      Console.WriteLine($"There are {sweet} sweets.");
      Console.WriteLine($"There are {salty} saltys.");
      Console.WriteLine($"There are {sweetnSalty} sweet’nSaltys.");
    }
  }
}
