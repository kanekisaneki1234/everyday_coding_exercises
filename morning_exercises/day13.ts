class BSTNode2 {
    constructor (
        public val: number = 0,
        public left: BSTNode2 | null = null,
        public right: BSTNode2 | null = null,
    ) {}

    static validator(root: BSTNode2 | null, min:number, max:number): boolean {
        if (root==null) return true;

        if (root.val>=max || root.val<=min) return false;

        return (BSTNode2.validator(root.left, min, root.val) && BSTNode2.validator(root.right, root.val, max));
    }

    static isValidBST(root: BSTNode2 | null): boolean {
        return BSTNode2.validator(root, -Infinity, Infinity);
    }
}

{
    const root = new BSTNode2(6);
    root.left = new BSTNode2(4);
    root.right = new BSTNode2(9);
    root.left.left = new BSTNode2(2);
    root.left.right = new BSTNode2(5);

    console.log(BSTNode2.isValidBST(root));
}