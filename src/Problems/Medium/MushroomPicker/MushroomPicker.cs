using System;
using Xunit;

public class MushroomPicker {
  public int Solution(int[] Mushrooms, int StartingPosition, int Moves) {
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
    }

    var maxMushrooms = 0;
    var prefixSums = PrefixSums(Mushrooms);

    for (int i = 0; i < Math.Min(StartingPosition, Moves); i++) {
      int leftPos = StartingPosition - i;
      int rightPos = Math.Min(Math.Max(StartingPosition + Moves - 2 * i, StartingPosition), Mushrooms.Length - 1);
      maxMushrooms = Math.Max(maxMushrooms, CalcSum(prefixSums, leftPos, rightPos));
    }

    for (int i = 0; i < Math.Min(Mushrooms.Length - StartingPosition, Moves); i++) {
      int rightPos = StartingPosition + i;
      int leftPos = Math.Max(Math.Min(StartingPosition - Moves + 2 * i, StartingPosition), 0);
      maxMushrooms = Math.Max(maxMushrooms, CalcSum(prefixSums, leftPos, rightPos));
    }


    return maxMushrooms;
  }

  [Theory]
  [InlineData(new[] { 2, 3, 7, 5, 1, 3, 9 }, 4, 6, 25)]
  public void Test(int[] value1, int value2, int value3, int expected) {
    Assert.Equal(expected, Solution(value1, value2, value3));
  }
}
