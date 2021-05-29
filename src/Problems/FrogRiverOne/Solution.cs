using System.Collections.Generic;
using System.Linq;

public static partial class Solution {
  public static int FrogRiverOne0(int X, int[] A) {
    int[] arr = new int[X];

    for (int i = 0; i < A.Length; i++) {
      var leafPosition = A[i];
      arr[leafPosition - 1] = 1;

      if (!arr.Contains(0)) {
        return i;
      }
    }

    return -1;
  }
}
