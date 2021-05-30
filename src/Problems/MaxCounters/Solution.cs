using System;

public static partial class Solution {
  public static int[] MaxCounters_0(int N, int[] A) {
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
}
