using System;
using Xunit;

public class MinAvgTwoSlice {
  public int Solution(int[] A) {
    double currAvg1 = Double.MaxValue;
    double currAvg2 = Double.MaxValue;
    double minAvg = Double.MaxValue;
    int minAvgIndex = 0;

    for (int i = 0; i < A.Length - 2; i++) {
      currAvg1 = (A[i] + A[i + 1]) / 2.0;

      if (currAvg1 < minAvg) {
        minAvg = currAvg1;
        minAvgIndex = i;
      }

      currAvg2 = (currAvg1 + A[i + 2]) / 2.0;

      if (currAvg2 < minAvg) {
        minAvg = currAvg2;
        minAvgIndex = i;
      }
    }

    currAvg1 = (A[A.Length - 1] + A[A.Length - 2]) / 2.0;

    if (currAvg1 < minAvg) {
      minAvg = currAvg1;
      minAvgIndex = A.Length - 2;
    }

    return minAvgIndex;
  }

  [Theory]
  [InlineData(new[] { 4, 2, 2, 5, 1, 5, 8, }, 1)]
  public void Test(int[] value1, int expected) {
    Assert.Equal(expected, Solution(value1));
  }
}
