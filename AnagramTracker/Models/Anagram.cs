using System;

namespace AnagramTracker.Models
{
  public class Anagram
  {
    private string _targetWord;

    public Anagram(string targetWord)
    {
      _targetWord = targetWord;
    }
    public string GetTargetWord()
    {
      return _targetWord;
    }
    // public string SetTargetWord(string targetWord)
    // {
    //   _targetWord = targetWord;
    // }
    public bool CheckAnagram(string suggestedWords)
    {
      char[] charFromTarget = _targetWord.ToCharArray();
      Array.Sort(charFromTarget);
      char[] charFromSuggested = suggestedWords.ToCharArray();
      Array.Sort(charFromSuggested);
      Console.WriteLine(charFromTarget);
      Console.WriteLine(charFromSuggested);

      if (charFromTarget.ToString() == charFromSuggested.ToString())
      {
        return true;
      }
      else
        return false;

    }







  }
}
