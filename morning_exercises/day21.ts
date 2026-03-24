function dfs(board: string[][], word: string, row: number, col: number, index: number): boolean {
    if (row<0 || row>=board.length) return false;
    if (col<0 || col>=board[0].length) return false;
    if (index === word.length) return true;
    if (board[row][col] === "#") return false;
    if (board[row][col] !== word[index]) return false;

    let original = board[row][col];
    board[row][col] = "#";

    let result: boolean = dfs(board, word, row, col-1, index+1) || 
                          dfs(board, word, row, col+1, index+1) ||
                          dfs(board, word, row-1, col, index+1) ||
                          dfs(board, word, row+1, col, index+1);
    
    board[row][col] = original;
    return result;
}

function wordSearch(board: string[][], word: string): boolean {
    if (board.length === 0 || board[0].length === 0 || word.length === 0) return false
    for (let i = 0; i<board.length; i++) {
        for (let j = 0; j<board[0].length; j++) {
            if (dfs(board, word, i, j, 0)) return true;
        }
    }
    return false;
}

{
    let board = [
        ['A','B','C','E'],
        ['S','F','C','S'],
        ['A','D','E','E']
    ];

    console.log(wordSearch(board, "ABCCED"));
    console.log(wordSearch(board, "SEE"));
    console.log(wordSearch(board, "ABCB"));
}