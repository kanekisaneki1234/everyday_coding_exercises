#include <algorithm>
#include <deque>
#include <iostream>
#include <iterator>
#include <set>
#include <utility>
#include <vector>

void DFS(std::vector<std::vector<int>>& grid, int row, int col, int prevHeight, std::set<std::pair<int, int>>& visited) {
    if (row<0 || row>=grid.size()) return;
    if (col<0 || col>=grid[0].size()) return;
    if (visited.count({row, col})>0) return;
    if (grid[row][col]<prevHeight) return;

    visited.insert({row, col});

    DFS(grid, row, col-1, grid[row][col], visited);
    DFS(grid, row, col+1, grid[row][col], visited);
    DFS(grid, row-1, col, grid[row][col], visited);
    DFS(grid, row+1, col, grid[row][col], visited);
}

std::vector<std::pair<int, int>> mainDFS(std::vector<std::vector<int>>& grid) {
    std::set<std::pair<int, int>> pacific = {};
    std::set<std::pair<int, int>> atlantic = {};

    for (int c=0;c<grid[0].size(); c++) {
        DFS(grid, 0, c, grid[0][c], pacific);
        DFS(grid, grid.size()-1, c, grid[grid.size()-1][c], atlantic);
    }
    for (int r=0;r<grid.size(); r++) {
        DFS(grid, r, 0, grid[r][0], pacific);
        DFS(grid, r, grid[0].size()-1, grid[r][grid[0].size()-1], atlantic);
    }

    std::vector<std::pair<int, int>> result;

    std::set_intersection(
        pacific.begin(), pacific.end(),
        atlantic.begin(), atlantic.end(),
        back_inserter(result)
    );
    
    return result;
}

void BFS(std::vector<std::vector<int>>& grid, std::deque<std::pair<int, int>>& queue, std::set<std::pair<int,int>>& visited) {
    while (queue.size()>0) {
        std::vector<std::pair<int, int>> directions = {{0,-1}, {0,1}, {-1,0}, {1,0}};
        auto pair = queue.front();
        int row = pair.first; int col = pair.second;
        queue.pop_front();

        for (auto pair : directions) {
            int r = row + pair.first; int c = col + pair.second;

            if (r<0 || r>=grid.size()) continue;
            if (c<0 || c>=grid[0].size()) continue;
            if (visited.count({r,c})>0) continue;
            if (grid[r][c]<grid[row][col]) continue;

            visited.insert({r,c});
            queue.push_back({r,c});
        }
    }
}

std::vector<std::pair<int, int>> mainBFS(std::vector<std::vector<int>>& grid) {
    std::set<std::pair<int, int>> pacificVisited = {};
    std::set<std::pair<int, int>> atlanticVisited = {};

    std::deque<std::pair<int, int>> pacificQueue = {};
    std::deque<std::pair<int, int>> atlanticQueue = {};

    for (int c=0; c<grid[0].size(); c++) {
        pacificVisited.insert({0,c}); pacificQueue.push_back({0,c});
        atlanticVisited.insert({grid.size()-1, c}); atlanticQueue.push_back({grid.size()-1, c});
    }
    for (int r=0; r<grid.size(); r++) {
        pacificVisited.insert({r, 0}); pacificQueue.push_back({r, 0});
        atlanticVisited.insert({r, grid[0].size()-1}); atlanticQueue.push_back({r, grid[0].size()-1});
    }

    BFS(grid, pacificQueue, pacificVisited);
    BFS(grid, atlanticQueue, atlanticVisited);

    std::vector<std::pair<int, int>> result;

    std::set_intersection(
        pacificVisited.begin(), pacificVisited.end(),
        atlanticVisited.begin(), atlanticVisited.end(),
        std::back_inserter(result)
    );

    return result;
}

int main() {
    std::vector<std::vector<int>> grid = {
                                             {1, 2, 2, 3, 5},
                                             {3, 2, 3, 4, 4},
                                             {2, 4, 5, 3, 1},
                                             {6, 7, 1, 4, 5},
                                             {5, 1, 1, 2, 4}
                                         };
    // auto result = mainDFS(grid);
    auto result = mainBFS(grid);

    for (auto pair : result) {
        std::cout << pair.first << "," << pair.second << "\n"; 
    }
}