#include <algorithm>
#include <iostream>
#include <memory>

class TreeNode {
    public:
        int val;
        // TreeNode* left;
        // TreeNode* right;
        std::shared_ptr<TreeNode> left;
        std::shared_ptr<TreeNode> right;

    // TreeNode(int val = 0) {
    //     this->val=val;
    //     this->left=nullptr;
    //     this->right=nullptr;
    // }
    TreeNode(int val = 0): val(val), left(nullptr), right(nullptr) {}
};

int maxDepth(std::shared_ptr<TreeNode> input) {
    if (input == nullptr) return 0;
    return 1 + std::max(maxDepth(input->left),maxDepth(input->right));
}

int main() {
    auto root = std::make_shared<TreeNode>(4);
    root->left = std::make_shared<TreeNode>(3);
    root->right = std::make_shared<TreeNode>(5);
    root->left->left = std::make_shared<TreeNode>(2);
    root->right->right = std::make_shared<TreeNode>(7);
    // root->right->right->left = std::make_shared<TreeNode>(6);

    std::cout << maxDepth(root) << "\n";
}