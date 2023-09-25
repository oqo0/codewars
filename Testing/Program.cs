using System;
using System.Collections.Generic;

public class Dinglemouse
{
    public static void Main()
    {
        // Expected: "O wins after 17 moves"
        // But was:  "No winner"
        var moves = new List<(int, int, int)>
        {
            (0, 0, 0),
            (0, 2, 0),
            (0, 3, 3),
            (0, 0, 2),
            (1, 0, 1),
            (1, 1, 3),
            (0, 3, 0),
            (0, 2, 3),
            (1, 2, 0),
            (1, 1, 2),
            (0, 3, 1),
            (0, 0, 1),
            (0, 1, 1),
            (1, 0, 2),
            (1, 0, 0),
            (0, 3, 2),
            (0, 2, 2),
            (0, 1, 2),
            (0, 1, 0),
            (0, 1, 3),
            (1, 1, 1),
            (0, 2, 1),
            (0, 0, 3),
            (1, 1, 0),
            (1, 0, 3)
        };
        Console.WriteLine(Dinglemouse.PlayOX3D(moves));
    }
    
    public static string PlayOX3D(List<(int, int, int)> moves)
    {
        bool turn = true;
        char[,,] field = new char[4, 4, 4];
        int movesCounter = 1;
    
        foreach (var m in moves)
        {
            field[m.Item1, m.Item2, m.Item3] = turn ? 'O' : 'X';
      
            if (CheckWinner(field))
            {
                char winner = turn ? 'O' : 'X';
                return $"{winner} wins after {movesCounter} moves";
            }
      
            turn = !turn;
            movesCounter++;
        }

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                for (int k = 0; k < 4; k++)
                    Console.Write(field[i, j, k]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        
        return "No winner";
    }
  
    private static bool CheckWinner(char[,,] field)
    {
        var rows = new List<(char, char, char, char)>();
    
        // diagonals
        rows.Add((field[0, 0, 0], field[1, 1, 1], field[2, 2, 2], field[3, 3, 3]));
        rows.Add((field[3, 0, 0], field[2, 1, 1], field[1, 2, 2], field[0, 3, 3]));
        rows.Add((field[3, 3, 0], field[2, 2, 1], field[1, 1, 2], field[0, 0, 3]));
        rows.Add((field[0, 3, 0], field[1, 2, 1], field[2, 1, 2], field[3, 0, 3]));
    
        
        
        // rows
        for (int i = 0; i < 4; i++)
        for (int j = 0; j < 4; j++)
            rows.Add((field[i, j, 0], field[i, j, 1], field[i, j, 2], field[i, j, 3]));
        for (int i = 0; i < 4; i++)
        for (int j = 0; j < 4; j++)
            rows.Add((field[0, i, j], field[1, i, j], field[2, i, j], field[3, i, j]));
        for (int i = 0; i < 4; i++)
        for (int j = 0; j < 4; j++)
            rows.Add((field[i, 0, j], field[i, 1, j], field[i, 2, j], field[i, 3, j]));
    
        foreach (var r in rows)
            if (r.Item1 != '\0' && r.Item1 == r.Item2 && r.Item1 == r.Item3 && r.Item1 == r.Item4)
                return true;
    
        return false;
    }
}