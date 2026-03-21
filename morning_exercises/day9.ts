class TreeNode {
    constructor(
        public val: number = 0,
        public left: TreeNode | null = null,
        public right: TreeNode | null = null
    ) {}
}

const root = new TreeNode(6);
root.left = new TreeNode(5);
root.right = new TreeNode(7);
root.right.right = new TreeNode(8);
root.right.right.left = new TreeNode(8);

function maxDepth(input: TreeNode | null): number {
    if (input === null) return 0;
    return 1 + Math.max(maxDepth(input.left), maxDepth(input.right));
}

console.log(maxDepth(root));