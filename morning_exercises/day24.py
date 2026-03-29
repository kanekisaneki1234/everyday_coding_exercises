from collections import deque

def bfsRottenOranges(grid: list)->int:
    queue = deque()
    fresh = 0
    for row in range(len(grid)):
        for col in range(len(grid[0])):
            if grid[row][col]==2: queue.append((row, col))
            if grid[row][col]==1: fresh +=1

    minutes = 0
    while(queue and fresh>0):
        directions = [(0,-1), (0,1), (-1,0), (1,0)]
        for _ in range(len(queue)):
            coords = queue.popleft()
            for r, c in directions:
                if (coords[0]+r>=0 and coords[0]+r<len(grid)) and (coords[1]+c>=0 and coords[1]+c<len(grid[0])):
                    if (grid[coords[0]+r][coords[1]+c]==1): 
                        grid[coords[0]+r][coords[1]+c]=2
                        queue.append((coords[0]+r,coords[1]+c))
                        fresh-=1
        minutes+=1
    
        # print(grid)
    # print(grid)
    return minutes if fresh == 0 else -1

def minMinutesRootenOranges(grid: list)->int:
    minMinutes = bfsRottenOranges(grid)
    return minMinutes


print(minMinutesRootenOranges([[1, 0, 0], 
                               [2, 1, 0],
                               [2, 1, 1]]))