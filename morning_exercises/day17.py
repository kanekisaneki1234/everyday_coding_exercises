from __future__ import annotations

class BinaryNode:
    def __init__(self, val=0):
        self.val = val
        self.left = None
        self.right = None

    @staticmethod
    def pathSum(root: BinaryNode | None, sum: int, targetSum: int)->bool:
        if root is None: return False

        if ((root.left is None) and (root.right is None)): return sum+root.val==targetSum

        return (BinaryNode.pathSum(root.left, sum+root.val, targetSum) or BinaryNode.pathSum(root.right, sum+root.val, targetSum))
    
root = BinaryNode(6)
root.left = BinaryNode(8)
root.right = BinaryNode(3)
root.left.left = BinaryNode(2)
root.left.right = BinaryNode(5)
root.right.left = BinaryNode(8)
root.right.right = BinaryNode(9)

print(BinaryNode.pathSum(root, 0, 18))
