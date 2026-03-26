def dfsArea(grid: list, row: int, col: int)->int:
    if (row<0 or row>=len(grid)): return 0
    if (col<0 or col>=len(grid[0])): return 0
    if (grid[row][col]==0): return 0

    grid[row][col]=0
    return 1 + dfsArea(grid, row, col-1) + dfsArea(grid, row, col+1) + dfsArea(grid, row-1, col) + dfsArea(grid, row+1, col)

def maxIslandArea(grid: list)->int:
    if (len(grid)==0 or len(grid[0])==0): return 0

    maxArea = 0

    for i in range(len(grid)):
        for j in range (len(grid[0])):
            if (grid[i][j]==1):
                maxArea = max(maxArea, dfsArea(grid, i, j))

    return maxArea

grid =  [
            [1,1,1,0],
            [0,0,0,0],
            [1,1,0,1]
        ]

print(maxIslandArea(grid))