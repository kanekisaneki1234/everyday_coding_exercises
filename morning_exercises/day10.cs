public class TreeNode2(int val = 0, TreeNode2? left = null, TreeNode2? right = null)
{
    public int val = val;
    public TreeNode2? left = left;
    public TreeNode2? right = right;

    // public static int MaxDepth(TreeNode2? root)
    // {
    //     if (root==null) return 0;
    //     return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    // }
    public static int IsBalancedHelper(TreeNode2? root)
    {
        if (root == null) return 0;
        int left = IsBalancedHelper(root.left);
        int right = IsBalancedHelper(root.right);

        if (left == -1) return -1;
        if (right == -1) return -1;

        if (Math.Abs(left - right)>1) return -1;
        return 1 + Math.Max(left, right);
    }

    public static bool IsBalanced(TreeNode2? root)
    {
        return IsBalancedHelper(root)!=-1;
    }
}