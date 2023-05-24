namespace AlgorithmsTestProject;

public static class ArrayProblems
{
    public static bool AreArraysEqual<T>(T[] xs, T[] ys)
    {
        return xs.Equals(ys) ? true : false;
        // throw new NotImplementedException(); 
    }

    public static void Swap<T>(T[] xs, int a, int b)
    {
        (xs[a], xs[b]) = (xs[b], xs[a]);
    }

    public static T FirstElement<T>(T[] xs)
    {
        return xs[0];
        // throw new NotImplementedException();
    }

    public static T LastElement<T>(T[] xs)
    {
        return xs[xs.Length - 1];
        // throw new NotImplementedException();
    }

    public static T MiddleElement<T>(T[] xs)
    {
        return xs[xs.Length / 2];
        // throw new NotImplementedException();
    }

    public static void Reverse<T>(T[] xs)
    {
        Array.Reverse(xs);
        // throw new NotImplementedException();
    }

    public static int CountElement<T>(T[] xs, T element)
    { 
        //sequencing : search for number of appearances of element in xs
        int count = 0;
        foreach (var item in xs)
        {
            if (item.Equals(element))
            {
                count++;
            }
        }
        return count;
        // throw new NotImplementedException();
    }

    public static string ToCommaDelimitedString<T>(T[] xs)
    {
        return string.Join(",", xs);
        // throw new NotImplementedException();
    }

    // Bonus problems

    public static int Count<T>(T[] xs, Func<T, bool> predicate)
    {
        int count = 0;
        foreach (var item in xs)
        {
            if (predicate(item))
            {
                count++;
            }
        }
        return count;
        // throw new NotImplementedException();
    }


    public static void Sort<T>(T[] xs, Func<T, T, int> comparer)
    {
        var stack  = 0;
        while (stack < xs.Length-1)
        {
            stack = 0;
            for (int i = 0; i < xs.Length - 1; i++)
            {
                for (int j = i + 1; j < xs.Length; j++)
                {
                    if (comparer(xs[i], xs[j]) < 0)
                    {
                        Swap(xs, i, j);
                    }
                    else
                    {
                        stack++;
                    }
                }
            }
        }
    }

    public static T Min<T>(T[] xs, Func<T, T, int> comparer)
    {
        Sort(xs, comparer);
        return xs[0];
        // throw new NotImplementedException();
    }

    public static T Max<T>(T[] xs, Func<T, T, int> comparer)
    {
        Sort(xs, comparer);
        return xs[xs.Length - 1];
        // throw new NotImplementedException();
    }

    public static bool HasDuplicates<T>(T[] xs)
    {
        var distinct =  xs.Distinct();
        if (distinct.Count() == xs.Count())
        {
            return true;
        }

        return false;
        // throw new NotImplementedException();
    }
}