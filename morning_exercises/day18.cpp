#include <iostream>
#include <memory>
#include <vector>

class BinaryNode {
    public:
        int val = 0;
        std::shared_ptr<BinaryNode> left = nullptr;
        std::shared_ptr<BinaryNode> right = nullptr;
    
    BinaryNode(int val): val(val) {}

    static void pathSum2Helper(std::shared_ptr<BinaryNode> root, int sum, int targetSum, std::vector<std::vector<int>>& result, std::vector<int>& res) {
        if (root==nullptr) return;

        res.push_back(root->val);
        
        if ((root->left==nullptr && root->right==nullptr) && sum+root->val==targetSum) {
            result.push_back(res);
            // res.clear(); // Works when only the values till one of the branch leaves equals the targetSUm, but this pretty much resets everything so anything after this has nothing to push to results apart from the last node (the most recent `res.push_back(root->val);` call)
        }

        pathSum2Helper(root->left, sum+root->val, targetSum, result, res);
        pathSum2Helper(root->right, sum+root->val, targetSum, result, res);
        res.pop_back();
    }

    static std::vector<std::vector<int>> pathSum2(std::shared_ptr<BinaryNode> root, int targetSum) {
        std::vector<std::vector<int>> result = {};

        std::vector<int> res = {};

        pathSum2Helper(root, 0, targetSum, result, res);

        return result;
    }

};

int main() {
    auto root = std::make_shared<BinaryNode>(5);
    root->left = std::make_shared<BinaryNode>(3);
    root->left->left = std::make_shared<BinaryNode>(1);
    root->left->right = std::make_shared<BinaryNode>(1);
    root->right = std::make_shared<BinaryNode>(2);
    root->right->right = std::make_shared<BinaryNode>(7);
    root->right->left = std::make_shared<BinaryNode>(1);
    
    std::vector<std::vector<int>> result = BinaryNode::pathSum2(root, 9);
    for (std::vector<int> vec : result) {
        std::cout << "\n";
        for (int c : vec) {
            std::cout << c << " ";
        }
    }
}