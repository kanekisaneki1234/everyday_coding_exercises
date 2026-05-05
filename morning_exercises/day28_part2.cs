class MergeIntervals
{
    public static void MergeSort(List<List<int>> input, int left, int right)
    {
        if (left>=right) return;

        int mid = (left+right)/2;

        MergeSort(input, left, mid);
        MergeSort(input, mid+1, right);

        int i = left; int j = mid + 1;

        while (i<=mid && j <= right)
        {
            if (input[i][0]<input[j][0]) i+=1;
            else
            {
                List<int> temp = input[j];
                int k = j;
                while (k > i)
                {
                    input[k]=input[k-1];
                    k--;
                }
                input[i]=temp;
                i++;
                j++;
            }
        }
    }

    public static int MergeIntervalsMain(List<List<int>> sortedInput)
    {
        // List<List<int>> result = [sortedInput[0]];

        // int count = 0;
        // for (int i=1; i<sortedInput.Count; i++)
        // {
        //     if (result[^1][1] > sortedInput[i][0])
        //     {
        //         result[^1][1]=Math.Max(result[^1][1], sortedInput[i][1]);
        //         count++;
        //     }
        //     else
        //     {
        //         result.Add(sortedInput[i]);
        //     }
        // }
        // return count;

        int res = sortedInput[0][1];
        int count = 0;
        for (int i=1; i<sortedInput.Count; i++)
        {
            if (res > sortedInput[i][0])
            {
                // res = Math.Min(res, sortedInput[i][1]);
                count++;
            }
        }
        return count;
    }

    public static bool MeetingRooms(List<List<int>> sortedInput)
    {
        bool possible = true;
        if (sortedInput.Count==1) return possible;
        int res = sortedInput[0][1];
        for (int i=1; i<sortedInput.Count; i++)
        {
            if (res > sortedInput[i][0])
            {
                possible=false;
                return possible;
            }
        }
        return possible;
    }

    public static int MeetingRooms2(List<List<int>> sortedInput)
    {
        // PriorityQueue<int, int> pq = new();
        // pq.Enqueue(sortedInput[0][1], sortedInput[0][1]);
        int res = sortedInput[0][1];
        int minMeetingRooms = 1;
        for (int i=1; i<sortedInput.Count; i++)
        {
            if (res > sortedInput[i][0])
            {
                minMeetingRooms++;
            }
            res = sortedInput[i][1];
        }
        return minMeetingRooms;
    }

    public static int MeetingRooms2b(List<List<int>> sortedInput)
    {
        PriorityQueue<int, int> pq = new();
        pq.Enqueue(sortedInput[0][1], sortedInput[0][1]);

        for (int i=1; i<sortedInput.Count; i++)
        {
            if (sortedInput[i][0] < pq.Peek())
            {
                pq.Enqueue(sortedInput[i][1], sortedInput[i][1]);
            }
            else
            {
                pq.DequeueEnqueue(sortedInput[i][1], sortedInput[i][1]);
            }
        }
        return pq.Count;
    }

    public static List<List<int>> InsertInterval(List<List<int>> intervals, List<int> input)
    {
        for (int i=0;i<intervals.Count;i++)
        {
            if (input[0]<intervals[i][0]) 
            {
                intervals.Insert(i, input);
                break;
            }
            else if (i==intervals.Count-1)
            {
                intervals.Add(input);
                break;
            }
        }
        List<List<int>> res = [];
        res.Add(intervals[0]);
        for (int i=1; i<intervals.Count; i++)
        {
            if (res[^1][1]>=intervals[i][0]) res[^1][1]=Math.Max(res[^1][1], intervals[i][1]);
            else res.Add(intervals[i]);
        }
        return res;
    }

    public static List<int> MinSize(List<List<int>> intervals, List<int> queries)
    {
        List<int> result = [];
        foreach (int i in queries)
        {
            int min = int.MaxValue;
            for (int j=0; j<intervals.Count; j++)
            {
                if (i>=intervals[j][0] && i <= intervals[j][1])
                {
                    min=Math.Min(min, intervals[j][1]-intervals[j][0]+1);
                }
            }
            if (min == int.MaxValue) min = -1;
            result.Add(min);
        }
        return result;
    }

    public static List<int> MinSizeOptimal(List<List <int>> intervals, List<int> queries)
    {
        List<(int val, int idx)> sortedQuery = [.. queries
        .Select((q,i)=>(q,i))
        .OrderBy(q => q.q)];
        Console.WriteLine(string.Join(", ", sortedQuery));

        intervals.Sort((a,b)=>a[0].CompareTo(b[0]));
        foreach (List<int> item in intervals)
        {
            Console.WriteLine(string.Join(" ", item));
        }

        PriorityQueue<(int end, int size), int> pq = new();

        int j = 0;
        int[] result = new int[queries.Count];

        foreach ((int val, int idx) in sortedQuery)
        {
            while (j<intervals.Count && intervals[j][0] <= val && intervals[j][1] >= val)
            {
                int size = intervals[j][1] - intervals[j][0] + 1;
                pq.Enqueue((intervals[j][1], size), size);
                j++;
            }
            // var copy = new PriorityQueue<(int end, int size), int>(pq.UnorderedItems);

            // Console.WriteLine(string.Join(", ",
            //     copy.UnorderedItems.Select(x => $"(end={x.Element.end}, size={x.Element.size}, p={x.Priority})")
            // ));

            while (pq.Count>0 && pq.Peek().end < val)
                pq.Dequeue();

            result[idx] = pq.Count > 0 ? pq.Peek().size : -1;
        }
        return [.. result];
    }
}