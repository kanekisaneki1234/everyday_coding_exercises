class ListNode(int val = 0, ListNode? next = null)
{
    public int val = val;
    public ListNode? next = next;

    public static ListNode? createListNode(List<int>? input)
    {
        if (input == null) return null;

        ListNode head = new(input[0]);
        ListNode curr = head;

        for (int i = 1; i < input.Count; i++)
        {
            curr.next = new ListNode(input[i]);
            curr = curr.next;
        }
        return head;
    }

    public static void printListNode(ListNode? input)
    {
        ListNode? curr = input;
        while(curr!=null)
        {
            Console.Write(curr.val + "->");
            curr = curr.next;
        }
        Console.WriteLine("null");
    }

    public static ListNode? reverseListNode(ListNode? input)
    {
        if (input==null) return input;
        ListNode? curr = input;
        ListNode? prev = null;
        ListNode? next;

        while (curr!=null)
        {
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
        return prev;
    }
}