// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Primebuzz.checkPrimebuzz(23);

// Console.WriteLine(Palindrome.IsPalindrome(112));

// FibBuzz.IsFibBuzz(22);

// var result = TwoSumOptimal.twoSum([1,2,3,4], 5);

// foreach (var pair in result)
// {
//     Console.WriteLine("[" + pair[0] + ", " + pair[1] + "]");
// }

// Console.WriteLine(CheckValid.isValid("{{{[}}}"));

// Console.WriteLine(FindMaxProfit.MaxProfit([1,1,1,1]));

// Console.WriteLine(FindDuplicates.containsDuplicates([1,2,3,4]));

// ListNode.printListNode(ListNode.createListNode([1, 2, 3, 4, 5]));
// ListNode.printListNode(ListNode.reverseListNode(ListNode.createListNode([1, 2, 3, 4, 5])));

// TreeNode root = new(6)
// {
//     left = new(5),
//     right = new(7)
//     {
//         right = new(9)
//         {
//             left = new(8)
//         }
//     }
// };
// Console.WriteLine(TreeNode.MaxDepth(root));

// TreeNode2 root = new(6)
// {
//     left = new(5),
//     right = new(7)
//     {
//         left = new(4),
//         right = new(8)
//     }
// };
// Console.WriteLine(TreeNode2.IsBalanced(root));

// BSTNode root = new(5)
// {
//     left = new(4),
//     right = new(7)
//     {
//         left = new(6),
//         right = new(8)
//         {
//             right = new(10)
//         }
//     }
// };

// Console.WriteLine(BSTNode.Lca(root, 6,8));

// List<int> input = [1,2,3,8,9,10];

// Console.WriteLine(FindBinary.BinarySearch(input, 0, 9, 9));

// BSTNode2 root = new(5)
// {
//     left = new(4),
//     right = new(7)
//     {
//         left = new(6),
//         right = new(8)
//         {
//             right = new(10)
//         }
//     }
// };

// Console.WriteLine(BSTNode2.IsValidBST(root));

// BSTNode3 root = new(5)
// {
//     left = new(4),
//     right = new(7)
//     {
//         left = new(6),
//         right = new(8)
//         {
//             right = new(10)
//         }
//     }
// };

// Console.WriteLine(BSTNode3.kthSmallestLA(root, 5));
// Console.WriteLine(BSTNode3.kthSmallest(root, 5));

// BSTNode4 root = new(5)
// {
//     left = new(4),
//     right = new(7)
//     {
//         left = new(6),
//         right = new(8)
//         {
//             right = new(10)
//         }
//     }
// };

// Console.WriteLine(BSTNode4.InOrderSuccessor(root, 8));


// BinaryNode root = new(6)
// {
//     left = new(4),
//     right = new(7)
//     {
//         left = new(10),
//         right = new(8)
//         {
//             right = new(5)
//         }
//     }
// };
// List<int> res = BinaryNode.GoodNodes(root);

// foreach (int c in res)
// {
//     Console.WriteLine(c);
// }

// BinaryNode2 root = new(6)
// {
//     left = new(4),
//     right = new(7)
//     {
//         left = new(10),
//         right = new(8)
//         {
//             right = new(5)
//         }
//     }
// };

// Console.WriteLine(BinaryNode2.PathSum(root, 0, 26));

using System.IO.Pipelines;

BinaryNode3 root = new(6)
{
    left = new(4),
    right = new(7)
    {
        left = new(10),
        right = new(8)
        {
            right = new(5)
        }
    }
};

List<List<int>> result = BinaryNode3.PathSum2(root, 10);
foreach (List<int> res in result)
{
    foreach (int c in res)
    {
        Console.Write(c + " ");
    }
}