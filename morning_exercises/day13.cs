class BSTNode2(int val = 0, BSTNode2? left = null, BSTNode2? right = null)
{
    public int val = val;
    public BSTNode2? left = left;
    public BSTNode2? right = right;

    public static bool Validator(BSTNode2? root, int min, int max)
    {
        if (root==null) return true;

        if (root.val>=max || root.val<=min) return false;

        return Validator(root.left, min, root.val) && Validator(root.right, root.val, max);
    }

    public static bool IsValidBST(BSTNode2 root)
    {
        return Validator(root, int.MinValue, int.MaxValue);
    }
}
