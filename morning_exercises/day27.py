from collections import deque

def flowsToPacific(grid, row, col, minHeight, map: list, visited: dict):
    if (row<0 or row>=len(grid)): return False
    if (col<0 or col>=len(grid[0])): return False
    if grid[row][col]<minHeight: return False
    if visited.get((row,col), 0)==1: return False

    minHeight=grid[row][col]
    # grid[row][col]=float('-inf')
    visited[row, col]=1

    # vis = [[0 for _ in range(len(grid[0]))] for _ in range(len(grid))]
    # vis[row][col]='#'
    # for r in vis:
    #     print(r)
    # print()

    map.append((row, col))
    return (flowsToPacific(grid, row, col-1, minHeight, map, visited) or
            flowsToPacific(grid, row, col+1, minHeight, map, visited) or
            flowsToPacific(grid, row-1, col, minHeight, map, visited) or
            flowsToPacific(grid, row+1, col, minHeight, map, visited))

def flowsToAtlantic(grid, row, col, minHeight, map: list, visited: dict, coords: list):
    if (row<0 or row>=len(grid)): return False
    if (col<0 or col>=len(grid[0])): return False
    if grid[row][col]<minHeight: return False
    if visited.get((row,col), 0)==1: return False

    minHeight=grid[row][col]
    visited[row, col]=1
    # grid[row][col]=float('-inf')
    # map.append([row, col])
    if ((row, col) in map): coords.append([row,col])
    return (flowsToAtlantic(grid, row, col-1, minHeight, map, visited, coords) or
            flowsToAtlantic(grid, row, col+1, minHeight, map, visited, coords) or
            flowsToAtlantic(grid, row-1, col, minHeight, map, visited, coords) or
            flowsToAtlantic(grid, row+1, col, minHeight, map, visited, coords))

def main_og(grid):
    map = []
    coords = []
    visited_Pacific={}
    visited_Atlantic={}
    for i in range(len(grid)):
        if not (flowsToPacific(grid, 0, i, float('-inf'), map, visited_Pacific) or flowsToPacific(grid, i, 0, float('-inf'), map, visited_Pacific)): continue
    for j in range(len(grid)):
        if not (flowsToAtlantic(grid, len(grid)-1, j, float('-inf'), map, visited_Atlantic, coords) or flowsToAtlantic(grid, j, len(grid)-1, float('-inf'), map, visited_Atlantic, coords)): continue

    return coords

grid = [
  [1, 2, 2, 3, 5],
  [3, 2, 3, 4, 4],
  [2, 4, 5, 3, 1],
  [6, 7, 1, 4, 5],
  [5, 1, 1, 2, 4]
]

# grid = [
#   [1, 2, 2, 3],
#   [3, 2, 3, 4],
#   [2, 4, 5, 3],
#   [6, 7, 1, 4]
# ]

# print(main_og(grid))

# Optimise this tomorrow

def dfs(grid: list, row: int, col: int,prevHeight: int, visited: set)->None:
    if (row<0 or row>=len(grid)): return
    if (col<0 or col>=len(grid[0])): return
    if (row, col) in visited: return
    if grid[row][col]<prevHeight: return

    visited.add((row, col))

    # vis = [[0 for _ in range(len(grid[0]))] for _ in range(len(grid))]
    # vis[row][col]='#'
    # for r in vis:
    #     print(r)
    # print()

    dfs(grid, row, col-1, grid[row][col], visited)
    dfs(grid, row, col+1, grid[row][col], visited)
    dfs(grid, row-1, col, grid[row][col], visited)
    dfs(grid, row+1, col, grid[row][col], visited)

def main(grid: list):
    pacific = set()
    atlantic = set()
    for i in range(len(grid)):
        dfs(grid, 0, i, float('-inf'), pacific)
        dfs(grid, len(grid)-1, i, float('-inf'), atlantic)
    for j in range(len(grid[0])):
        dfs(grid, j, 0, float('-inf'), pacific)
        dfs(grid, j, len(grid)-1, float('-inf'), atlantic)

    return [[r,c] for (r,c) in pacific if (r,c) in atlantic]

# print(main(grid))

def bfs(grid, queueBFS: deque, visited: set):
    while queueBFS:
        row,col = queueBFS.popleft()
        for dr, dc in [(0,-1), (0,1), (-1,0), (1,0)]:
            r, c = row+dr, col+dc

            if (r<0 or r>=len(grid)): continue
            if (c<0 or c>=len(grid[0])): continue
            if ((r,c) in visited): continue
            if (grid[r][c]<grid[row][col]): continue

            visited.add((r,c))
            queueBFS.append((r,c))

def mainBFS(grid: list):
    pacific = set()
    atlantic = set()

    pacQueueBFS = deque()
    atlQueueBFS = deque()
    
    for i in range(len(grid)):
        pacQueueBFS.append((0,i))
        pacific.add((0,i))
        atlQueueBFS.append((len(grid)-1, i))
        atlantic.add((len(grid)-1, i))

    for j in range(len(grid[0])):
        pacQueueBFS.append((j,0))
        pacific.add((j, 0))
        atlQueueBFS.append((j, len(grid)-1))
        atlantic.add((j, len(grid)-1))

    bfs(grid, pacQueueBFS, pacific)
    bfs(grid, atlQueueBFS, atlantic)

    return [[r,c] for (r,c) in pacific if (r,c) in atlantic]

print(mainBFS(grid))
