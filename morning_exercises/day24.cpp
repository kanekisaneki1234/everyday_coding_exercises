#include <iostream>
#include <vector>
#include <deque>

int bfsRottenOranges(std::vector<std::vector<int>>& grid) {
    std::deque<std::vector<int>> queue = {};
    int fresh = 0;
    for (int i=0;i<grid.size(); i++) {
        for (int j=0;j<grid[0].size(); j++) {
            if (grid[i][j]==2) queue.push_back({i, j});
            if (grid[i][j]==1) fresh++;
        }
    }
    int minutes = 0;
    std::vector<std::pair<int, int>> directions = {{-1,0},{1,0},{0,-1},{0,1}};
    while (queue.size()>0 && fresh>0) {
        int queueSize = queue.size();
        for (int i=0; i<queueSize; i++) {
            auto& coords=queue.front();
            for (int i : coords) {
                // std::cout << "coords:" << i << " ";
            }
            for (const auto& [r,c] : directions) {
                if (r+coords[0]>=0 && r+coords[0]<(int)grid.size() && c+coords[1]>=0 && c+coords[1]<(int)grid[0].size()) {
                    // std::cout << "row:" << r << " ";
                    // std::cout << "rowafter:" << r+coords[0] << " ";
                    // std::cout << "col:" << c << " ";
                    // std::cout << "colafter:" << c+coords[1] << " ";
                    if (grid[r+coords[0]][c+coords[1]]==1) {
                        // std::cout << "yep2" << "\n";
                        grid[r+coords[0]][c+coords[1]]=2;
                        queue.push_back({r+coords[0], c+coords[1]});
                        --fresh;
                    }
                }
            }
            queue.pop_front();
        }
        // std::cout << fresh << "\n";
        minutes++;
        // for (std::vector<int> vec : grid) {
        //     for (int i : vec) {
        //         std::cout << i << " ";
        //     }
        //     std::cout << "done" << "\n";
        // }
    }
    // if (fresh==0) return minutes;
    // return -1;
    return fresh==0 ? minutes : -1;
}

int main() {
    std::vector<std::vector<int>> grid = {{1, 0, 0}, 
                                          {2, 0, 0},
                                          {2, 1, 1}};

    std::cout << bfsRottenOranges(grid) << "\n";
}