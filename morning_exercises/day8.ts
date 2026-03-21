class ListNode {
    val: number;
    next: ListNode | null;

    constructor(val: number = 0, next: ListNode | null = null) {
        this.val = val;
        this.next = next;
    }
}

function createListNode(input: number[]):ListNode | null {
    if (input.length===0) return null;

    let head = new ListNode(input[0]);
    let curr: ListNode = head;

    for (let i=1; i<input.length; i++) {
        curr.next = new ListNode(input[i]);
        curr = curr.next!;
    }
    return head;
}

function printListNode(input: ListNode | null) {
    let curr: ListNode | null = input;
    while (curr!=null) {
        process.stdout.write(curr.val + "->");
        curr = curr.next;
    }
    console.log("null");
}

printListNode(createListNode([1,2,3,4,5]));

function reverseListNode(input: ListNode | null): ListNode | null {
    if (input === null || input.next === null) return input;

    let prev: ListNode | null = null;
    let curr: ListNode | null = input;
    let next: ListNode | null = curr;

    while (curr!=null) {
        next = curr.next;
        curr.next = prev;
        prev = curr;
        curr = next;
    }
    return prev;
}

printListNode(reverseListNode(createListNode([1,2,3,4,5])));