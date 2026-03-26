function dfsArea(grid: number[][], maxArea: number, row: number, col: number): number {
    if (row<0 || row>=grid.length) return 0;
    if (col<0 || col>=grid[0].length) return 0;
    if (grid[row][col]===0) return 0;

    grid[row][col]=0;
    return 1 + dfsArea(grid, maxArea, row, col-1) + dfsArea(grid, maxArea, row, col+1) + dfsArea(grid, maxArea, row-1, col) + dfsArea(grid, maxArea, row+1, col);
}

function maxislandArea(grid: number[][]): number {
    if (grid.length === 0 || grid[0].length === 0) return 0;

    let maxArea = 0;

    for (let i = 0; i < grid.length; i++) {
        for (let j = 0; j < grid[0].length; j++) {
            if (grid[i][j]===1) {
                maxArea = Math.max(maxArea, dfsArea(grid, maxArea, i, j));
            }
        }
    }
    return maxArea;
}

{
    let grid =  [
                    [1,0,1,0],
                    [1,0,1,0],
                    [1,1,0,1]
                ];
    console.log(maxislandArea(grid));
}