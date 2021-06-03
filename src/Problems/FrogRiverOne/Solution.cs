using System.Collections.Generic;
using Xunit;

public class FrogRiverOne {
  public int Solution(int X, int[] A) {
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

  [Theory]
  [InlineData(5, new[] { 1, 3, 1, 4, 2, 3, 5, 4 }, 6)]
  [InlineData(5, new[] { 1, 3, 1, 4, 2, 3, 4, 4 }, -1)]
  public void Test(int value1, int[] value2, int expected) {
    Assert.Equal(expected, Solution(value1, value2));
  }
}
