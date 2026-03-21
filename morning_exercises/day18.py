from __future__ import annotations

class BinaryNode:
    def __init__(self, val=0):
        self.val = val
        self.left = None
        self.right = None

    def pathSum2Helper(root: BinaryNode | None, sum: int, targetSum: int, result: list, res: list=[])->None:
        if root is None: return

        res.append(root.val)

        if ((root.left is None and root.right is None) and (sum+root.val==targetSum)): result.append(res.copy())

        BinaryNode.pathSum2Helper(root.left, sum+root.val, targetSum, result, res)
        BinaryNode.pathSum2Helper(root.right, sum+root.val, targetSum, result, res)
        res.pop()

    @staticmethod
    def pathSum2(root: BinaryNode | None, targetSum: int)->list:
        result = []
        # res = []

        BinaryNode.pathSum2Helper(root, 0, targetSum, result)

        return result
    
root = BinaryNode(6)
root.left = BinaryNode(8)
root.right = BinaryNode(3)
root.left.left = BinaryNode(2)
root.left.right = BinaryNode(5)
root.right.left = BinaryNode(8)
root.right.right = BinaryNode(9)

print(BinaryNode.pathSum2(root, 16))
        
