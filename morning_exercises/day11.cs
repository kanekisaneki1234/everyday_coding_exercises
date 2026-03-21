public class BSTNode(int val = 0, BSTNode? left = null, BSTNode? right = null)
{
    public int val = val;
    public BSTNode? left = left;
    public BSTNode? right = right;

    public static int Lca(BSTNode? root, int val1, int val2)
    {
        while (root!=null)
        {
            if ((root.val > val1) && (root.val > val2))
            {
                root = root.left;
            }
            else if ((root.val < val1) && (root.val < val2))
            {
                root = root.right;
            }
            else return root.val;
        }
        return 0; // unreachable — p and q are guaranteed to exist. just keping it here cuz for c# all code paths must return val
    }
}

