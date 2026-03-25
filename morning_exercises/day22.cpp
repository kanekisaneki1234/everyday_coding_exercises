#include <iostream>
#include <vector>

void dfs(std::vector<std::vector<int>>& grid, int row, int col) {
    if (row<0 || row>=grid.size()) return;
    if (col<0 || col>=grid[0].size()) return;
    if (grid[row][col]==0) return;

    grid[row][col] = 0;
    dfs(grid, row, col-1);
    dfs(grid, row, col+1);
    dfs(grid, row-1, col);
    dfs(grid, row+1, col);
}

int countIslands(std::vector<std::vector<int>>& grid) {
    if (grid.size()==0 || grid[0].size()==0) return 0;
    int count = 0;

    for (int i=0;i<grid.size(); i++) {
        for (int j=0;j<grid[0].size(); j++) {
            if (grid[i][j]==1) {
                dfs(grid, i, j);
                count++;
            }
        }
    }
    return count;
}

int main() {
    std::vector<std::vector<int>> grid = {
    {1,0,1,0},
    {0,0,1,0},
    {1,1,0,1}
    };

    std::cout << countIslands(grid) << "\n";
}