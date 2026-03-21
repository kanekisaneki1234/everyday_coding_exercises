from __future__ import annotations

class BSTNode:
    def __init__(self, val):
        self.val = val
        self.left = None
        self.right = None
    
    @staticmethod
    def lca(root: BSTNode | None, val1: int, val2: int)-> int:
        if (root is None): return 0

        # if ((root.val >= val1) and (root.val <= val2)): return root.val

        if ((root.val > val1) and (root.val > val2)): return BSTNode.lca(root.left, val1, val2)
        if ((root.val < val1) and (root.val < val2)): return BSTNode.lca(root.right, val1, val2)
        return root.val

root = BSTNode(6)
root.left = BSTNode(4)
root.right = BSTNode(9)
root.left.left = BSTNode(2)
root.left.right = BSTNode(5)
root.right.left = BSTNode(7)
root.right.right = BSTNode(10)
root.right.left.right = BSTNode(8)

print(BSTNode.lca(root, 8, 10))
        