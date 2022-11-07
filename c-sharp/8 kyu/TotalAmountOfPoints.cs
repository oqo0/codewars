// https://www.codewars.com/kata/5bb904724c47249b10000131/

using System.Linq;
using System;

public static class Kata
{
    public static int TotalPoints(string[] games)
    {
        int res = 0;

        foreach (string game in games)
        {
          if (game[0] > game[2])
            res += 3;
          else if (game[0] == game[2])
            res += 1;
        }
        return res;
    }
}