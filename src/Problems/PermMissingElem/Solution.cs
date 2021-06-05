using System;
using Xunit;

public class PermMissingElem {
  public int Solution(int[] A) {
    var elementsFound = new int[A.Length + 1];

    foreach (var integer in A) {
      elementsFound[integer - 1] = 1;
    }

    return Array.IndexOf(elementsFound, 0) + 1;
  }

  [Theory]
  [InlineData(new[] { 2, 3, 1, 5 }, 4)]
  [InlineData(new[] { 2, 3, 1, 4, 6, 5, 8 }, 7)]
  public void Test(int[] value, int expected) {
    Assert.Equal(expected, Solution(value));
  }
}
