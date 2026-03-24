def wordSearch(grid: list, query: str)->bool:
    for i in range(0, len(grid)):
        for j in range(0, len(grid[0])):
            if(dfs(grid, query, i, j, 0)): return True
    return False    

def dfs(board, word, row, col, index):
    if index == len(word): return True
    if row < 0 or row >= len(board): return False
    if col < 0 or col >= len(board[0]): return False
    if board[row][col] == '#': return False
    if board[row][col] != word[index]: return False
    
    original = board[row][col]
    board[row][col] = '#'
    result = (dfs(board, word, row,col-1, index+1) or dfs(board, word, row,col+1, index+1) or dfs(board, word, row-1,col, index+1) or dfs(board, word, row+1,col, index+1))
    board[row][col] = original
    return result

board = [
    ['A','B','C','E'],
    ['S','F','C','S'],
    ['A','D','E','E']
]

print(wordSearch(board, "ABCCED"))
print(wordSearch(board, "SEE"))
print(wordSearch(board, "ABCB"))
