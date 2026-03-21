class BinaryNode {
    constructor(
        public val: number = 0,
        public left: BinaryNode | null = null,
        public right: BinaryNode | null = null
    ) {}

    static goodNodes(root: BinaryNode | null, result: number[], max: number): void {
        if (root==null) return;

        if (root.val>max) result.push(root.val);
        BinaryNode.goodNodes(root.left, result, Math.max(root.val, max));
        BinaryNode.goodNodes(root.right, result, Math.max(root.val, max));
    }

    static isGoodNode(root: BinaryNode | null): number[] {
        let result: number[] = [];
        BinaryNode.goodNodes(root, result, -Infinity);

        return result;
    }
}

{
    let root = new BinaryNode(5);
    root.left = new BinaryNode(3);
    root.right = new BinaryNode(4);
    root.left.right = new BinaryNode(8);
    root.right.left = new BinaryNode(7);
    root.right.right = new BinaryNode(6);

    console.log(BinaryNode.isGoodNode(root));
}