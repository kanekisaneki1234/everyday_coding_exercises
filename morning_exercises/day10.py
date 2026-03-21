class TreeNode:
    def __init__(self, val=0):
        self.val = val
        self.left = None
        self.right = None

def isBalancedHelper(root: TreeNode | None)->int:
    if (root is None): return 0

    left = isBalancedHelper(root.left)
    right = isBalancedHelper(root.right)

    if (left==-1): return -1
    if (right==-1): return -1

    if (abs(left-right)>1): return -1
    return 1+max(left, right)

def isBalanced(root: TreeNode | None)->bool:
    return isBalancedHelper(root)!=-1

root = TreeNode(12)
root.left = TreeNode(4)
root.right = TreeNode(7)
root.right.left = TreeNode(5)
root.right.right = TreeNode(8)
# root.right.right.right = TreeNode(10)

print(isBalanced(root))