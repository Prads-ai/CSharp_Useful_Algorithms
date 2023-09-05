public class Solution 
{
  public void RotateArrayToRight(int[] ? arr)
  {
    if(arr.Length == 0 )
      return false
    int temp = arr[arr.Length -1]
    for(int i = 0 ; i < arr.Length - 1; i++)
    {
      arr[i] = a[i - 1];
    }
    arr[0] = temp;
  }
}
