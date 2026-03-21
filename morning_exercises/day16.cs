class BinaryNode(int val = 0, BinaryNode? left = null, BinaryNode? right = null)
{
    public int val = val;
    public BinaryNode? left = left;
    public BinaryNode? right = right;

    public static void IsGoodNode(BinaryNode? root, List<int> result, int max)
    {
        if (root==null) return;

        if (root.val>max) result.Add(root.val);
        IsGoodNode(root.left, result, Math.Max(root.val, max));
        IsGoodNode(root.right, result, Math.Max(root.val, max));
    }

    public static List<int> GoodNodes(BinaryNode? root)
    {
        List<int> result = [];

        IsGoodNode(root, result, int.MinValue);
        
        return result;
    }
}