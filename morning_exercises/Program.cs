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


// BinaryNode3 root = new(6)
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

// List<List<int>> result = BinaryNode3.PathSum2(root, 10);
// foreach (List<int> res in result)
// {
//     foreach (int c in res)
//     {
//         Console.Write(c + " ");
//     }
// }

// BinaryNode4 root = new(11)
// {
//     left = new(2)
//     {
//         left = new(6),
//         right = new(5)
//     },
//     right = new(8)
// };

// Console.WriteLine(BinaryNode4.MaxPathSum(root));


// BinaryNode5 root = new(11)
// {
//     left = new(2)
//     {
//         left = new(6),
//         right = new(5)
//     },
//     right = new(8)
// };

// Queue<string> result = BinaryNode5.SerialiseQA(root);

// LinkedList<string> inp = BinaryNode5.SerialiseLLA(root);

// foreach (string s in result) Console.WriteLine(s);
// foreach (string s in inp) Console.WriteLine(s);

// BinaryNode5? test1 = BinaryNode5.DeserialiseQA(result);
// BinaryNode5? test2 =BinaryNode5.DeserialiseLLA(inp);

// Queue<string> testresult = BinaryNode5.SerialiseQA(test1);
// LinkedList<string> testinp = BinaryNode5.SerialiseLLA(test2);

// // foreach (string s in testresult) Console.WriteLine(s);
// foreach (string s in testinp) Console.WriteLine(s);

// List<List<char>> grid = [
//     ['A','B','C','E'],
//     ['S','F','C','S'],
//     ['A','D','E','E']
// ];

// Console.WriteLine(CheckWord.WordSearch(grid, "ABCCED"));
// Console.WriteLine(CheckWord.WordSearch(grid, "SEE"));
// Console.WriteLine(CheckWord.WordSearch(grid, "ABCB"));

// List<List<int>> grid =  [
//                             [1,1,1,0],
//                             [0,0,0,0],
//                             [1,1,0,1]
//                         ];

// // Console.WriteLine(CountingIslands.IslandsCount(grid));
// Console.WriteLine(IslandMaxArea.MaxAreaIsland(grid));

// List<List<int>> grid =  [[1, 0, 0], 
//                          [2, 1, 0],
//                          [2, 1, 1]];

// Console.WriteLine(RottenOranges.BfsRottenOranges(grid));

// GraphNode node = new(4);
// GraphNode node2 = new(5);
// GraphNode node3 = new(7);
// GraphNode node4 = new(6);

// node.neighbours = [node2, node4];
// node2.neighbours = [node, node3];
// node3.neighbours = [node2, node4];
// node4.neighbours = [node, node3];

// Console.WriteLine(GraphNode.CloneGraph(node)!.neighbours![1].val);

// List<List<int>> graph = Doable.CreateGraph(4, [(0,1), (1,2),(2,3)]);

// Console.WriteLine(Doable.IsDoable(graph));


List<List<int>> graph = Doable2.CreateGraph(4, [(0,1), (1,2),(2,3)]);

LinkedList<int> result = Doable2.IsDoable(graph);

foreach (int node in result)
{
    Console.WriteLine(node);
}