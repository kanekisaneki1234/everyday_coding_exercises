class BSTNode4 {
    constructor(
        public val: number = 0,
        public left: BSTNode4 | null = null,
        public right: BSTNode4 | null = null
    ) {}

    static inOrderSuccessor(root: BSTNode4 | null, k: number): number | null {
        if (root==null) return null;

        let successor: number | null = null;

        while (root) {
            if (k<root.val) {
                successor = root.val;
                root=root.left;
            }
            else root=root.right;
        }
        return successor;
    }
}

{
    const root = new BSTNode4(6);
    root.left = new BSTNode4(4);
    root.right = new BSTNode4(9);
    root.left.left = new BSTNode4(2);
    root.left.right = new BSTNode4(5);

    console.log(BSTNode4.inOrderSuccessor(root, 5));
}