using Xunit;

public static partial class Test {
  [Theory]
  [InlineData(9, 2)]
  [InlineData(529, 4)]
  [InlineData(20, 1)]
  [InlineData(15, 0)]
  [InlineData(32, 0)]
  public static void BinaryGapTest(int value, int expected) {
    Assert.Equal(expected, Solution.BinaryGap(value));
  }
}
