class BSTNode3 {
    constructor(
        public val: number = 0,
        public left: BSTNode3 | null = null,
        public right: BSTNode3 | null = null
    ) {}

    static inOrderLA(root: BSTNode3 | null, result: number[]): void {
        if (root==null) return;

        BSTNode3.inOrderLA(root.left, result);
        result.push(root.val);
        BSTNode3.inOrderLA(root.right, result);
    }

    static kthSmallestLA(root: BSTNode3 | null, k: number): number {
        let result: number[] = [];
        BSTNode3.inOrderLA(root, result);
        return result[k-1];
    }

    static inOrder(root:BSTNode3 | null, result: number[], answer: number[], k: number): void {
        if (root == null || answer[0]!==-Infinity) return;

        BSTNode3.inOrder(root.left, result, answer, k);
        result[0]++;
        if (k===result[0]) {
            answer[0]=root.val;
            return;
        }
        BSTNode3.inOrder(root.right, result, answer, k);
    }

    static kthSmallest(root: BSTNode3 | null, k: number): number {
        let result: number[] = [0];
        let answer: number[] = [-Infinity];

        BSTNode3.inOrder(root, result, answer, k);

        return answer[0];
    }
}

{
    const root = new BSTNode3(6);
    root.left = new BSTNode3(4);
    root.right = new BSTNode3(9);
    root.left.left = new BSTNode3(2);
    root.left.right = new BSTNode3(5);

    console.log(BSTNode3.kthSmallestLA(root,2));
    console.log(BSTNode3.kthSmallest(root,2));
}
