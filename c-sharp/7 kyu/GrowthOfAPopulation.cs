// https://www.codewars.com/kata/563b662a59afc2b5120000c6/

class Arge 
{
  public static int NbYear(int p0, double percent, int aug, int p) 
  {
    return p0 >= p ? 0 : 1 + NbYear((int) (p0 + p0 * percent / 100 + aug), percent, aug, p);
  }
}