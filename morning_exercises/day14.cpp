#include <climits>
#include <memory>
#include <iostream>
#include <vector>

class BSTNode {
    public:
        int val = 0;
        std::shared_ptr<BSTNode> left = nullptr;
        std::shared_ptr<BSTNode> right = nullptr;
    BSTNode(int val): val(val) {}

    static void inOrderLA(std::shared_ptr<BSTNode> root, std::vector<int>& result, int k) {
        if (root==nullptr) return;

        inOrderLA(root->left, result, k);
        result.push_back(root->val);
        inOrderLA(root->right, result, k);
    }

    static int kthSmallestLA(std::shared_ptr<BSTNode> root, int k) {
        std::vector<int> result = {};
        inOrderLA(root, result, k);
        return result[k-1];
    }

    static void inOrder(std::shared_ptr<BSTNode> root, std::vector<int>& result, std::vector<int>& answer, int k) {
        if (root==nullptr || answer[0]!=INT_MIN) return;

        inOrder(root->left, result, answer, k);
        result[0]++;
        if (k==result[0]) {
            answer[0]=root->val;
            return;
        }
        inOrder(root->right, result, answer, k);
    }

    static int kthSmallest(std::shared_ptr<BSTNode> root, int k) {
        std::vector<int> result = {0}, answer = {INT_MIN};
        inOrder(root, result, answer, k);
        return answer[0];
    }
};

int main() {
    auto root = std::make_shared<BSTNode>(5);
    root->left = std::make_shared<BSTNode>(3);
    root->right = std::make_shared<BSTNode>(7);
    root->left->left = std::make_shared<BSTNode>(2);
    root->left->right = std::make_shared<BSTNode>(4);

    std::cout << BSTNode::kthSmallestLA(root, 3) << "\n";
    std::cout << BSTNode::kthSmallest(root, 3) << "\n";
}

