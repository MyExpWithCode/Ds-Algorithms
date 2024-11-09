namespace DS_Algorithms.Algorithms
{
    public static class BubbleSort
    {
        public static int[] RunBubbleSort(int[] arr)
        {
            // [7, 3, 9, 5, 10, 1 ]
            // 1-> [3, 7, 9, 5, 10, 1 ]


            for (int j = 1; j < arr.Length; j++) //n
            {

                int i = 1;

                while (i <= arr.Length - j) // 5+4+3+2+1= 
                {

                    if (arr[i] < arr[i - 1])
                    {
                        (arr[i - 1], arr[i]) = (arr[i], arr[i - 1]);
                    }

                    i++;
                }
            }

            return arr;
        }
    }
}
