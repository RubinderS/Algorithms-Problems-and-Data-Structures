using System;
using Xunit;

public class BinaryGap {
  public int Solution(int N) {
    var maxBinaryGap = 0;
    var binarySeq = Convert.ToString(N, 2);
    var j = -1;
    var k = -1;

    for (int i = 0; i < binarySeq.Length; i++) {
      var bit = binarySeq[i];

      if (bit == '1') {
        maxBinaryGap = Math.Max(maxBinaryGap, k - j);
        j = i;
        k = i;
      } else {
        k++;
      }

    }

    return maxBinaryGap;
  }

  [Theory]
  [InlineData(9, 2)]
  [InlineData(529, 4)]
  [InlineData(20, 1)]
  [InlineData(15, 0)]
  [InlineData(32, 0)]
  public void Test(int value, int expected) {
    Assert.Equal(expected, Solution(value));
  }
}
