public class Solution {
       public void MoveZeroes(int[] nums)
    {
        int count = 0;
        Queue<int> q = new Queue<int>();
        foreach (int num in nums)
        {
            if (num != 0)
            {
                q.Enqueue(num);
            }
            else
            {
                count++;
            }
        }
        for (int i = 0; i < count; i++)
        {
            q.Enqueue(0);
        }
        int index = 0;

        foreach (int num in q)
        {
            nums[index++] = num;
        }   
        

    }
}
