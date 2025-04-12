 public static int GetMinTuningOperations(int[] queryTimes)
    {
        HashSet<int> seen = new HashSet<int>();
        int operations = 0;

        foreach (int num in queryTimes)
        {
            int t = num;
            while (t % 2 == 0)
            {
                if (!seen.Contains(t))
                {
                    operations++;
                    seen.Add(t);
                }
                t /= 2;
            }
        }

        return operations;
    }
