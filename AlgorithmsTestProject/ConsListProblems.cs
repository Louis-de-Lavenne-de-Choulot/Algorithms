namespace AlgorithmsTestProject;

public static class ConsListProblems
{
    public static IConsList<T> InsertBefore<T>(this IConsList<T> self, 
        int index, T value)
    {
        // [:index -1] + [value] + [index:]
        var newList = new List<T>();
        var i = 0;
        while (self != null)
        {
            if (i < index-1)
            {
                newList.Append(self.Value);
            }
            else if (i == index-1)
            {
                newList.Append(value);
            }
            else
            {
                newList.Append(self.Value);
            }
            self.NextValue();
            i++;
        };
        return newList.ToConsList();
    }

    public static IConsList<T> RemoveAt<T>(this IConsList<T> self, 
        int index)
    {
        // [:index -1] + [index:]
        var newList = new List<T>();
        var i = 0;
        while (self != null)
        {
            if (i < index-1)
            {
                newList.Append(self.Value);
            }
            else if (i == index-1)
            {
                // skip
            }
            else
            {
                newList.Append(self.Value);
            }
            self.NextValue();
            i++;
        };
        return newList.ToConsList();
        // throw new NotImplementedException();
    }
}