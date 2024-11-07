namespace LeetCode
{
    // Selection sort searchs for the small element and orders the ascending order
    // Time Complexicity : O()
    // Memory Complexicity : O()
    public static class SelectionSort
    {
        public static int[] RunSelectionSort(int[] arr)
        {
            // [3,7,2,9,4,1]
            var arrayLength = arr.Length; // T:1, M:4B

            for (int i = 0; i < arrayLength; i++) // T:n
            {
                for (int j = i+1; j < arrayLength; j++) // T: n*(n-1)/2
                {
                    if (arr[i] > arr[j])
                    {
                        int position = arr[i];
                        arr[i]= arr[j];
                        arr[j]= position;
                    }
                }
            }
            return arr;
        }
    }
}
