namespace AlgorithmsTestProject
{
    public static class ArraySortProblems
    {
        public static void MySort1(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        ArrayProblems.Swap(array, i, j);
                    }
                }
            }
        }

        public static void MySort2(int[] array)
        {
            var current = array.ToList();
            var result = new List<int>();
            while (current.Count > 0)
            {
                var x = current.Min();
                result.Add(x);
                current.Remove(x);
            }
            result.CopyTo(array);
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
            bool swapped;
            var n = array.Length;
            do
            {
                swapped = false;

                for (var i = 1; i < n; ++i)
                {
                    if (array[i - 1] > array[i])
                    {
                        ArrayProblems.Swap(array, i - 1, i);
                        swapped = true;
                    }
                }

                --n;
            }
            while (swapped && n > 0);
        }

        public static void ShuffleSort(int[] array)
        {
            var random = new Random();
            for (var i = 0; i < array.Length; i++)
            {
                var j = random.Next(i, array.Length);
                ArrayProblems.Swap(array, i, j);
            }
        }

        public static void IntroSort(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                var min = i;
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                ArrayProblems.Swap(array, i, min);
            }
        }

        public static void CocktailSort(int[] array)
        {
            var sorted = false;
            while (!sorted)
            {
                sorted = true;
                for (var i = 1; i < array.Length; i++)
                {
                    if (array[i - 1] > array[i])
                    {
                        ArrayProblems.Swap(array, i - 1, i);
                        sorted = false;
                    }
                }
                for (var i = array.Length - 1; i > 0; i--)
                {
                    if (array[i - 1] > array[i])
                    {
                        ArrayProblems.Swap(array, i - 1, i);
                        sorted = false;
                    }
                }
            }
        }

        public static void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        private static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int partitionIndex = Partition(array, left, right);
                QuickSort(array, left, partitionIndex - 1);
                QuickSort(array, partitionIndex + 1, right);
            }
        }

        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    ArrayProblems.Swap(array, i, j);
                }
            }

            ArrayProblems.Swap(array, i + 1, right);
            return i + 1;
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

        public static void GnomeSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void SelectionSort(int[] array)
        {
        }
    }
}