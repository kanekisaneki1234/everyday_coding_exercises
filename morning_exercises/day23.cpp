#include <algorithm>
#include <iostream>
#include <vector>

int dfsMaxArea(std::vector<std::vector<int>>& grid, int row, int col) {
    if (row<0 || row>=grid.size()) return 0;
    if (col<0 || col>=grid[0].size()) return 0;
    if (grid[row][col]==0) return 0;

    grid[row][col]=0;
    return 1 + dfsMaxArea(grid, row, col-1) + dfsMaxArea(grid, row, col+1) + dfsMaxArea(grid, row-1, col) + dfsMaxArea(grid, row+1, col);
}

int maxIslandArea(std::vector<std::vector<int>>& grid) {
    if (grid.size()==0 || grid[0].size()==0) return 0;

    int maxArea = 0;

    for (int i = 0; i<grid.size(); i++) {
        for (int j = 0; j<grid[0].size(); j++) {
            if (grid[i][j]==1) maxArea = std::max(maxArea, dfsMaxArea(grid, i, j));
        }
    }
    return maxArea;
}

int main() {
    std::vector<std::vector<int>> grid = {
    {1,1,1,0},
    {0,0,0,0},
    {1,1,0,1}
    };

    std::cout << maxIslandArea(grid) << "\n";
}