// https://www.codewars.com/kata/5264d2b162488dc400000001/

using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static string SpinWords(string sent)
  {
    return String.Join(' ',
                       sent.Split(' ').Select(
                         x => x = x.Length >= 5 ?
                         new string(x.Reverse().ToArray()) :
                         x)
                       );
  }
}