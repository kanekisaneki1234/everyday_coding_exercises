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

    static int maxPathSumHelper(std::shared_ptr<BinaryNode> root, std::vector<int>& globalMax) {
        if (root==nullptr) return 0;

        int bestLeft = std::max(0, maxPathSumHelper(root->left, globalMax));
        int bestRight = std::max(0, maxPathSumHelper(root->right, globalMax));
        globalMax[0]=std::max(globalMax[0], root->val+bestLeft+bestRight);

        return root->val+std::max(bestLeft,bestRight);
    }

    static int maxPathSum(std::shared_ptr<BinaryNode> root) {
        std::vector<int> globalMax = {INT_MIN};

        maxPathSumHelper(root, globalMax);

        std::cout << maxPathSumHelper(root, globalMax) << "\n";

        return globalMax[0];
    }
};

int main() {
    auto root = std::make_shared<BinaryNode>(11);
    root->left = std::make_shared<BinaryNode>(2);
    root->right = std::make_shared<BinaryNode>(3);
    root->left->left = std::make_shared<BinaryNode>(4);
    root->left->right = std::make_shared<BinaryNode>(5);

    std::cout << BinaryNode::maxPathSum(root) << "\n";
}