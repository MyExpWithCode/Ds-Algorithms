using DS_Algorithms.Algorithms;

namespace DS_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bubble sort : 09/11/2024
            var arr = BubbleSort.RunBubbleSort(new int[] { 7, 3, 9, 5, 10, 1 });
            PrintValues(arr);

            // Insertion Sort : 09/11/2024
            //var arr = InsertionSort.GetInsertSorted(new int[] { 7,3, 9, 5, 10, 1 });
            //PrintValues(arr);

            // Selection Sort : 07/11/2024
            //var arr = SelectionSort.RunSelectionSort(new int[] { 3, 9, 5, 10, 1 });
            //PrintValues(arr);
        }
        public static void PrintValues(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
