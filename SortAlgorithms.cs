public static class SortAlgorithms
{
    public static void ExchangeSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    // deconstruction param
                    (array[i], array[j]) = (array[j], array[i]);
                }
            }
        }
    }

    public static void BubbleSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // deconstruction param
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                }
            }
        }
    }

    public static void QuickSort(int[] array, int start, int end)
    {
        // If more sorting is needed
        if (start >= end) return;

        // set it up
        int middle = (start + end) / 2;
        int pivot = array[middle];
        int index = Partition(array, start, end, pivot);


        // double the calls
        QuickSort(array, start, index - 1);
        QuickSort(array, index, end);
    }

    private static int Partition(int[] array, int left, int right, int pivot)
    {
        while (left <= right)
        {
            while (array[left] < pivot) left++;
            while (array[right] > pivot) right--;

            // If we get to this part of the code
            // it means we have a match
            if (left <= right)
            {
                (array[left], array[right]) = (array[right], array[left]);
                
                // Forces increment to break the while
                left++;
                right--;
            }
        }

        return left;
    }
}