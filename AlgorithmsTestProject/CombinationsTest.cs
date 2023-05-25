using System;
namespace AlgorithmsTestProject
{
    public class CombinationsTest
    {
        [Test]
        public static void TestGenerateCombinations()
        {
            var testInput = new int[] { 1, 3, 5 };
            var output = GenerateCombinations(testInput);

            //expected result = [], [1], [3], [5], [1,3], [1,5] [3,5], [1,3,5]
            var expectedResults = new List<List<int>>
            {
                new List<int>(),
                new List<int> { 1 },
                new List<int> { 3 },
                new List<int> { 5 },
                new List<int> { 1, 3 },
                new List<int> { 1, 5 },
                new List<int> { 3, 5 },
                new List<int> { 1, 3, 5 },
            };

            Assert.That(output.Count, Is.EqualTo(8));
            Assert.That(output, Is.EqualTo(expectedResults));
        }

        public static List<List<int>> GenerateCombinations(int[] input)
        {
            var output = new List<List<int>>();
            var possibilities = 0;
            while (possibilities < input.Length)
            {
                for (int k = possibilities; k < input.Length; k++)
                {
                    var temp = new List<int>();
                    for (int i = 0; i < input.Length; i++)
                    {
                        temp.Add(input[i]);
                    }
					//print values in temp
					Console.WriteLine(temp);
                    output.Add(temp);
                }
                possibilities++;
            }

            return output;

        }
    }
}

