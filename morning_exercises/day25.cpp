#include <iostream>
#include <memory>
#include <unordered_map>
#include <vector>
class GraphNode {
    public:
        int val = 0;
        std::vector<std::shared_ptr<GraphNode>> neighbours = {};
    GraphNode(int val = 0): val(val) {}

    static std::shared_ptr<GraphNode> cloneGraphHelper(std::shared_ptr<GraphNode> node, std::unordered_map<std::shared_ptr<GraphNode>, std::shared_ptr<GraphNode>>& seen) {
        if (node == nullptr) return nullptr;
        if (node->neighbours.size()==0) return std::make_shared<GraphNode>(node->val);

        if (seen.count(node)>0) return seen[node];

        auto clone = std::make_shared<GraphNode>(node->val);
        // seen.insert({node, clone});
        seen[node]=clone;

        for (const auto& neighbour : node->neighbours) clone->neighbours.push_back(cloneGraphHelper(neighbour, seen));
        return clone;
    }

    static std::shared_ptr<GraphNode> cloneGraph(std::shared_ptr<GraphNode> node) {
        std::unordered_map<std::shared_ptr<GraphNode>, std::shared_ptr<GraphNode>> seen = {};

        return cloneGraphHelper(node, seen);
    }
};

int main() {
    auto node = std::make_shared<GraphNode>(1);
    auto node2 = std::make_shared<GraphNode>(2);
    auto node3 = std::make_shared<GraphNode>(3);
    auto node4 = std::make_shared<GraphNode>(4);

    node->neighbours={node2, node4};
    node2->neighbours={node3, node};
    node3->neighbours={node4, node2};
    node4->neighbours={node, node3};

    std::cout << GraphNode::cloneGraph(node)->neighbours[0]->neighbours[0]->neighbours[0]->val << "\n";
}