using Codility_MaxSliceSum;

namespace Codility_MaxSliceSumTests
{
    public class SolutionTests
    {
        [Fact]
        public void TestEmptyArray()
        {
            int[] A = new int[0];
            Solution solution = new Solution();
            int result = solution.solution(A);
            Assert.Equal(int.MaxValue, result);
        }

        [Fact]
        public void TestSingleElementArray()
        {
            int[] A = new int[] { 5 };
            Solution solution = new Solution();
            int result = solution.solution(A);
            Assert.Equal(5, result);
        }

        [Fact]
        public void TestPositiveArray()
        {
            int[] A = new int[] { 3, 2, 1, 4, 7 };
            Solution solution = new Solution();
            int result = solution.solution(A);
            Assert.Equal(17, result);
        }

        [Fact]
        public void TestNegativeArray()
        {
            int[] A = new int[] { -3, -2, -1, -4, -7 };
            Solution solution = new Solution();
            int result = solution.solution(A);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void TestMixedArray()
        {
            int[] A = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Solution solution = new Solution();
            int result = solution.solution(A);
            Assert.Equal(6, result);
        }

        [Fact]
        public void TestRangeLowestValue()
        {
            int[] A = new int[Solution.RANGE_LOWEST_VALUE];
            Array.Fill(A, 1);
            Solution solution = new Solution();
            int result = solution.solution(A);
            Assert.Equal(Solution.RANGE_LOWEST_VALUE, result);
        }

        [Fact]
        public void TestRangeHighestValue()
        {
            int[] A = new int[Solution.RANGE_HIGHEST_VALUE];
            Array.Fill(A, -1);
            Solution solution = new Solution();
            int result = solution.solution(A);
            Assert.Equal(-1, result);
        }
    }
}