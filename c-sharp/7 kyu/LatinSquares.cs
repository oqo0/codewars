// https://www.codewars.com/kata/645fb55ecf8c290031b779ef

public class LatinSquare
{
  public static int[][] MakeLatinSquare(int n)
  {
    int[][] latinSquare = new int[n][];
    
    for (int i = 0; i < n; i++)
    {
      latinSquare[i] = new int[n];

      for (int j = 0; j < n; j++)
      {
        latinSquare[i][j] = (i + 1) + j;
        
        if (latinSquare[i][j] > n)
            latinSquare[i][j] -= n;
      }
    }

    return latinSquare;
  }
}