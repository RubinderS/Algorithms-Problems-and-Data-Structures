using Xunit;

public static partial class Test {
  [Theory]
  [InlineData(new[] { 1, 3, 6, 4, 1, 2 }, 5)]
  [InlineData(new[] { 1, 2, 3 }, 4)]
  [InlineData(new[] { -1, -3 }, 1)]
  public static void MissingIntegerTest(int[] value, int expected) {
    Assert.Equal(expected, Solution.MissingInteger(value));
  }
}
