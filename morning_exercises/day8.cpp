#include <cstddef>
#include <iostream>
#include <vector>
class ListNode {
public:
    int val;
    ListNode* next;

    ListNode(int val = 0, ListNode* next = nullptr) {
        this->val=val;
        this->next=next;
    }
};

ListNode* createListNode(std::vector<int> input) {
    if (input.size()==0) return nullptr;
    ListNode* head = new ListNode(input[0]);
    ListNode* curr = head;
    for (int i=1; i<input.size(); i++) {
        curr->next = new ListNode(input[i]);
        curr=curr->next;
    }
    return head;
}

void printListNodes(ListNode* input) {
    while (input!=nullptr) {
        std::cout << input->val << "->";
        input = input->next;
    }
    std::cout << "nullptr\n";
}

ListNode* reverseListNode(ListNode* input) {
    if (input==nullptr) return nullptr;
    ListNode* prev = nullptr;
    ListNode* curr = input;
    ListNode* next = curr;
    while (curr!=nullptr) {
        next = curr->next;
        curr->next = prev;
        prev = curr;
        curr = next;
    }
    return prev;
}

int main() {
    std::vector<int> input = {1,2,3,4,5};
    printListNodes(createListNode(input));
    printListNodes(reverseListNode(createListNode(input)));
}