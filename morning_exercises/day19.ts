class BinaryNode4 {
    constructor(
        public val: number = 0,
        public left: BinaryNode4 | null = null,
        public right: BinaryNode4 | null = null,
    ) {}

    static maxPathSumHelper(root: BinaryNode4 | null, globalMax: number[]): number {
        if (root==null) return 0;

        let leftBest: number = Math.max(0, BinaryNode4.maxPathSumHelper(root.left, globalMax));
        let rightBest: number = Math.max(0, BinaryNode4.maxPathSumHelper(root.right, globalMax));

        globalMax[0] = Math.max(globalMax[0], root.val+leftBest+rightBest);
        return root.val+Math.max(leftBest, rightBest);
    }

    static maxPathSum(root: BinaryNode4 | null): number {
        let globalMax: number[] = [-Infinity];

        BinaryNode4.maxPathSumHelper(root, globalMax);

        return globalMax[0];
    }
}

{
    const root = new BinaryNode4(11);
    root.left = new BinaryNode4(2);
    root.right = new BinaryNode4(3);
    root.left.left = new BinaryNode4(4);
    root.left.right = new BinaryNode4(5);

    console.log(BinaryNode4.maxPathSum(root));
}