public static class FindBinary
{
    public static int BinarySearch(List<int> input, int left, int right, int val)
    {
        if (left>right) return -1;
        int mid = (left+right)/2;
        if (val==input[mid]) return mid;
        else if (val<input[mid]) return BinarySearch(input, left, mid-1, val);
        else return BinarySearch(input, mid+1, right, val);
    }
}