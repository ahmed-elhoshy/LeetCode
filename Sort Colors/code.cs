public class Solution {
    public void SortColors(int[] nums) {
 List<int> zeroIndex = new List<int>();
 List<int> oneIndex = new List<int>();
 List<int> twoIndex = new List<int>();


 for (int i = 0; i < nums.Length; i++)
 {
     if (nums[i] == 0)
     {
         zeroIndex.Add(nums[i]);
         
     }
     else if (nums[i] == 1)
     {
         oneIndex.Add(nums[i]);
        
     }
     else if (nums[i] == 2)
     {
         twoIndex.Add(nums[i]);
        
     }
 }
 int index = 0;
 for (int i = 0; i < zeroIndex.Count; i++) nums[index++] = zeroIndex[i];
 for (int i = 0; i < oneIndex.Count; i++) nums[index++] = oneIndex[i];
 for (int i = 0; i < twoIndex.Count; i++) nums[index++] = twoIndex[i];
}
}
