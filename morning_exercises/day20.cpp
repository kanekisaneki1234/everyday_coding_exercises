#include <iostream>
#include <memory>
#include <deque>
#include <ostream>
// #include <queue>
#include <string>

class BinaryNode {
    public:
        int val = 0;
        std::shared_ptr<BinaryNode> left = nullptr;
        std::shared_ptr<BinaryNode> right = nullptr;
    
    BinaryNode(int val): val(val) {}

    static void serialiseHelper(std::shared_ptr<BinaryNode> root, std::deque<std::string>& res) {
        if (root==nullptr) {
            res.push_back("N");
            return;
        }

        res.push_back(std::to_string(root->val));
        serialiseHelper(root->left, res);
        serialiseHelper(root->right, res);
    }

    static std::deque<std::string> serialise(std::shared_ptr<BinaryNode> root) {
        std::deque<std::string> res = {};

        serialiseHelper(root, res);

        return res;
    }

    static std::shared_ptr<BinaryNode> deserialiseHelper(std::deque<std::string>& input) {
        std::string val = input.front();
        input.pop_front();

        if (val=="N") return nullptr;

        auto node = std::make_shared<BinaryNode>(std::stoi(val));
        node->left = deserialiseHelper(input);
        node->right = deserialiseHelper(input);
        return node;
    }

    static std::shared_ptr<BinaryNode> deserialise(std::deque<std::string> input) {
        return deserialiseHelper(input);
    }
};

int main() {
    auto root = std::make_shared<BinaryNode>(11);
    root->left = std::make_shared<BinaryNode>(2);
    root->right = std::make_shared<BinaryNode>(3);
    root->left->left = std::make_shared<BinaryNode>(4);
    root->left->right = std::make_shared<BinaryNode>(5);

    std::deque<std::string> res = BinaryNode::serialise(BinaryNode::deserialise(BinaryNode::serialise(root)));

    for (std::string& s : res) {
        std::cout << s << " ";
    }
    std::cout << std::endl;
}