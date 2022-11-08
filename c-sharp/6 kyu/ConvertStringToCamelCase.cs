// https://www.codewars.com/kata/517abf86da9663f1d2000003/

using System;

public class Kata
{
  public static string ToCamelCase(string str)
  {
    char[] splitChars = new char[] { '-', '_' };
    
    string[] newStr = str.Split(splitChars);
    
    for (int i = 1; i < newStr.Length; i++)
    {
      newStr[i] = Char.ToUpper(newStr[i][0]) + newStr[i].Substring(1);
    }
    
    return String.Concat(newStr);
  }
}