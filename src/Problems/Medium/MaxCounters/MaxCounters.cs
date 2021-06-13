using System;
using Xunit;

public class MaxCounters {
  public int[] Solution(int N, int[] A) {
    int[] counters = new int[N];
    int maxCounterValue = 0;
    int lastMaxOperationValue = 0;

    for (int i = 0; i < A.Length; i++) {
      int index = A[i] - 1;

      if (index == N) {
        lastMaxOperationValue = maxCounterValue;
      } else {
        counters[index] = Math.Max(counters[index], lastMaxOperationValue);
        maxCounterValue = Math.Max(maxCounterValue, ++counters[index]);
      }
    }

    for (int j = 0; j < counters.Length; j++) {
      counters[j] = Math.Max(counters[j], lastMaxOperationValue);
    }

    return counters;
  }

  [Theory]
  [InlineData(5, new[] { 3, 4, 4, 6, 1, 4, 4 }, new[] { 3, 2, 2, 4, 2 })]
  public void Test(int value1, int[] value2, int[] expected) {
    Assert.Equal(expected, Solution(value1, value2));
  }
}
