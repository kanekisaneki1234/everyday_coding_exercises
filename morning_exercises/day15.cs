class BSTNode4(int val=0, BSTNode4? left = null, BSTNode4? right = null)
{
    public int val = val;
    public BSTNode4? left = left;
    public BSTNode4? right = right;

    public static int? InOrderSuccessor(BSTNode4? root, int k)
    {
        // if (root==null) return null;

        int? successor = null;

        while (root!=null)
        {
            if (k < root.val)
            {
                successor=root.val;
                root=root.left;
            }
            else root=root.right;
        }
        return successor;
    }
}