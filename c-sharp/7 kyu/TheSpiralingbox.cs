// https://www.codewars.com/kata/63b84f54693cb10065687ae5/

public class SpiralingBox
{
  public static int[,] CreateBox(int width, int length)
  {
    int[,] res = new int[length, width];
    
    for (int i = 0; length / 2 >= i && width / 2 >= i; i++)
      FillArray(ref res, i + 1, i, length - i - 1, width - i - 1);
    
    return res;
  }
  
  private static void FillArray(ref int[,] array, int num, int x1, int x2, int y2)
  {
    for (int x = 0; x < array.GetLength(0); x++)
    {
      for (int y = 0; y < array.GetLength(1); y++)
      {
        if (x >= x1 && x <= x2 && y <= y2)
          array[x, y] = num;
      }
    }
  }
}