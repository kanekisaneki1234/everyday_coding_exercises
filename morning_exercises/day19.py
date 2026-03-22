from __future__ import annotations

class BinaryNode:
    def __init__(self, val=0):
        self.val = val
        self.left = None
        self.right = None

    @staticmethod
    def maxPathSumHelper(root: BinaryNode | None, globalMax: list)->int:
        if root is None: return 0

        leftBest = max(0, BinaryNode.maxPathSumHelper(root.left, globalMax))
        rightBest = max(0, BinaryNode.maxPathSumHelper(root.right, globalMax))

        globalMax[0] = max(globalMax[0], root.val + leftBest + rightBest)

        return root.val + max(leftBest, rightBest)
    
    @staticmethod
    def maxPathSum(root: BinaryNode | None):
        globalMax = [float('-inf')]

        BinaryNode.maxPathSumHelper(root, globalMax)

        return globalMax[0]
    
root = BinaryNode(11)
root.left = BinaryNode(2)
root.right = BinaryNode(3)
root.left.left = BinaryNode(4)
root.left.right = BinaryNode(5)

print(BinaryNode.maxPathSum(root))
