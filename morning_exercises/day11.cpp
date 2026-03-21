#include <iostream>
#include <memory>

class BSTNode {
    public:
        int val;
        std::shared_ptr<BSTNode> left;
        std::shared_ptr<BSTNode> right;
        
    BSTNode(int val = 0): val(val), left(nullptr), right(nullptr) {}
    
    static int lca(std::shared_ptr<BSTNode> root, int val1, int val2) {
        while (root!=nullptr) {
            if (root->val>val1 && root->val>val2) {
                root = root->left;
            }
            else if (root->val<val1 && root->val<val2) {
                root = root->right;
            }
            else return root->val;
        }
        return 0;
    }
};

int main() {
    auto root = std::make_shared<BSTNode>(5);
    root->left = std::make_shared<BSTNode>(4);
    root->right = std::make_shared<BSTNode>(7);
    root->right->left = std::make_shared<BSTNode>(6);
    root->right->right = std::make_shared<BSTNode>(8);
    root->right->right->right = std::make_shared<BSTNode>(10);

    std::cout << BSTNode::lca(root, 6,8);
}