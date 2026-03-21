from __future__ import annotations

class BSTNode:
    def __init__(self, val=0):
        self.val = val
        self.left = None
        self.right = None
    
    @staticmethod
    def inOrderSuccessorLA(root: BSTNode | None, result: dict)->None:
        if (root is None): return

        BSTNode.inOrderSuccessorLA(root.left, result)
        result[root.val]=root.val
        BSTNode.inOrderSuccessorLA(root.right, result)

    @staticmethod
    def successorLA(root: BSTNode | None, k: int)->int:
        result = {}
        BSTNode.inOrderSuccessorLA(root, result)
        keys = result.keys()
        for i in keys:
            if i>k: return result.get(i, 0)

    # @staticmethod
    # def inOrderSuccessor(root: BSTNode | None, result: list, k: int, min: float = float('-inf'), max: float = float('inf'))->None:
        # if ((root is None) or (result[0] is not None)): return

        # if (k<root.val): 
        #     BSTNode.inOrderSuccessor(root.left, result, k, min, root.val)
        #     if result[0] is None:
        #         result[0]=root.val
        
        # if k==root.val:
        #     # result[0]=root.val
        #     return

        # if (k>root.val):
        #     BSTNode.inOrderSuccessor(root.right, result, k, root.val, max)
        #     if result[0] is None:
        #         result[0]=root.val
    
    # @staticmethod
    # def successor(root, k):
    #     result = [None]
    #     BSTNode.inOrderSuccessor(root, result, k)
    #     return result[0]

    @staticmethod
    def inOrderSuccessor(root: BSTNode | None, k: int)->int | None:
        successor = None

        while(root):
            if(root.val>k):
                successor=root.val
                root=root.left
            else: root=root.right
            
        return successor

root = BSTNode(5)
root.left = BSTNode(4)
root.right = BSTNode(7)
root.right.left = BSTNode(6)
root.right.right = BSTNode(8)
root.right.right.right = BSTNode(10)

# print(BSTNode.successorLA(root, 8))
print(BSTNode.inOrderSuccessor(root, 6))
