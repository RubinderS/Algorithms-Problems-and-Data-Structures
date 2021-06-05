using System;
using System.Linq;
using Xunit;

public class TapeEquilibrium {
  public int Solution(int[] A) {
    var totalSum = A.Sum();
    var accumulatedSum = 0;
    var minimalDifference = int.MaxValue;

    for (int i = 0; i < A.Length - 1; i++) {
      accumulatedSum += A[i];
      totalSum -= A[i];
      var difference = Math.Abs(accumulatedSum - totalSum);

      if (difference < minimalDifference) {
        minimalDifference = difference;
      }
    }

    return minimalDifference;
  }

  [Theory]
  [InlineData(new[] { 3, 1, 2, 4, 3 }, 1)]
  public void Test(int[] value, int expected) {
    Assert.Equal(expected, Solution(value));
  }
}
