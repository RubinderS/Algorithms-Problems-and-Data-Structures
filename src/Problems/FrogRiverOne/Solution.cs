using System.Collections.Generic;

public static partial class Solution {
  public static int FrogRiverOne0(int X, int[] A) {
    HashSet<int> set = new HashSet<int>();

    for (int i = 0; i < A.Length; i++) {
      var leafPosition = A[i];
      set.Add(leafPosition - 1);

      if (set.Count == X) {
        return i;
      }
    }

    return -1;
  }
}
