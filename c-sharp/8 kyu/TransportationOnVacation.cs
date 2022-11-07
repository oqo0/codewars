// https://www.codewars.com/kata/568d0dd208ee69389d000016/

public class RentalCar
{
  public static int RentalCarCost(int d)
  {
    int off = 0;

    if (d >= 3)
      off = 20;
    if (d >= 7)
      off = 50;

    return d * 40 - off;
  }
}