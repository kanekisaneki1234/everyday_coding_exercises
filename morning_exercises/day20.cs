class BinaryNode5(int val = 0, BinaryNode5? left = null, BinaryNode5? right = null)
{
    public int val = val;
    public BinaryNode5? left = left;
    public BinaryNode5? right = right;

    public static void SerialiseHelperQA(BinaryNode5? root, Queue<string> vals)
    {
        if (root==null)
        {
            vals.Enqueue("N");
            return;
        }

        vals.Enqueue(root.val.ToString());

        // vals.Enqueue(root==null ? "N" : root.val.ToString());

        SerialiseHelperQA(root.left, vals);
        SerialiseHelperQA(root.right, vals);
    }

    public static Queue<string> SerialiseQA(BinaryNode5? root)
    {
        Queue<string> vals = new();

        SerialiseHelperQA(root, vals);
        return vals;
    }

    public static void SerialiseHelperLLA(BinaryNode5? root, LinkedList<string> input)
    {
        if (root==null) 
        {
            input.AddLast("N");
            return;
        }

        input.AddLast(root.val.ToString());

        SerialiseHelperLLA(root.left, input);
        SerialiseHelperLLA(root.right, input);
    }

    public static LinkedList<string> SerialiseLLA(BinaryNode5? root)
    {
        LinkedList<string> input = new();

        SerialiseHelperLLA(root, input);

        return input;
    }

    public static BinaryNode5? DeserialiseQA(Queue<string> res)
    {
        string token = res.Dequeue();
        if (token == "N") return null;
        // int? val = token=="N" ? null : int.Parse(token);

        BinaryNode5? node = new(int.Parse(token))
        {
            left = DeserialiseQA(res),
            right = DeserialiseQA(res)
        };
        return node;
    }

    public static BinaryNode5? DeserialiseLLA(LinkedList<string> input)
    {
        string val = input.First();
        // string val = input.First!.Value;
        input.RemoveFirst();

        if (val=="N") return null;

        BinaryNode5? node = new(int.Parse(val))
        {
            left = DeserialiseLLA(input),
            right = DeserialiseLLA(input)
        };
        return node;
    }
}