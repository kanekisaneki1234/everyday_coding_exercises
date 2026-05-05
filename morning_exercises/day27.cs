using System.Linq;

class FlowingWaters
{
    public static void Dfs(List<List<int>> grid, int row, int col, int prevHeight, HashSet<(int, int)> visited)
    {
        if (row<0 || row>=grid.Count) return;
        if (col<0 || col>=grid[0].Count) return;
        if (visited.Contains((row,col))) return;
        if (grid[row][col]<prevHeight) return;

        visited.Add((row,col));

        Dfs(grid, row, col-1, grid[row][col], visited);
        Dfs(grid, row, col+1, grid[row][col], visited);
        Dfs(grid, row-1, col, grid[row][col], visited);
        Dfs(grid, row+1, col, grid[row][col], visited);
    }

    public static List<(int, int)> MainDfs(List<List<int>> grid)
    {
        HashSet<(int, int)> pacific = [];
        HashSet<(int, int)> atlantic = [];

        for (int c=0; c<grid.Count; c++)
        {
            Dfs(grid, 0, c, grid[0][c], pacific);
            Dfs(grid, grid.Count-1, c, grid[^1][c], atlantic);
        }
        for (int r=0; r<grid[0].Count; r++)
        {
            Dfs(grid, r, 0, grid[r][0], pacific);
            Dfs(grid, r, grid[0].Count-1, grid[r][^1], atlantic);
        }

        // List<(int, int)> result = pacific.Intersect(atlantic).ToList();
        List<(int, int)> result = [.. pacific.Intersect(atlantic)];

        return result;
    }

    public static void Bfs(List<List<int>> grid, HashSet<(int, int)> visited, LinkedList<(int, int)> fakeQueue)
    {
        while (fakeQueue.Count > 0)
        {
            var (row, col) = fakeQueue.First(); fakeQueue.RemoveFirst();
            List<(int, int)> directions = [(0,-1), (0,1), (-1,0), (1,0)];
            foreach (var (dr,dc) in directions)
            {
                var r = row+dr; var c = col+dc;
                if (r<0 || r>=grid.Count) continue;
                if (c<0 || c>=grid[0].Count) continue;
                if (grid[r][c]<grid[row][col]) continue;
                if (visited.Contains((r,c))) continue;

                visited.Add((r,c));
                fakeQueue.AddLast((r,c));
            }
        }
    }

    public static List<(int, int)> MainBFS(List<List<int>> grid)
    {
        HashSet<(int, int)> pacificVisited = [];
        HashSet<(int, int)> atlanticVisited = [];

        LinkedList<(int, int)> queuePacific = [];
        LinkedList<(int, int)> queueAtlantic = [];

        for (int c=0; c<grid[0].Count; c++)
        {
            queuePacific.AddLast((0, c)); pacificVisited.Add((0, c));
            queueAtlantic.AddLast((grid.Count-1, c)); atlanticVisited.Add((grid.Count-1, c));
        }
        for (int r=0; r<grid.Count; r++)
        {
            queuePacific.AddLast((r, 0)); pacificVisited.Add((r, 0));
            queueAtlantic.AddLast((r, grid[0].Count-1)); atlanticVisited.Add((r, grid[0].Count-1));
        }
        Bfs(grid, pacificVisited, queuePacific);
        Bfs(grid, atlanticVisited, queueAtlantic);

        List<(int, int)> result = [..pacificVisited.Intersect(atlanticVisited)];

        return result;
    }
}