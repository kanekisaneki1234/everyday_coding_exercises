#include <ios>
#include <vector>
#include <iostream>

std::vector<std::vector<int>> courseGraph(int number, std::vector<std::pair<int, int>>& prerequisites) {
    std::vector<std::vector<int>> graph(number);
    for (const auto& [a, b] : prerequisites) graph[b].push_back(a);
    return graph;
}

bool checkDfs(std::vector<std::vector<int>>& graph, int node, std::vector<int>& state) {
    if (state[node]==2) return true;
    if (state[node]==1) return false;

    state[node]=1;
    for (int neighbour : graph[node]) if (!checkDfs(graph, neighbour, state)) return false;
    state[node]=2;
    return true;
}

bool isDoable(std::vector<std::vector<int>>& graph) {
    std::vector<int> state(graph.size());
    for (int i = 0; i<graph.size(); i++) if (!checkDfs(graph, i, state)) return false;
    return true;
}

int main() {
    std::vector<std::pair<int,int>> prerequisites = {{1,2}, {2,3}};
    auto graph = courseGraph(4, prerequisites);

    std::cout << std::boolalpha;
    std::cout << isDoable(graph) << "\n";
}