#include <ios>
#include <iostream>
#include <memory>
class BinaryNode {
    public:
        int val = 0;
        std::shared_ptr<BinaryNode> left = nullptr;
        std::shared_ptr<BinaryNode> right = nullptr;
    BinaryNode(int val): val(val) {}

    static bool pathSum(std::shared_ptr<BinaryNode> root, int sum, int targetSum) {
        if(root==nullptr) return false;

        if(root->left==nullptr && root->right==nullptr) return (sum+root->val==targetSum);
        return (pathSum(root->left, sum+root->val, targetSum) || pathSum(root->right, sum+root->val, targetSum));
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
    
    std::cout << std::boolalpha;
    std::cout << BinaryNode::pathSum(root, 0, 69);
}