// https://www.codewars.com/kata/525caa5c1bf619d28c000335/

public class TicTacToe
{
  public int IsSolved(int[,] board)
  {
    for (int x = 0; x < 3; x++)
      if (IsWinner(board[x, 0], board[x, 1], board[x, 2]))
        return board[x, 0];
    
    for (int x = 0; x < 3; x++)
      if (IsWinner(board[0, x], board[1, x], board[2, x]))
        return board[0, x];
    
    if (IsWinner(board[0, 0], board[1, 1], board[2, 2]))
      return board[0, 0];
    
    if (IsWinner(board[2, 0], board[1, 1], board[0, 2]))
      return board[2, 0];
    
    if (!IsBoardFinished(board))
      return -1;
    
    return 0;
  }
  
  private static bool IsWinner(int v1, int v2, int v3)
    => v1 == v2 && v1 == v2 && v1 == v3 && v1 != 0;
  
  private static bool IsBoardFinished(int[,] board)
  {
    for (int x = 0; x < 3; x++)
      for (int y = 0; y < 3; y++)
        if (board[x, y] == 0)
          return false;
    
    return true;
  }
}