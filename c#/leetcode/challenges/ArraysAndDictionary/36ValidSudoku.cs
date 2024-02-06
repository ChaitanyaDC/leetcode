namespace leetcode.challenges.ArraysAndDictionary._36ValidSudoku;

public class Solution {
    public bool IsValidSudoku(char[][] board) {
        Dictionary<int, List<char>> row = new Dictionary<int, List<char>>();
        Dictionary<int, List<char>> col = new Dictionary<int, List<char>>();
        Dictionary<(int, int), List<char>> sq = new Dictionary<(int, int), List<char>>();

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (board[i][j] == '.')
                    continue;

                if (row.ContainsKey(i) && row[i].Contains(board[i][j]) ||
                    col.ContainsKey(j) && col[j].Contains(board[i][j]) ||
                    sq.ContainsKey((i / 3, j / 3)) && sq[(i / 3, j / 3)].Contains(board[i][j]))
                {
                    return false;
                }

                if (!row.ContainsKey(i))
                    row[i] = new List<char>();
                if (!col.ContainsKey(j))
                    col[j] = new List<char>();
                if (!sq.ContainsKey((i / 3, j / 3)))
                    sq[(i / 3, j / 3)] = new List<char>();

                row[i].Add(board[i][j]);
                col[j].Add(board[i][j]);
                sq[(i / 3, j / 3)].Add(board[i][j]);
            }
        }

        return true; 
    }
}

class _36ValidSudoku {

    
    public static void Test() {
        // char[][] board = new char[][]
        // {
        //     new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
        //     new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
        //     new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
        //     new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
        //     new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
        //     new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
        //     new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
        //     new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
        //     new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
        // };

        // char[][] board = new char[][]
        // {
        //     new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
        //     new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
        //     new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
        //     new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
        //     new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
        //     new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
        //     new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
        //     new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
        //     new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
        // };

        char[][] board = new char[][]
        {
            new char[] { '8', '3', '.', '.', '7', '.', '.', '.', '.' },
            new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
            new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
            new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
            new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
            new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
            new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
            new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
            new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
        };

        Solution sol = new();
        bool res = sol.IsValidSudoku(board);
        Console.WriteLine("Is the Sudoku board valid? " + res);    
    }
}