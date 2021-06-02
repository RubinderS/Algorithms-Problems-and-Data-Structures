using System;
using System.Collections.Generic;

public static partial class Solution {
  public static int PermCheck_0(int[] A) {
    Array.Sort(A);

    for (int i = 0; i < A.Length; i++) {
      if (i + 1 != A[i]) {
        return 0;
      }
    }

    return 1;
  }

  public static int PermCheck_1(int[] A) {
    HashSet<int> set = new HashSet<int>();

    foreach (var integer in A) {
      if (integer > A.Length) {
        return 0;
      }

      set.Add(integer);
    }

    return set.Count == A.Length ? 1 : 0;
  }
}
