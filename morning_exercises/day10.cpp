#include <algorithm>
#include <cstdlib>
#include <ios>
#include <iostream>
#include <memory>
class TreeNode {
    public:
        int val;
        std::shared_ptr<TreeNode> left;
        std::shared_ptr<TreeNode> right;

    TreeNode(int val = 0): val(val), left(nullptr), right(nullptr) {}
};

int maxDepth(std::shared_ptr<TreeNode> root) {
    if (root==nullptr) return 0;

    return 1 + std::max(maxDepth(root->left), maxDepth(root->right));
}

int isBalancedHelper(std::shared_ptr<TreeNode> root) {
    if (root == nullptr) return 0;
    int left = isBalancedHelper(root->left);
    int right = isBalancedHelper(root->right);

    if (left==-1) return -1;
    if (right==-1) return -1;

    if (std::abs(left-right)>1) return -1;
    return 1 + std::max(left, right);
}

bool isBalanced(std::shared_ptr<TreeNode> root) {
    return isBalancedHelper(root)!=-1;
}

int main() {
    auto root = std::make_shared<TreeNode>(15);
    root->left = std::make_shared<TreeNode>(14);
    root->right = std::make_shared<TreeNode>(16);
    root->left->left = std::make_shared<TreeNode>(12);
    root->left->right = std::make_shared<TreeNode>(14);
    root->left->left->left = std::make_shared<TreeNode>(11);
    std::cout << std::boolalpha;
    std::cout << isBalanced(root) << "\n";
}