class BinaryNode3(int val = 0, BinaryNode3? left = null, BinaryNode3? right = null)
{
    public int val = val;
    public BinaryNode3? left = left;
    public BinaryNode3? right = right;

    public static void PathSum2Helper(BinaryNode3? root, int sum, int targetSum, List<List<int>> result, List<int> res)
    {
        if (root==null) return;

        res.Add(root.val);

        if (root.left==null && root.right==null && (sum+root.val==targetSum)) result.Add([.. res]);

        PathSum2Helper(root.left, sum+root.val, targetSum, result, res);
        PathSum2Helper(root.right, sum+root.val, targetSum, result, res);
        res.RemoveAt(res.Count-1);
    }

    public static List<List<int>> PathSum2(BinaryNode3? root, int targetSum)
    {
        List<List<int>> result = [];
        List<int> res = [];

        PathSum2Helper(root, 0, targetSum, result, res);
        return result;
    }
}