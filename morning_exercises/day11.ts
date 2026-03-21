class BSTNode {
    constructor (
        public val: number = 0,
        public left: BSTNode | null = null,
        public right: BSTNode | null = null
    ) {}

    static lca(root: BSTNode | null, val1: number, val2: number): number {
        while(root) {
            if (val1<root.val && val2<root.val) root = root.left;
            else if (val1>root.val && val2>root.val) root = root.right;
            else return root.val;
        }
        return 0;
    }
}

{
    const root = new BSTNode(5);
    root.left = new BSTNode(4);
    root.right = new BSTNode(7);
    root.right.left = new BSTNode(6);
    root.right.right = new BSTNode(8);
    root.right.right.right = new BSTNode(10);

    console.log(BSTNode.lca(root, 6,8));
}