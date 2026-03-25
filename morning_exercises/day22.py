def dfs(grid: list, row: int, col: int)->None:
    if (row<0 or row>=len(grid)): return
    if (col<0 or col>=len(grid[0])): return
    if (grid[row][col]==0): return

    grid[row][col]=0
    dfs(grid, row, col-1)
    dfs(grid, row, col+1)
    dfs(grid, row-1, col)
    dfs(grid, row+1, col)

def islandCount(grid: list)->int:
    if (len(grid)==0 or len(grid[0])==0): return 0

    count = 0

    for i in range(0, len(grid)):
        for j in range(0, len(grid[0])):
            if grid[i][j]==1:
                count+=1
                dfs(grid, i, j)

    return count

grid =  [
            [1,0,1,0],
            [1,0,1,0],
            [1,1,0,1]
        ]

print(islandCount(grid))