// https://www.codewars.com/kata/57f24e6a18e9fad8eb000296/

using System;

public class Kata
{
  public static string HowMuchILoveYou(int n)
  {
    string[] words = {
      "I love you", "a little", "a lot", "passionately", "madly", "not at all"
    };

    return n % 6 == 0 ? words[5] : words[(n % 6) - 1];
  }
}