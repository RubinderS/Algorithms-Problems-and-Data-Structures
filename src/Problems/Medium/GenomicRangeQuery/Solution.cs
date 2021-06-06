using System;
using Xunit;

public class GenomicRangeQuery {
  public int[] Solution(String S, int[] P, int[] Q) {
    return new int[0];
  }

  [Theory]
  [InlineData("CAGCCTA", new[] { 2, 5, 0 }, new[] { 4, 5, 6 }, new[] { 2, 4, 1 })]
  public void Test(String value1, int[] value2, int[] value3, int[] expected) {
    Assert.Equal(expected, Solution(value1, value2, value3));
  }
}
