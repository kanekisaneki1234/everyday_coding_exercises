from __future__ import annotations
from collections import deque

class BinaryNode:
    def __init__(self, val=0):
        self.val=val
        self.left = None
        self.right = None

    @staticmethod
    def serialiseHelper(root: BinaryNode | None, res: list)->None:
        if root is None:
            res.append('N')
            return

        res.append(str(root.val))
        BinaryNode.serialiseHelper(root.left, res)
        BinaryNode.serialiseHelper(root.right, res)

    @staticmethod
    def serialise(root: BinaryNode | None)->list:
        res=[]
        BinaryNode.serialiseHelper(root, res)
        return res
    
    @staticmethod
    def serialiseHelperDA(root: BinaryNode | None, vals: deque)->None:
        if root is None: 
            vals.append('N')
            return

        vals.append(root.val)
        BinaryNode.serialiseHelperDA(root.left, vals)
        BinaryNode.serialiseHelperDA(root.right, vals)

    @staticmethod 
    def serialiseDA(root: BinaryNode | None)->deque:
        vals = deque()

        BinaryNode.serialiseHelperDA(root, vals)
        return vals
    
    @staticmethod
    def deserialise(res: list)->BinaryNode | None:
        val = res.pop(0)
        if val=='N': return None
        node = BinaryNode(int(val))
        node.left = BinaryNode.deserialise(res)
        node.right = BinaryNode.deserialise(res)
        return node

    @staticmethod
    def deserialise_Deque(input: deque)->BinaryNode | None:
        val = input.popleft()

        if val == 'N': return None

        node = BinaryNode(int(val))
        node.left = BinaryNode.deserialise_Deque(input)
        node.right = BinaryNode.deserialise_Deque(input)
        return node

root = BinaryNode(11)
root.left = BinaryNode(2)
root.right = BinaryNode(3)
root.left.left = BinaryNode(4)
root.left.right = BinaryNode(5)

# print(BinaryNode.serialise(root))

# print(BinaryNode.serialise(BinaryNode.deserialise(BinaryNode.serialise(root))))

print(BinaryNode.serialiseDA(root))

print(BinaryNode.serialiseDA(BinaryNode.deserialise_Deque(BinaryNode.serialiseDA(root))))
