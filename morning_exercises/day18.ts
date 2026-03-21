class BinaryNode3 {
    constructor(
        public val: number = 0,
        public left: BinaryNode3 | null = null,
        public right: BinaryNode3 | null = null,
    ) {}

    static pathSum2Helper(root: BinaryNode3 | null, sum: number, targetSum: number, result: number[][], res: number[]=[]): void {
        if (root==null) return;

        res.push(root.val);

        if ((root.left==null && root.right==null) && (sum+root.val==targetSum)) result.push([...res]);

        BinaryNode3.pathSum2Helper(root.left, sum+root.val, targetSum, result, res);
        BinaryNode3.pathSum2Helper(root.right, sum+root.val, targetSum, result, res);
        res.pop();
    }
    
    static pathSum2(root: BinaryNode3, targetSum: number): number[][] {
        let result:number[][] = [];
        // let res:number[] = [];
        BinaryNode3.pathSum2Helper(root, 0, targetSum, result);

        return result;
    }
}

{
    let root = new BinaryNode3(5);
    root.left = new BinaryNode3(3);
    root.right = new BinaryNode3(4);
    root.left.right = new BinaryNode3(8);
    root.right.left = new BinaryNode3(7);
    root.right.right = new BinaryNode3(6);

    console.log(BinaryNode3.pathSum2(root, 16));
}