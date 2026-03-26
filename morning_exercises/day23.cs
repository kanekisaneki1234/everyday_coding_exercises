class IslandMaxArea
{
    public static int DfsArea(List<List<int>> grid, int row, int col)
    {
        if (row<0 || row>=grid.Count) return 0;
        if (col<0 || col>=grid[0].Count) return 0;
        if (grid[row][col]==0) return 0;

        grid[row][col] = 0;
        return 1 + DfsArea(grid, row, col-1) + DfsArea(grid, row, col+1) + DfsArea(grid, row-1, col) + DfsArea(grid, row+1, col);
    }

    public static int MaxAreaIsland(List<List<int>> grid)
    {
        if (grid.Count==0 || grid[0].Count==0) return 0;

        int maxArea = 0;

        for (int i = 0; i<grid.Count; i++)
        {
            for (int j = 0; j<grid[0].Count; j++)
            {
                if (grid[i][j]==1) maxArea=Math.Max(maxArea, DfsArea(grid, i, j));
            }
        }
        return maxArea;
    }
}