#include <climits>
#include <ios>
#include <memory>
#include <iostream>

class BSTNode
{
    public:
        int val;
        std::shared_ptr<BSTNode> left;
        std::shared_ptr<BSTNode> right;
        
    BSTNode(int val = 0): val(val), left(nullptr), right(nullptr) {}

    static bool isValidBST(std::shared_ptr<BSTNode> root, long min, long max) {
        if (root==nullptr) return true;
        if (root->val>=max || root->val<=min) return false;
        return (isValidBST(root->left, min, root->val) && isValidBST(root->right, root->val, max));
    }

    static bool validation(std::shared_ptr<BSTNode> root) {
        return isValidBST(root, LONG_MIN, LONG_MAX);
    }
};

int main() {
    auto root = std::make_shared<BSTNode>(5);
    root->left = std::make_shared<BSTNode>(3);
    root->right = std::make_shared<BSTNode>(7);
    root->left->left = std::make_shared<BSTNode>(2);
    root->left->right = std::make_shared<BSTNode>(4);
    std::cout <<std::boolalpha;
    std::cout << BSTNode::validation(root) << "\n";
}