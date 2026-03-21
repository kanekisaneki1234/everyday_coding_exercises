class ListNode:
    def __init__(self, val=0, next = None):
        self.val = val
        self.next = next

def createListNode(input:list)->ListNode:
    if not input: return None
    head = ListNode(input[0])
    curr = head
    for i in range (1,len(input)):
        curr.next = ListNode(input[i])
        curr = curr.next

    return head

def printLinked(input:ListNode)->None:
    curr = input
    while (curr != None): 
        print(curr.val, end="->")
        curr = curr.next
    print("null")

input = createListNode([1,2,3,4,5])

printLinked(input)

def reverseLinkedList(input: ListNode)->ListNode:
    if not input: return None
    curr = input
    prev = None

    while (curr):
        next=curr.next
        curr.next=prev
        prev=curr
        curr=next

    return prev

printLinked(reverseLinkedList(createListNode([1,2,3,4,5])))
