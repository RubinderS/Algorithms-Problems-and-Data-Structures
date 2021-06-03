using System;
using Xunit;

public class MissingInteger {
  public int Solution(int[] A) {
    var smallestMissingInteger = 1;
    Array.Sort(A);

    foreach (var integer in A) {
      if (integer == smallestMissingInteger) {
        smallestMissingInteger++;
      }
    }

    return smallestMissingInteger;
  }

  [Theory]
  [InlineData(new[] { 1, 3, 6, 4, 1, 2 }, 5)]
  [InlineData(new[] { 1, 2, 3 }, 4)]
  [InlineData(new[] { -1, -3 }, 1)]
  public void Test(int[] value, int expected) {
    Assert.Equal(expected, Solution(value));
  }
}
