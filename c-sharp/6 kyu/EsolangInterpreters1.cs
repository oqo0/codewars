// https://www.codewars.com/kata/586dd26a69b6fd46dd0000c0/

using System;

public class Kata
{
  private static int _memoryCell = 0;
  
  private static int MemoryCell
  {
    get => _memoryCell;
    set
    {
      if (value >= 256)
        _memoryCell = 0;
      else
        _memoryCell = value;
    }
  }
  
  public static string MyFirstInterpreter(string code)
  {
    MemoryCell = 0;
    string result = String.Empty;
    
    foreach (char c in code)
    {
      switch (c)
      {
        case '+':
          MemoryCell++;
          break;
        case '.':
          result += (char) (MemoryCell);
          break;
      }
    }
    
    return result;
  }
}