from collections import deque

def dfs(grid: list, row: int, col: int, visited: set)->None:
    if (row<0 or row>=len(grid)): return
    if (col<0 or col>=len(grid[0])): return
    if (row,col) in visited: return

    visited.add((row,col))
    visualise = [[0 for _ in range(len(grid[0]))] for _ in range(len(grid))]
    visualise[row][col]='#'
    print(visualise, '\n')

    dfs(grid, row, col-1, visited)
    dfs(grid, row, col+1, visited)
    dfs(grid, row+1, col, visited)
    dfs(grid, row+1, col, visited)

def main(grid: list)-> None:
    visited=set()
    for i in range(len(grid)):
        for j in range(len(grid[0])):
            dfs(grid, i, j, visited)

grid = [
  [1, 2, 2, 3],
  [3, 2, 3, 4],
  [2, 4, 5, 3],
  [6, 7, 1, 4]
]

# main(grid)

def bfs(grid: list, visited: set, queue: deque)->None:
    while queue:
        row,col = queue.popleft()
        # visited.add((row,col))

        visualise = [[0 for _ in range(len(grid[0]))] for _ in range(len(grid))]
        visualise[row][col]='#'
        for r in visualise:
            print(r)
        print()

        directions=[(0,-1), (0,1), (-1,0), (1,0)]
        for dr, dc in directions:
            r, c = row+dr, col+dc
            if (r<0 or r>=len(grid)): continue
            if (c<0 or c>=len(grid[0])): continue
            if ((r,c) in visited): continue

            queue.append((r,c))
            visited.add((r,c))
        

def mainBFS(grid):
    visited = set()
    queue = deque()
    visited.add((0,0))
    queue.append((0,0))
    bfs(grid, visited, queue)

mainBFS(grid)