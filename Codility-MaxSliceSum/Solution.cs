using System.Runtime.CompilerServices;

namespace Codility_MaxSliceSum
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 1;
        public const int RANGE_HIGHEST_VALUE = 1000000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int[] A)
        {
            int N = A.Length;
            int maxSoFar = int.MaxValue;
            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE) 
            {
                if (N == 0)
                    return 0;
                int maxEndingHere = A[0];
                maxSoFar = A[0];

                for (int i = 1; i < A.Length; i++)
                {
                    maxEndingHere = Math.Max(A[i], maxEndingHere + A[i]);
                    maxSoFar = Math.Max(maxSoFar, maxEndingHere);
                }
            }

            return maxSoFar;
        }
    }
}
