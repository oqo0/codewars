// https://www.codewars.com/kata/56b8903933dbe5831e000c76/

using System.Text;

public static class ReadySet
{
  public static string Spoonerize(string str)
  {
    string[] splitted = str.Split(' ');
    
    var sb1 = new StringBuilder(splitted[0]);
    var sb2 = new StringBuilder(splitted[^1]);
    
    char sb2Char = sb2[0];
    sb2[0] = sb1[0];
    sb1[0] = sb2Char;

    return sb1.ToString() + " " + sb2.ToString();
  }
}