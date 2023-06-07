// https://www.codewars.com/kata/596e91b48c92ceff0c00001f/

using System.Collections.Generic;

public class Kata
{
  public static string[] WordsToHex(string words)
  {
    var result = new List<string>();
    
    foreach (string str in words.Split(' '))
    {
      string newStr = "#";
      
      for (int i = 0; i < 3 && i < str.Length; i++)
      {
        newStr += ((int) str[i]).ToString("X");
      }

      for (int i = 0; i < 3 - str.Length; i++)
        newStr += "00";
      
      result.Add(newStr.ToLower());
    }
    
    return result.ToArray();
  }
}