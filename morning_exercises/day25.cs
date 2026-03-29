class GraphNode(int val = 0, List<GraphNode>? neighbour = null)
{
    public int val = val;
    public List<GraphNode>? neighbours = neighbour ?? [];

    public static GraphNode? CloneGraphHelper(GraphNode? node, Dictionary<GraphNode, GraphNode> map)
    {
        if (node==null) return null;
        // if (node.neighbours==null) return new GraphNode(node.val);
        // if (i >= node.neighbours.Count) return null;
        // map.TryAdd(node.val, node.neighbours);
        if (map.ContainsKey(node)) return map[node];
        GraphNode clone = new(node.val);
        map.Add(node, clone);
        // node = node.neighbours[i+1];
        foreach (GraphNode neighbour in node.neighbours!)
        {
            clone.neighbours!.Add(CloneGraphHelper(neighbour, map)!);
        }
        return clone;
    }

    public static GraphNode? CloneGraph(GraphNode? node)
    {
        Dictionary<GraphNode, GraphNode> map = [];
        return CloneGraphHelper(node, map);
    }
}