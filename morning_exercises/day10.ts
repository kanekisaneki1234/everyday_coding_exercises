class TreeNode2 {
    constructor (
        public val: number = 0,
        public left: TreeNode2 | null = null,
        public right: TreeNode2 | null = null
    ) {}
}

function isBalancedHelper(root: TreeNode2 | null): number {
    if (root===null) return 0;

    let left: number = isBalancedHelper(root.left);
    let right: number = isBalancedHelper(root.right);

    if (left===-1) return -1;
    if (right===-1) return -1;

    if (Math.abs(left - right)>1) return -1;
    return 1+Math.max(left, right);    
}

function isBalanced(root: TreeNode2 | null): boolean {
    return isBalancedHelper(root)!=-1;
}

const root2 = new TreeNode2(6);
root2.left = new TreeNode2(5);
root2.right = new TreeNode2(7);
root2.right.right = new TreeNode2(8);
// root2.right.right.left = new TreeNode2(8);

const root3 = null;

console.log(isBalanced(root3));