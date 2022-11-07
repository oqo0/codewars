// https://www.codewars.com/kata/515e188a311df01cba000003/

public class Kata
{
  public static string GetPlanetName(int id)
  {
    switch (id)
    {
      case 1:
        return "Mercury";
      case 2:
        return "Venus";
      case 3:
        return "Earth";
      case 4:
        return "Mars";
      case 5:
        return "Jupiter";
      case 6:
        return "Saturn";
      case 7:
        return "Uranus";
      case 8:
        return "Neptune";
    }
    
    return string.Empty;
  }
}