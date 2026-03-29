#include <utility>
#include <vector>
#include <deque>
#include <iostream>

std::vector<std::vector<int>> createGraph(int num, std::vector<std::pair<int, int>>& prereqs) {
    std::vector<std::vector<int>> graph(num);

    for (const auto& [a,b] : prereqs) graph[b].push_back(a);
    return graph;
}

bool dfsCheck(std::vector<std::vector<int>>& graph, int& node, std::vector<int>& state, std::deque<int>& result) {
    if (state[node]==2) return true;
    if (state[node]==1) return false;

    state[node]=1;
    for (int neighbour : graph[node]) {
        if(!dfsCheck(graph, neighbour, state, result)) return false;
    }
    state[node]=2;
    result.push_front(node);
    return true;
}

std::deque<int> isDoable(std::vector<std::vector<int>>& graph) {
    std::vector<int> state(graph.size());

    std::deque<int> result = {};

    for (int i=0;i<graph.size();i++) {
        if (!dfsCheck(graph, i, state, result)) return {};
    }
    return result;
}

int main() {
    std::vector<std::pair<int,int>> prerequisites = {{1,2}, {2,3}};
    auto graph = createGraph(4, prerequisites);

    // std::cout << std::boolalpha;
    auto result = isDoable(graph);
    for (int c : result) {
        std::cout << c << "\n";
    }
}