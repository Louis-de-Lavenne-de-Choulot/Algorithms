using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTestProject
{
    public static class LinkedListTests
    {
        public static void TestCount()
        {

        }

        public static void TestPrepend()
        {
        }

        public static void TestAppend()
        {
        }

        public static void TestGetAt()
        {
        }

        public static void TestSetAt()
        {
        }

        public static void TestSwap()
        {
        }

        public static void TestReverse()
        {
        }

        public static void TestEnumerate<T> (this LinkedList<T> list)
        {
            for(var iter = list.GetIterator(); iter.HasValue(); iter.GetNext())
            {
                yield return iter.GetElement();
            }
        }
    }
}
