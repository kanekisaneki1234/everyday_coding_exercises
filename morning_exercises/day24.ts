function bfsRottenOranges(grid: number[][]): number {
    let fresh = 0;
    let rotten = [];
    for (let row = 0; row<grid.length; row++) {
        for (let col = 0; col<grid[0].length; col++) {
            if (grid[row][col]==2) rotten.push([row, col]);
            if (grid[row][col]==1) fresh++;
        }
    }
    let minutes = 0;
    while (rotten.length>0 && fresh>0) {
        let directions = [[-1,0], [1,0], [0,-1], [0,1]];
        const currentWave = rotten.length;
        for (let i = 0; i<currentWave; i++) {
            let coords = rotten.shift();
            for (const [r,c] of directions) {
                if (((r+coords![0])>=0 && (r+coords![0])<grid.length) && ((c+coords![1])>=0 && (c+coords![1])<grid[0].length)) {
                    if (grid[r+coords![0]][c+coords![1]]==1) {
                        grid[r+coords![0]][c+coords![1]]=2;
                        rotten.push([r+coords![0], c+coords![1]]);
                        fresh--;
                    }
                }
            }
        }
        console.log(grid);
        minutes++;
    }
    if (fresh!=0) return -1;
    return minutes;
}

console.log(bfsRottenOranges([[1, 0, 0], 
                              [2, 1, 0],
                              [2, 1, 1]]))
