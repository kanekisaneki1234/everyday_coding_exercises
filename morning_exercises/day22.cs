class CountingIslands
{
    public static void Dfs(List<List<int>> grid, int row, int col)
    {
        if (row<0 || row>=grid.Count) return;
        if (col<0 || col>=grid[0].Count) return;
        if (grid[row][col]==0) return;

        grid[row][col]=0;
        Dfs(grid, row, col-1);
        Dfs(grid, row, col+1);
        Dfs(grid, row-1, col);
        Dfs(grid, row+1, col);
    }

    public static int IslandsCount(List<List<int>> grid)
    {
        if (grid.Count==0 || grid[0].Count==0) return 0;

        int count = 0;

        for (int i=0; i<grid.Count; i++)
        {
            for (int j=0; j<grid[0].Count; j++)
            {
                if (grid[i][j] == 1) 
                {
                    count++;
                    Dfs(grid, i, j);
                }
            }
        }
        return count;
    }
}