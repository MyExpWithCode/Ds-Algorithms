namespace DS_Algorithms.Algorithms
{
    public static class InsertionSort
    {
        public static int[] GetInsertSorted(int[] arr)
        {
            // [7, 3, 9, 5, 10, 1 ]
            int arrLength = arr.Length; 

            //for (int i = 1; i < arrLength-1; i++)
            //{
            //    if (arr[i] > arr[i + 1])
            //    {
            //        var temp = arr[i];
            //        arr[i] = arr[i + 1];
            //        arr[i + 1] = temp;
            //    }

            //    if (i > 0 && arr[i] < arr[i - 1])
            //    {
            //        for (int j = i; j > 0; j--)
            //        {
            //            if (arr[j] < arr[j - 1])
            //            {
            //                var temp=arr[j-1];
            //                arr[j-1] = arr[j];
            //                arr[j] = temp;
            //            }
            //        }
            //    }
            //}

            // [7, 3, 9, 5, 10, 1 ]

            int i = 0;
            while (i < arrLength) //n
            {
                int position = i;
                while (position > 0)
                {
                    if (arr[position] < arr[position - 1])
                    {
                        (arr[position - 1], arr[position]) = (arr[position], arr[position - 1]);
                    }
                    position--;
                }
                i++;
            }
            return arr;
        }
    }
}
