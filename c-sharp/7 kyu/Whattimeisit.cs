// https://www.codewars.com/kata/57729a09914da60e17000329/

using System;
using System.Text.RegularExpressions;

public class TimeService
{
  public string GetMilitaryTimeFromStandardTime(string time)
  {
    string onlyTime = time.Substring(0, 8);
    string format = time.Substring(time.Length - 2, 2);
    
    string[] timeSeparated = onlyTime.Split(':');
    
    if (timeSeparated[0] == "12")
      timeSeparated[0] = "00";
    
    if (format == "PM")
    {
      int hours = Convert.ToInt32(timeSeparated[0]);
      hours += 12;
      timeSeparated[0] = hours.ToString();
    }
    
    return $"{timeSeparated[0]}:{timeSeparated[1]}:{timeSeparated[2]}";
  }
}