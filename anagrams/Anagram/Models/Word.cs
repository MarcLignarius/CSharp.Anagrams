using System;
using System.Collections.Generic;

namespace Anagram.Models
{
  public class Word
  {
    private string _word;
    private static List<Word> _instances = new List<Word> {};

    public Word (string word)
    {
      _word = word;
      _instances.Add(this);
    }

    public string GetWord()
    {
      return _word;
    }


    public static List<Word> GetAll()
    {
     return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static bool IsAnagram(string word, string check)
    {
      char[] wordArray = word.ToCharArray();
      char[] checkArray = check.ToCharArray();

      for(int i = 0;i<wordArray.Length;i++)
      {
        if(Array.IndexOf(checkArray, wordArray[i])>=0)
        {
          checkArray[Array.IndexOf(checkArray,wordArray[i])] = '0';
        }else{
          return false;
        }
      }
      return true;
    }
  }
}
