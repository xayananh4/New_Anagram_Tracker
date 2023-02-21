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
      if (_targetWord.Sort() == suggestedWords.Sort())
      {
        return true;
      }
      else
        return false;

    }







  }
}