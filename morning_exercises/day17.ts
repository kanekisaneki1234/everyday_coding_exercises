class BinaryNode2 {
    constructor(
        public val: number = 0,
        public left: BinaryNode2 | null = null,
        public right: BinaryNode2 | null = null
    ) {}

    static pathSum(root: BinaryNode2 | null, sum: number, targetSum: number): boolean {
        if (root==null) return false;

        if (root.left==null && root.right==null) return sum+root.val===targetSum;
        return BinaryNode2.pathSum(root.left, sum+root.val, targetSum) || BinaryNode2.pathSum(root.right, sum+root.val, targetSum);
    }
}

{
    let root = new BinaryNode2(5);
    root.left = new BinaryNode2(3);
    root.right = new BinaryNode2(4);
    root.left.right = new BinaryNode2(8);
    root.right.left = new BinaryNode2(7);
    root.right.right = new BinaryNode2(6);

    console.log(BinaryNode2.pathSum(root, 0, 16));
}
