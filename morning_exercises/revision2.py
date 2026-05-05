def countIslandsHelper(grid: list, row: int, col: int)->bool:
    if (row<0 or row>=len(grid)): return False
    if (col<0 or col>=len(grid[0])): return False
    if grid[row][col]=='0': return False

    grid[row][col]='0'
    # count[0]+=1
    return (countIslandsHelper(grid, row, col-1) or 
            countIslandsHelper(grid, row, col+1) or 
            countIslandsHelper(grid, row-1, col) or
            countIslandsHelper(grid, row+1, col))

def countIslands(grid: list)->int:
    if grid is None: return 0

    count = 0

    for i in range(0, len(grid)):
        for j in range(0, len(grid[0])):
            if grid[i][j]=='1':
                countIslandsHelper(grid, i, j)
                count+=1
    return count
