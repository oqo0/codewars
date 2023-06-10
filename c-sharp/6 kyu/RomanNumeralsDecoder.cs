// https://www.codewars.com/kata/51b6249c4612257ac0000005/

using System.Collections.Generic;

public class RomanDecode
{
    private static readonly Dictionary<char, int> _values = new Dictionary<char, int>()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };
  
	public static int Solution(string roman)
	{
        int result = 0;
        int beforeValue = -1;
        
        for (int i = roman.Length - 1; i >= 0; i--)
        {
            char currentChar = roman[i];
            int currentValue = _values[currentChar];
            
            result += GetAbsoluteValue(currentValue, beforeValue);
            
            beforeValue = currentValue;
        }
    
		return result;
	}
  
  private static int GetAbsoluteValue(int current, int before)
  { 
    return (current < before) ? -current : current;
  }
}