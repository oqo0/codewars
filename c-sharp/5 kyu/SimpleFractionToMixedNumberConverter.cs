// https://www.codewars.com/kata/556b85b433fb5e899200003f/

using System;
using System.Text;

public class Kata
{
    public static string MixedFraction(string s)
    {
        var splitted = s.Split('/');
    
        int x = Int32.Parse(splitted[0]);
        int y = Int32.Parse(splitted[1]);
        int numerator = 0;
        int sign = 1;
    
        if (y == 0)
            throw new DivideByZeroException();
        if (x < 0)
        {
            sign *= -1;
            x *= -1;
        }
        if (y < 0)
        {
            sign *= -1;
            y *= -1;
        }
    
        while (x >= y)
        {
            x -= y;
            numerator += 1;
        }
    
        int commonDivider = GetCommonDivider(x, y);
    
        x /= commonDivider;
        y /= commonDivider;
    
        var result = new StringBuilder();
    
        if (x == 0 && numerator == 0)
            return "0";
        if (sign < 0)
            result.Append('-');
        if (numerator != 0)
            result.Append(numerator);
        if (numerator != 0 && x != 0)
            result.Append(' ');
        if (x != 0)
            result.Append($"{x}/{y}");
    
        return result.ToString();
    }
  
    private static int GetCommonDivider(int x, int y)
    {
        while (x != 0 && y != 0)
        {
            if (x > y)
                x = x % y;
            else
                y = y % x;
        }
    
        return x + y;
    }
}