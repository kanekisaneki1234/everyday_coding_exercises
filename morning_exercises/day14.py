from __future__ import annotations

class BSTNode:
    def __init__(self, val):
        self.val = val
        self.left = None
        self.right = None
    
    @staticmethod
    def inorder(root: BSTNode | None, result: list, answer: list, k: int)->None:
        if root is None or result[0]==k: return

        BSTNode.inorder(root.left, result, answer, k)
        result[0]+=1
        if k==result[0]:
            answer[0]=root.val
            return
        BSTNode.inorder(root.right, result, answer, k)

    @staticmethod
    def ioListApproach(root: BSTNode | None, result: list)->None:
        if root is None: return

        BSTNode.ioListApproach(root.left, result)
        result.append(root.val)
        BSTNode.ioListApproach(root.right, result)

    @staticmethod
    def kthSmallest(root, k):
        result = [0]
        answer = [None]
        BSTNode.inorder(root, result, answer, k)
        return answer[0]
    
    @staticmethod
    def kthSmallestListApproach(root, k):
        result = []
        BSTNode.ioListApproach(root, result)
        return result[k-1]
    
root = BSTNode(4)
root.left = BSTNode(2)
root.left.left = BSTNode(1)
root.left.right = BSTNode(3)
print(BSTNode.kthSmallest(root,3))
print(BSTNode.kthSmallestListApproach(root,3))
