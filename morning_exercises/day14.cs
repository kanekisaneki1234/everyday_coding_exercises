public class BSTNode3(int val = 0, BSTNode3? left = null, BSTNode3? right = null)
{
    public int val = val;
    public BSTNode3? left = left;
    public BSTNode3? right = right;

    public static void InOrderLA(BSTNode3? root, List<int> result, int k)
    {
        if (root==null) return;

        InOrderLA(root.left, result, k);
        result.Add(root.val);
        InOrderLA(root.right, result, k);
    }

    public static int kthSmallestLA(BSTNode3? root, int k)
    {
        List<int> result = [];
        InOrderLA(root, result, k);
        return result[k-1];
    }

    public static void InOrder(BSTNode3? root, List<int> result, List<int> answer, int k)
    {
        if (root==null || answer[0]!=int.MinValue) return;

        InOrder(root.left, result, answer, k);
        result[0]++;
        if (result[0]==k)
        {
            answer[0]=root.val;
            return;
        }
        InOrder(root.right, result, answer, k);
    }

    public static int kthSmallest(BSTNode3? root, int k)
    {
        List<int> result = [0];
        List<int> answer = [int.MinValue];

        InOrder(root, result, answer, k);

        return answer[0];
    }
}