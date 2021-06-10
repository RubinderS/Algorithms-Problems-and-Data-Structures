using System;
using Xunit;

public class MushroomPicker {
  public int Solution(int[] A, int K, int M) {
    int[] PrefixSums(int[] Arr) {
      var prefixSums = new int[Arr.Length];
      prefixSums[0] = Arr[0];

      for (int i = 1; i < Arr.Length; i++) {
        prefixSums[i] = prefixSums[i - 1] + Arr[i];
      }

      return prefixSums;
    }

    int CalcSum(int[] prefixArr, int x, int y) {
      if (x <= 1) {
        return prefixArr[y];
      }

      return prefixArr[y] - prefixArr[x - 1];
    };

    return 0;
  }

  [Theory]
  [InlineData(new[] { 2, 3, 7, 5, 1, 3, 9 }, 4, 6, 25)]
  public void Test(int[] value1, int value2, int value3, int expected) {
    Assert.Equal(expected, Solution(value1, value2, value3));
  }
}
