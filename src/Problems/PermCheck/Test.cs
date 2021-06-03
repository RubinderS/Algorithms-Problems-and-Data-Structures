using Xunit;

public static partial class Test {
  [Theory]
  [InlineData(new[] { 4, 1, 3, 2 }, 1)]
  [InlineData(new[] { 4, 1, 3 }, 0)]
  public static void PermCheckTest(int[] value, int expected) {
    Assert.Equal(expected, Solution.PermCheck_0(value));
    Assert.Equal(expected, Solution.PermCheck_1(value));
  }
}
