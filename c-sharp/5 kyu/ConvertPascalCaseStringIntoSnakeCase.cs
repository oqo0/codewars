// https://www.codewars.com/kata/529b418d533b76924600085d/

using System;
using System.Text;

public static class Kata 
{
    public static string ToUnderscore(int n) 
        => ToUnderscore(n.ToString());

    public static string ToUnderscore(string str) 
    {
        var sb = new StringBuilder();
    
        for (int i = 0; i < str.Length; i++)
        {
            char currentChar = str[i];
            char currentCharLower = Char.ToLower(currentChar);
      
            if (currentChar != currentCharLower)
            {
                if (i != 0)
                    sb.Append('_');
        
                sb.Append(currentCharLower);
        
                continue;
            }
      
            sb.Append(currentChar);
            continue;
        }
    
        return sb.ToString();
    }
}