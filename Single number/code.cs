 public static int SingleNumber(int[] nums)
 {
     Dictionary<int, int> map = new Dictionary<int, int>();
     foreach (var num in nums)
     {
         if (!map.ContainsKey(num))
         {
             map.Add(num, 0);
         }
         map[num]++;
     }

     foreach (var entry in map)
     {
         if (entry.Value == 1)
         {
             return entry.Key;
         }
     }
     
    
     return 0;
 }
