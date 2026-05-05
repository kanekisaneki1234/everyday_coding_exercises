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


// List<List<int>> graph = Doable2.CreateGraph(4, [(0,1), (1,2),(2,3)]);

// LinkedList<int> result = Doable2.IsDoable(graph);

// foreach (int node in result)
// {
//     Console.WriteLine(node);
// }

using System.Data;

// List<List<int>> grid = [
//                             [1, 2, 2, 3, 5],
//                             [3, 2, 3, 4, 4],
//                             [2, 4, 5, 3, 1],
//                             [6, 7, 1, 4, 5],
//                             [5, 1, 1, 2, 4]
//                         ];

// var result=FlowingWaters.MainDfs(grid);

// foreach (var (row,col) in result)
// {
//     Console.WriteLine($"Row: {row}, Col: {col}");
// }

// var result = FlowingWaters.MainBFS(grid);

// foreach (var (row,col) in result)
// {
//     Console.WriteLine($"Row: {row}, Col: {col}");
// }
// List<List<int>> input = [[1,2],[2,3]];
// MergeIntervals.MergeSort(input, 0, input.Count-1);

// Console.WriteLine(MergeIntervals.MergeIntervalsMain(input));

// foreach (var i in input)
// {
//     foreach (var item in i)
//     {
//         Console.Write(item);
//         Console.Write(" ");
//     }
//     Console.WriteLine();
// }

// ########## test cases ###########

// List<List<int>> input1 = [[1,2],[2,3],[3,4],[1,3]];
// MergeIntervals.MergeSort(input1, 0, input1.Count-1);
// Console.WriteLine(MergeIntervals.MergeIntervalsMain(input1)); // 1

// List<List<int>> input2 = [[1,2],[1,2],[1,2]];
// MergeIntervals.MergeSort(input2, 0, input2.Count-1);
// Console.WriteLine(MergeIntervals.MergeIntervalsMain(input2)); // 2

// List<List<int>> input3 = [[1,2],[2,3]];
// MergeIntervals.MergeSort(input3, 0, input3.Count-1);
// Console.WriteLine(MergeIntervals.MergeIntervalsMain(input3)); // 0

// List<List<int>> input4 = [[1,10],[2,3],[4,5]];
// MergeIntervals.MergeSort(input4, 0, input4.Count-1);
// Console.WriteLine(MergeIntervals.MergeIntervalsMain(input4)); // 2

// List<List<int>> input5 = [[1,2]];
// MergeIntervals.MergeSort(input5, 0, input5.Count-1);
// Console.WriteLine(MergeIntervals.MergeIntervalsMain(input5)); // 0

// List<List<int>> input6 = [[1,5],[2,4],[3,6]];
// MergeIntervals.MergeSort(input6, 0, input6.Count-1);
// Console.WriteLine(MergeIntervals.MergeIntervalsMain(input6)); // 2

// List<List<int>> input1 = [[1,2],[3,5],[4,6]];
// MergeIntervals.MergeSort(input1, 0, input1.Count-1);
// Console.WriteLine(MergeIntervals.MeetingRooms2(input1)); // 2

// List<List<int>> input2 = [[7,10],[2,4]];
// MergeIntervals.MergeSort(input2, 0, input2.Count-1);
// Console.WriteLine(MergeIntervals.MeetingRooms2(input2)); // 1

// List<List<int>> input3 = [[1,5],[2,6],[3,7]];
// MergeIntervals.MergeSort(input3, 0, input3.Count-1);
// Console.WriteLine(MergeIntervals.MeetingRooms2(input3)); // 3

// List<List<int>> input4 = [[1,2],[2,3],[3,4]];
// MergeIntervals.MergeSort(input4, 0, input4.Count-1);
// Console.WriteLine(MergeIntervals.MeetingRooms2(input4)); // 1

// List<List<int>> input5 = [[1,10],[2,3],[4,5],[6,7]];
// MergeIntervals.MergeSort(input5, 0, input5.Count-1);
// Console.WriteLine(MergeIntervals.MeetingRooms2(input5)); // 2

// List<List<int>> input6 = [[1,2]];
// MergeIntervals.MergeSort(input6, 0, input6.Count-1);
// Console.WriteLine(MergeIntervals.MeetingRooms2(input6)); // 1

// List<List<int>> input7 = [[1,10],[2,11],[3,4]];
// MergeIntervals.MergeSort(input7, 0, input7.Count-1);
// Console.WriteLine(MergeIntervals.MeetingRooms2(input7)); // 1

// List<List<int>> input1 = [[1,2],[3,5],[4,6]];
// MergeIntervals.MergeSort(input1, 0, input1.Count-1);
// Console.WriteLine(MergeIntervals.MeetingRooms2b(input1)); // 2

// List<List<int>> input2 = [[7,10],[2,4]];
// MergeIntervals.MergeSort(input2, 0, input2.Count-1);
// Console.WriteLine(MergeIntervals.MeetingRooms2b(input2)); // 1

// List<List<int>> input3 = [[1,5],[2,6],[3,7]];
// MergeIntervals.MergeSort(input3, 0, input3.Count-1);
// Console.WriteLine(MergeIntervals.MeetingRooms2b(input3)); // 3

// List<List<int>> input4 = [[1,2],[2,3],[3,4]];
// MergeIntervals.MergeSort(input4, 0, input4.Count-1);
// Console.WriteLine(MergeIntervals.MeetingRooms2b(input4)); // 1

// List<List<int>> input5 = [[1,10],[2,3],[4,5],[6,7]];
// MergeIntervals.MergeSort(input5, 0, input5.Count-1);
// Console.WriteLine(MergeIntervals.MeetingRooms2b(input5)); // 2

// List<List<int>> input6 = [[1,2]];
// MergeIntervals.MergeSort(input6, 0, input6.Count-1);
// Console.WriteLine(MergeIntervals.MeetingRooms2b(input6)); // 1

// List<List<int>> input7 = [[1,10],[2,11],[3,4]];
// MergeIntervals.MergeSort(input7, 0, input7.Count-1);
// Console.WriteLine(MergeIntervals.MeetingRooms2b(input7)); // 3

// List<List<int>> input8 = [[1,10],[2,4], [2,3],[3,4], [4,5]];
// MergeIntervals.MergeSort(input8, 0, input8.Count-1);
// Console.WriteLine(MergeIntervals.MeetingRooms2b(input8)); // 3

// List<int> newInterval1 = [2,5];
// List<List<int>> input1 = [[1,3],[6,9]];
// Console.WriteLine(string.Join(", ", MergeIntervals.InsertInterval(input1, newInterval1).Select(x => $"[{x[0]},{x[1]}]"))); // [1,5],[6,9]

// List<int> newInterval2 = [4,8];
// List<List<int>> input2 = [[1,2],[3,5],[6,7],[8,10],[12,16]];
// Console.WriteLine(string.Join(", ", MergeIntervals.InsertInterval(input2, newInterval2).Select(x => $"[{x[0]},{x[1]}]"))); // [1,2],[3,10],[12,16]

// // List<int> newInterval3 = [5,7];
// // List<List<int>> input3 = [];
// // Console.WriteLine(string.Join(", ", MergeIntervals.InsertInterval(input3, newInterval3).Select(x => $"[{x[0]},{x[1]}]"))); // [5,7]

// List<int> newInterval4 = [1,5];
// List<List<int>> input4 = [[2,3],[4,6]];
// Console.WriteLine(string.Join(", ", MergeIntervals.InsertInterval(input4, newInterval4).Select(x => $"[{x[0]},{x[1]}]"))); // [1,6]

// List<int> newInterval5 = [6,8];
// List<List<int>> input5 = [[1,2],[3,5],[9,10]];
// Console.WriteLine(string.Join(", ", MergeIntervals.InsertInterval(input5, newInterval5).Select(x => $"[{x[0]},{x[1]}]"))); // [1,2],[3,8],[9,10]

// List<int> newInterval6 = [0,10];
// List<List<int>> input6 = [[1,2],[3,4],[5,6]];
// Console.WriteLine(string.Join(", ", MergeIntervals.InsertInterval(input6, newInterval6).Select(x => $"[{x[0]},{x[1]}]"))); // [0,10] - new interval swallows all

// List<int> queries1 = [2,19,5,22];
// List<List<int>> input1 = [[2,5],[2,3],[1,8],[20,25]];
// Console.WriteLine(string.Join(", ", MergeIntervals.MinSizeOptimal(input1, queries1))); // 2,-1,4,6

// List<int> queries1 = [2,19,5,22];
// List<List<int>> input1 = [[2,3],[2,5],[1,8],[20,25]];
// Console.WriteLine(string.Join(", ", MergeIntervals.MinSize(input1, queries1))); // 2,-1,4,6

// List<int> queries2 = [2,3,4,5];
// List<List<int>> input2 = [[1,4],[2,4],[3,6],[4,5]];
// Console.WriteLine(string.Join(", ", MergeIntervals.MinSize(input2, queries2))); // 3,3,2,2

// List<int> queries3 = [4];
// List<List<int>> input3 = [[1,3],[2,6]];
// Console.WriteLine(string.Join(", ", MergeIntervals.MinSize(input3, queries3))); // 5

// List<int> queries4 = [5];
// List<List<int>> input4 = [[1,2],[3,4]];
// Console.WriteLine(string.Join(", ", MergeIntervals.MinSize(input4, queries4))); // -1

// List<int> queries5 = [2,4,6];
// List<List<int>> input5 = [[1,10],[2,3],[4,5]];
// Console.WriteLine(string.Join(", ", MergeIntervals.MinSize(input5, queries5))); // 2,2,10

List<int> nums = [1,2,3,4,5];
int target = 6;

Console.WriteLine(BinarySearchButDiff.BinarySearch(nums, target));