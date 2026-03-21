class BinaryNode2(int val = 0, BinaryNode2? left = null, BinaryNode2? right = null)
{
    public int val = val;
    public BinaryNode2? left = left;
    public BinaryNode2? right = right;

    public static bool PathSum(BinaryNode2? root, int sum, int targetSum)
    {
        if (root==null) return false;

        if(root.left==null && root.right==null) return sum+root.val==targetSum;

        return PathSum(root.left, sum+root.val, targetSum) || PathSum(root.right, sum+root.val, targetSum);
    }
}