from __future__ import annotations

class BinaryNode:
    def __init__(self, val=0):
        self.val = val
        self.left = None
        self.right = None

    @staticmethod
    def isGoodNode(root: BinaryNode | None, result: list, _max: float)->None:
        if root is None: return

        if (root.val>_max): result.append(root.val)
        BinaryNode.isGoodNode(root.left, result, max(_max, root.val))
        BinaryNode.isGoodNode(root.right, result, max(_max, root.val))

    @staticmethod
    def goodNodes(root: BinaryNode | None)->list:
        result = []
        BinaryNode.isGoodNode(root, result, float('-inf'))
        return result

root = BinaryNode(6)
root.left = BinaryNode(8)
root.right = BinaryNode(3)
root.left.left = BinaryNode(2)
root.left.right = BinaryNode(5)
root.right.left = BinaryNode(7)
root.right.right = BinaryNode(9)

print(BinaryNode.goodNodes(root))