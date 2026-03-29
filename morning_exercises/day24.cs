class RottenOranges
{
    public static int BfsRottenOranges(List<List<int>> grid)
    {
        int fresh = 0;
        LinkedList<List<int>> rotten = [];
        for (int i = 0; i<grid.Count; i++)
        {
            for (int j = 0; j<grid[0].Count; j++)
            {
                if (grid[i][j]==1) fresh++;
                if (grid[i][j]==2) rotten.AddLast([i,j]);
            }
        }

        List<(int, int)> directions = [(-1,0), (1,0), (0,-1), (0, 1)];
        int minutes = 0;
        while (rotten.Count>0 && fresh>0)
        {
            int rottenCount = rotten.Count;
            for (int i=0; i<rottenCount; i++)
            {
                var coords = rotten.First();
                // rotten.RemoveFirst();
                foreach (var (r,c) in directions)
                {
                    if (r+coords[0]>=0 && r+coords[0]<grid.Count && c+coords[1]>=0 && c+coords[1]<grid[0].Count)
                    {
                        if (grid[r + coords[0]][c + coords[1]] == 1)
                        {
                            grid[r + coords[0]][c + coords[1]] = 2;
                            rotten.AddLast([r + coords[0],c + coords[1]]);
                            --fresh;
                        }
                    }
                }
                rotten.RemoveFirst();
            }
            foreach(var a in grid)
            {
                foreach (var b in a)
                {
                    Console.Write(b+" ");
                }
            }
            minutes++;
        }
        return fresh==0 ? minutes : -1;
    }
}