 static int MinDiff(int[] arr)
    {
        Array.Sort(arr);
        int sum = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            sum += Math.Abs(arr[i] - arr[i - 1]);
        }

        return sum;
    }
