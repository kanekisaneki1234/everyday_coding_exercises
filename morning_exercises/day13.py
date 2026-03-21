from __future__ import annotations

class BSTNode:
    def __init__(self, val):
        self.val = val
        self.left = None
        self.right = None
    
    @staticmethod
    def Validator(root: BSTNode | None, min: float=float('-inf'), max: float=float('inf'))->bool:
        if (root is None): return True
        if (root.val>=max or root.val<=min): return False
        return (BSTNode.Validator(root.left, min, root.val) and BSTNode.Validator(root.right, root.val, max))
    
root = BSTNode(6)
root.left = BSTNode(4)
root.right = BSTNode(9)
root.left.left = BSTNode(2)
root.left.right = BSTNode(5)
root.right.left = BSTNode(7)
root.right.right = BSTNode(10)

print(BSTNode.Validator(root))