#include <memory>
#include <iostream>
#include <optional>

class BSTNode {
    public:
        int val = 0;
        std::shared_ptr<BSTNode> left = nullptr;
        std::shared_ptr<BSTNode> right = nullptr;
    BSTNode(int val): val(val) {}

    static std::optional<int> inOrderSuccessor(std::shared_ptr<BSTNode> root, int k) {
        // if (root==nullptr) return std::nullopt;

        std::optional<int> successor = std::nullopt;

        while (root) {
            if (k<root->val) {
                successor=root->val;
                root=root->left;
            }
            else root=root->right;
        }
        return successor;
    }
};

int main() {
    auto root = std::make_shared<BSTNode>(5);
    root->left = std::make_shared<BSTNode>(3);
    root->right = std::make_shared<BSTNode>(7);
    root->left->left = std::make_shared<BSTNode>(2);
    root->left->right = std::make_shared<BSTNode>(4);

    auto result = BSTNode::inOrderSuccessor(root, 7);
    if (result.has_value()) {
        std::cout << result.value() << "\n";
    } else {
        std::cout << "No successor" << "\n";
    }
    // std::cout << BSTNode::inOrderSuccessor(root, 7) << "\n";
}

// class BSTNode2 {
//     public:
//         int val;
//         std::shared_ptr<BSTNode2> left;
//         std::shared_ptr<BSTNode2> right;

//     BSTNode2(int val = 0): val(val), left(nullptr), right(nullptr) {}
// };

