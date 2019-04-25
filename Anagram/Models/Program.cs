using System;
using System.Collections.Generic;

namespace Anagram.Models
{
  public class Program
  {

     public static void Main()
     {
        Console.WriteLine("Enter a word: ");
        string checkAgainst = Console.ReadLine();

        bool addMore = true;
        while(addMore == true){
          Console.WriteLine("Enter another word to see if it is an anagram of " + checkAgainst + ":");
          Word toCheck = new Word(Console.ReadLine());
          Console.WriteLine("Add more words? (Y/N)");
          string userInput = Console.ReadLine().ToUpper();
          if(userInput == "N")
          {
            addMore = false;
          }
        }

      foreach (Word word in Word.GetAll())
       {
         if(Word.IsAnagram(word.GetWord(),checkAgainst) == true){
           Console.WriteLine(word.GetWord() + " is an anagram of " + checkAgainst);
          }else{
           Console.WriteLine(word.GetWord() + " is not an anagram of " + checkAgainst);
          }
        }
     }
  }
}
