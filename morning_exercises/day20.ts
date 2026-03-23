class BinaryNode5 {
    constructor(
        public val: number = 0,
        public left: BinaryNode5 | null = null,
        public right: BinaryNode5 | null = null,
    ) {}

    static serialiseHelper(root: BinaryNode5 | null, vals: string[]): void {
        if (root==null) {
            vals.push("N");
            return;
        }
        vals.push(root.val.toString());

        BinaryNode5.serialiseHelper(root.left, vals);
        BinaryNode5.serialiseHelper(root.right, vals);
    }

    static serialise(root: BinaryNode5 | null): string[] {
        let vals: string[] = [];
        BinaryNode5.serialiseHelper(root, vals);

        return vals;
    }

    static deserialise(input: string[]): BinaryNode5 | null {
        const val = input.shift()!;

        if (val==="N") return null;

        const node = new BinaryNode5(parseInt(val));
        node.left = BinaryNode5.deserialise(input);
        node.right = BinaryNode5.deserialise(input);
        return node;
    }
}

{
    const root = new BinaryNode5(11);
    root.left = new BinaryNode5(2);
    root.right = new BinaryNode5(3);
    root.left.left = new BinaryNode5(4);
    root.left.right = new BinaryNode5(5);

    // console.log(BinaryNode5.serialise(root));

    console.log(BinaryNode5.serialise(BinaryNode5.deserialise(BinaryNode5.serialise(root))));
}