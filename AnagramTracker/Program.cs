using System;
using AnagramTracker.Models;

namespace AnagramTracker
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to the Anagram app!");
      Console.WriteLine("Please enter in a word:");
      string targetWord = Console.ReadLine();
      Anagram ana = new Anagram(targetWord);
      suggestedPromp();


      void suggestedPromp()
      {
        Console.WriteLine("Please enter in a suggested word:");
        string suggestedWord = Console.ReadLine();
        Console.WriteLine(suggestedWord);
        bool result = ana.CheckAnagram(suggestedWord);

        if (result == true)
        {
          Console.WriteLine("Your suggested word is an anagram!");

        }
        else
        {
          Console.WriteLine("Sorry your suggested word is NOT anagram!");
        }
        Console.WriteLine("Do you want to add another suggested word? Enter 'yes' to proceed, or 'no' to end the greatest app ever created");
        string userInput = Console.ReadLine();
        if (userInput == "yes")
        {
          suggestedPromp();

        }
        else
        {
          Console.WriteLine("Your loss buddy! Peace out");

        }
      }

    }
  }
}
