using System;
using System.Collections.Generic;
using Xunit;

public class PermCheck {
  public int Solution_0(int[] A) {
    Array.Sort(A);

    for (int i = 0; i < A.Length; i++) {
      if (i + 1 != A[i]) {
        return 0;
      }
    }

    return 1;
  }

  public int Solution_1(int[] A) {
    HashSet<int> set = new HashSet<int>();

    foreach (var integer in A) {
      if (integer > A.Length) {
        return 0;
      }

      set.Add(integer);
    }

    return set.Count == A.Length ? 1 : 0;
  }

  [Theory]
  [InlineData(new[] { 4, 1, 3, 2 }, 1)]
  [InlineData(new[] { 4, 1, 3 }, 0)]
  public void Test(int[] value, int expected) {
    Assert.Equal(expected, Solution_0(value));
    Assert.Equal(expected, Solution_1(value));
  }
}
