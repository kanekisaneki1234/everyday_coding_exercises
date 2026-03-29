class Doable2
{
    public static List<List<int>> CreateGraph(int number, List<(int, int)> prereqs)
    {
        List<List<int>> graph = [];
        for (int i=0;i<number;i++)
        {
            graph.Add([]);
        }
        foreach (var (a,b) in prereqs) graph[b].Add(a);
        return graph;
    }

    public static bool DfsCheck(List<List<int>> graph, int node, List<int> state, LinkedList<int> result)
    {
        if (state[node]==2) return true;
        if (state[node]==1) return false;

        state[node]=1;
        foreach (int neighbour in graph[node])
        {
            if (!DfsCheck(graph, neighbour, state, result)) return false;
        }
        state[node]=2;
        result.AddFirst(node);
        return true;
    }

    public static LinkedList<int> IsDoable(List<List<int>> graph)
    {
        List<int> state = [];
        for (int i = 0; i < graph.Count; i++) state.Add(0);

        LinkedList<int> result = [];
        for (int j = 0; j < graph.Count; j++)
        {
            if (!DfsCheck(graph, j, state, result)) return [];
        }
        return result;
    }
}