class BSTNode:
    def __init__(self, val):
        self.val = val
        self.left = None
        self.right = None

def lca(root: BSTNode | None, val1: int, val2: int)-> int:
    while root:
        if ((val1 > root.val) and (val2 > root.val)):
            root=root.right
        elif ((val1 < root.val) and (val2 < root.val)):
            root=root.left
        # elif (((val1 > root.val) and (val2 < root.val)) or ((val1 < root.val) and (val2 > root.val))):
        else:
            return root.val
    # return 0

root = BSTNode(5)
root.left = BSTNode(4)
root.right = BSTNode(7)
root.right.left = BSTNode(6)
root.right.right = BSTNode(8)
root.right.right.right = BSTNode(10)

print(lca(root, 6, 8))