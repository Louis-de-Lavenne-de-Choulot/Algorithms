using System.Security.Cryptography.X509Certificates;

namespace AlgorithmsTestProject
{
    public static class LinkedListExercises
    {
        public static int Count<T>(this IList<T> self)
        {
            return self.Enumerate().Count();
        }

        public static void Prepend<T>(this IList<T> self, T x)
        {
            throw new NotImplementedException();
        }

        public static IIterator<T> GetLastIterator<T>(this IList<T> self)
        {
            var iter = self.GetIterator();
            while (iter.HasValue())
                iter = iter.GetNext();
            return iter;
        }

        public static void Append<T>(this IList<T> self, T x)
        {
            self.Insert(self.GetLastIterator(), x);
        }

        public static T GetAt<T>(this IList<T> self, int index)
        {
            var iter = self.GetIterator();
            for (var i = 0; iter.HasValue() && i < index; i++)
                iter = iter.GetNext();
            return iter.GetElement();
        }

        public static void SetAt<T>(this IList<T> self, int index, T element)
        {
            var iter = self.GetIterator();
            while (iter.HasValue() && index > 0)
                iter = iter.GetNext();
        }

        public static void Swap<T>(this IList<T> self, IIterator<T> a, IIterator<T> b)
        {
            throw new NotImplementedException();
        }

        public static IList<T> Reverse<T>()
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<T> Enumerate<T>(this IList<T> self)
        {
            for(var iter = self.GetIterator(); iter.HasValue(); iter.GetNext())
            {
                yield return iter.GetElement();
            }
        }
    }
}
