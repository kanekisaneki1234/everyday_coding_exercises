function dfs(grid: number[][], row: number, col: number, prevHeight: number, visited: boolean[][]): void {
    if (row<0 || row>=grid.length) return;
    if (col<0 || col>=grid[0].length) return;
    if (visited[row][col]) return;
    if (grid[row][col]<prevHeight) return;

    visited[row][col]=true;
    dfs(grid, row, col-1, grid[row][col], visited);
    dfs(grid, row, col+1, grid[row][col], visited);
    dfs(grid, row-1, col, grid[row][col], visited);
    dfs(grid, row+1, col, grid[row][col], visited);
}

function mainDFS(grid: number[][]): number[][] {
    let visitedPacific = Array.from({length: grid.length}, ()=>new Array(grid[0].length).fill(false));
    let visitedAtlantic = Array.from({length: grid.length}, ()=>new Array(grid[0].length).fill(false));

    for (let i = 0; i<grid.length; i++) {
        dfs(grid, 0, i, grid[0][i], visitedPacific);
        dfs(grid, grid.length-1, i, grid[grid.length-1][i], visitedAtlantic);
    }
    for (let j = 0; j<grid[0].length; j++) {
        dfs(grid, j, 0, grid[j][0], visitedPacific);
        dfs(grid, j, grid[0].length-1, grid[j][grid[0].length-1], visitedAtlantic);
    }

    const result: number[][] = [];
    for (let r=0; r<grid.length; r++) {
        for (let c=0; c<grid[0].length; c++) {
            if (visitedPacific[r][c] && visitedAtlantic[r][c]) {
                result.push([r,c]);
            }
        }
    }
    return result;
}

{
    let grid = [
    [1, 2, 2, 3, 5],
    [3, 2, 3, 4, 4],
    [2, 4, 5, 3, 1],
    [6, 7, 1, 4, 5],
    [5, 1, 1, 2, 4]
]

// console.log(mainDFS(grid));
}

function bfs(grid: number[][], fakeQueue: number[][], visited: boolean[][]): void {
    while (fakeQueue.length>0) {
        const [row, col] = fakeQueue.shift()!;
        const directions = [[0,-1], [0,1], [-1,0], [1,0]]

        for (let [dr, dc] of directions) {
            let r = row+dr;
            let c = col+dc;
            // console.log(r);

            if (r<0 || r>=grid.length) continue;
            if (c<0 || c>=grid[0].length) continue;
            if (visited[r][c]===true) continue;
            if (grid[r][c]<grid[row][col]) continue;

            visited[r][c]=true;
            fakeQueue.push([r,c]);
        }
    }
}

function mainBFS(grid: number[][]): number[][] {
    const queuePacific = []
    const queueAtlantic = []

    const visitedPacific = Array.from({length: grid.length}, ()=>new Array(grid[0].length).fill(false));
    const visitedAtlantic = Array.from({length: grid.length}, ()=>new Array(grid[0].length).fill(false));

    for (let i=0; i<grid.length; i++) {
        queuePacific.push([0, i]); 
        visitedPacific[0][i]=true;
        queueAtlantic.push([grid.length-1, i]);
        visitedAtlantic[grid.length-1][i]=true;
    }

    for (let j=0; j<grid[0].length; j++) {
        queuePacific.push([j, 0]); 
        visitedPacific[j][0]=true;
        queueAtlantic.push([j, grid.length-1]);
        visitedAtlantic[j][grid.length-1]=true;
    }

    bfs(grid, queuePacific, visitedPacific);
    bfs(grid, queueAtlantic, visitedAtlantic);

    const result: number[][] = [];
    for (let r=0; r<grid.length; r++) {
        for (let c=0; c<grid[0].length; c++) {
            if (visitedPacific[r][c] && visitedAtlantic[r][c]) {
                result.push([r,c]);
            }
        }
    }
    return result;
}

{
    let grid = [
        [1, 2, 2, 3, 5],
        [3, 2, 3, 4, 4],
        [2, 4, 5, 3, 1],
        [6, 7, 1, 4, 5],
        [5, 1, 1, 2, 4]
    ]
    
    console.log(mainBFS(grid));
}