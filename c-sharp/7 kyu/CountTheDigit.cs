// https://www.codewars.com/kata/566fc12495810954b1000030/

using System;
using System.Linq;

public class CountDig 
{
  public static int NbDig(int n, int d) 
  {
    return String.Concat(Enumerable.Range(0, n + 1).Select(x => x * x)).Count(x => x == (char)(d + 48));
  }
}