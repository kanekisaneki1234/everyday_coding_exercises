function dfs(grid: number[][], row: number, col: number): void {
    if (row<0 || row>=grid.length) return;
    if (col<0 || col>=grid[0].length) return;
    if (grid[row][col]==0) return;

    grid[row][col]=0;
    dfs(grid, row, col-1);
    dfs(grid, row, col+1);
    dfs(grid, row-1, col);
    dfs(grid, row+1, col);
}

function islandCount(grid: number[][]): number {
    if (grid.length==0 || grid[0].length==0) return 0;

    let count = 0;

    for (let i=0; i<grid.length; i++) {
        for (let j=0; j<grid[0].length; j++) {
            if (grid[i][j]==1) {
                count++;
                dfs(grid, i, j);
            }
        }
    }
    return count;
}

{
    let grid =  [
                    [1,0,1,0],
                    [0,0,1,0],
                    [1,1,0,1]
                ];
    console.log(islandCount(grid));
}