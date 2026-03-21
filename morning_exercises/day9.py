class TreeNode:
    def __init__(self, val):
        self.val = val
        self.left = None
        self.right = None

root = TreeNode(12)
root.left = TreeNode(4)
root.right = TreeNode(7)
root.right.left = TreeNode(5)
root.right.right = TreeNode(8)
root.right.right.right = TreeNode(10)

def maxDepth(root: TreeNode | None)->int:
    if root is None: return 0
    return 1 + max(maxDepth(root.left), maxDepth(root.right))

print(maxDepth(root))