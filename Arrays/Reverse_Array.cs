public class Solution {
  public static int[] Reverse_Array(int[] arr)
  {
    int[] reverseArr = new int[arr.Length];
    for(int i = 0; i < arr.Length ; i++)
    {
      reverseArr[i] = arr[arr.Length - 1 - i];
    }
      return reverseArr 
  }
}
