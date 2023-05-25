namespace AlgorithmsTestProject
{
    public static class ArraySortProblems
    {
        public static void MySort1(int[] array)
        {
            //write an algorithm to sort smth dynamic arrays allowed. no Sort or OrderBy or any library functions

            var stack = 0;
            while (stack < array.Length - 1)
            {
                stack = 0;
                for (int i = 0; i < array.Length - 1; i += 2)
                {
                    if (i + 1 < array.Length)
                    {
                        if (array[i] > array[i + 1])
                        {
                            ArrayProblems.Swap(array, i, i + 1);
                        }
                        else
                        {
                            stack++;
                        }
                    }
                }
            }
        }

        public static void MySort2(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void MergeSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void HeapSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void BubbleSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void ShuffleSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void IntroSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void CocktailSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void QuickSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void BlockSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void BogoSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void DoNothingSort(int[] array)
        {
        }

        public static void EvilSort(int[] array)
        {
            Array.Fill(array, 0);
        }
    }
}
