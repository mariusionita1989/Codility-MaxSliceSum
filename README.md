# Codility-MaxSliceSum
A non-empty array A consisting of N integers is given.</br>
A pair of integers (P, Q), such that 0 ≤ P ≤ Q < N, is called a slice of array A.</br> 
The sum of a slice (P, Q) is the total of A[P] + A[P+1] + ... + A[Q].

Write a function:</br>
class Solution { public int solution(int[] A); }</br>
that, given an array A consisting of N integers, returns the maximum sum of any slice of A.</br>

For example, given array A such that:</br>
A[0] = 3  A[1] = 2  A[2] = -6</br>
A[3] = 4  A[4] = 0</br>
the function should return 5 because:</br>
(3, 4) is a slice of A that has sum 4,</br>
(2, 2) is a slice of A that has sum −6,</br>
(0, 1) is a slice of A that has sum 5,</br>
no other slice of A has sum greater than (0, 1).

Write an efficient algorithm for the following assumptions:</br>
N is an integer within the range [1..1,000,000];</br>
each element of array A is an integer within the range [−1,000,000..1,000,000];</br>
the result will be an integer within the range [−2,147,483,648..2,147,483,647].
