class CheckWord
{
    public static bool Dfs(List<List<char>> grid, string word, int row, int col, int index)
    {
        if (row<0 || row>=grid.Count) return false;
        if (col<0 || col>=grid[0].Count) return false;
        if (index == word.Length) return true;
        if (grid[row][col]=='#') return false;
        if (grid[row][col]!=word[index]) return false;

        char original = grid[row][col];
        grid[row][col] = '#';
        bool result = Dfs(grid, word, row, col-1, index+1) ||
                      Dfs(grid, word, row, col+1, index+1) ||
                      Dfs(grid, word, row-1, col, index+1) ||
                      Dfs(grid, word, row+1, col, index+1);

        grid[row][col] = original;

        return result;
    }

    public static bool WordSearch(List<List<char>> grid, string word)
    {
        if (word.Length==0 || grid.Count==0 || grid[0].Count==0) return false;

        for (int i = 0; i < grid.Count; i++)
        {
            for (int j = 0; j < grid[0].Count; j++)
            {
                if (Dfs(grid, word, i, j, 0)) return true;
            }
        }
        return false;
    }
}