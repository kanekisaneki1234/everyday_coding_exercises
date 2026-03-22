class BinaryNode4(int val = 0, BinaryNode4? left = null, BinaryNode4? right = null)
{
    public int val = val;
    public BinaryNode4? left = left;
    public BinaryNode4? right = right;

    public static int MaxPathSumHelper(BinaryNode4? root, List<int> globalMax)
    {
        if (root==null) return 0;

        int leftBest = Math.Max(0, MaxPathSumHelper(root.left, globalMax));
        int rightBest = Math.Max(0, MaxPathSumHelper(root.right, globalMax));

        globalMax[0] = Math.Max(globalMax[0], root.val+leftBest+rightBest);

        return root.val + Math.Max(leftBest, rightBest);
    }

    public static int MaxPathSum(BinaryNode4? root)
    {
        List<int> globalMax = [int.MinValue];

        MaxPathSumHelper(root, globalMax);

        return globalMax[0];
    }
}