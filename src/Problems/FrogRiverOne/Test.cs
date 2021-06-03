using Xunit;

public static partial class Test {
  [Theory]
  [InlineData(5, new[] { 1, 3, 1, 4, 2, 3, 5, 4 }, 6)]
  [InlineData(5, new[] { 1, 3, 1, 4, 2, 3, 4, 4 }, -1)]
  public static void FrogRiverOne(int value1, int[] value2, int expected) {
    Assert.Equal(expected, Solution.FrogRiverOne_0(value1, value2));
  }
}
