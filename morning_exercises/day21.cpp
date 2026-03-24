#include <ios>
#include <iostream>
#include <vector>

bool dfs(std::vector<std::vector<char>>& board, std::string& word, int row, int col, int index) {
    if (row<0 || row>=board.size()) return false;
    if (col<0 || col>=board[0].size()) return false;
    if (index==word.length()) return true;
    if (board[row][col]=='#') return false;
    if (word[index]!=board[row][col]) return false;

    char original = board[row][col];
    board[row][col] = '#';
    bool result = dfs(board, word, row, col-1, index+1) || 
                  dfs(board, word, row, col+1, index+1) || 
                  dfs(board, word, row-1, col, index+1) || 
                  dfs(board, word, row+1, col, index+1);
    board[row][col] = original;
    return result;
}

bool wordSearch(std::vector<std::vector<char>> board, std::string word) {
    if (board.size()==0 || board[0].size()==0 || word.size()==0) return false;
    for (int i = 0; i<board.size(); i++) {
        for (int j = 0; j<board[0].size(); j++) {
            if (dfs(board, word, i, j, 0)) return true;
        }
    }
    return false;
}

int main() {
    std::vector<std::vector<char>> board = {
    {'A','B','C','E'},
    {'S','F','C','S'},
    {'A','D','E','E'}
    };
    std::cout << std::boolalpha;
    std::cout << wordSearch(board, "ABCCED") << "\n";
    std::cout << wordSearch(board, "SEE") << "\n";
    std::cout << wordSearch(board, "ABCB") << "\n";
}