// https://www.codewars.com/kata/5279f6fe5ab7f447890006a7/

using System.Collections.Generic;

public class PickPeaks
{
  public static Dictionary<string, List<int>> GetPeaks(int[] arr)
  {
    var pos = new List<int>();
    var peaks = new List<int>();
    
    bool growth = false;
    int plateauStart = -1;
    for (int i = 0; i < arr.Length - 1; i++)
    {
      if (arr[i] < arr[i + 1])
      {
        growth = true;
        plateauStart = -1;
      }
      else if (arr[i] > arr[i + 1])
      {
        if (growth)
        {
          int index = i;
          
          if (plateauStart != -1)
            index = plateauStart;
          
          pos.Add(index);
          peaks.Add(arr[index]);
          
          growth = false;
        }
        
        plateauStart = -1;
      }
      else if (plateauStart == -1)
        plateauStart = i;
    }
    
    return new Dictionary<string, List<int>>() { { "pos", pos }, { "peaks", peaks } };
  }
}