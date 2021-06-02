using System;

public static partial class Solution {
  public static int BinaryGap(int N) {
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
}
