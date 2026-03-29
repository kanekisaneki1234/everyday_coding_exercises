using System.Runtime.CompilerServices;

class Doable
{
    public static List<List<int>> CreateGraph(int number, List<(int, int)> prerequisites)
    {
        List<List<int>> graph = [];
        for (int i = 0; i < number; i++) graph.Add([]);

        foreach (var(a,b) in prerequisites) graph[b].Add(a);
        return graph;
    }

    public static bool CheckDfs(List<List<int>> graph, int node, List<int> state)
    {
        if (state[node]==2) return true;
        if (state[node]==1) return false;

        state[node]=1;
        foreach (int neighbour in graph[node]) if (!CheckDfs(graph, neighbour, state)) return false;
        state[node]=2;
        return true;
    }

    public static bool IsDoable(List<List<int>> graph)
    {
        List<int> state = [];
        for (int i = 0; i < graph.Count; i++) state.Add(0);
        for (int i=0;i<graph.Count; i++) if (!CheckDfs(graph, i, state)) return false;
        return true;
    }
}