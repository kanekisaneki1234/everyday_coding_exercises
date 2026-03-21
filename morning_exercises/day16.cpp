#include <climits>
#include <iostream>
#include <memory>
#include <vector>

class BinaryNode {
    public:
        int val = 0;
        std::shared_ptr<BinaryNode> left = nullptr;
        std::shared_ptr<BinaryNode> right = nullptr;
    BinaryNode(int val): val(val) {}

    static void goodNodesMain(std::shared_ptr<BinaryNode>& root, std::vector<int>& result, int min) {
        if (root == nullptr) return;

        // if (root->val<min) return;

        if (root->val>=min) result.push_back(root->val);
        goodNodesMain(root->left, result, std::max(root->val, min));
        goodNodesMain(root->right, result, std::max(root->val, min));
    }

    static std::vector<int> goodNodes(std::shared_ptr<BinaryNode> root) {
        std::vector<int> result = {};
        
        BinaryNode::goodNodesMain(root, result, INT_MIN);

        return result;
    }
};

int main() {
    auto root = std::make_shared<BinaryNode>(5);
    root->left = std::make_shared<BinaryNode>(3);
    root->left->left = std::make_shared<BinaryNode>(1);
    root->left->right = std::make_shared<BinaryNode>(4);
    root->right = std::make_shared<BinaryNode>(2);
    root->right->right = std::make_shared<BinaryNode>(7);
    root->right->left = std::make_shared<BinaryNode>(1);

    std::vector<int> result = BinaryNode::goodNodes(root);
    for (int c : result) {
        std::cout << c << "\n";
    }
}