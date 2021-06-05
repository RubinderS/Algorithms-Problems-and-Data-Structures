using Xunit;

public class PermMissingElem {
  public int Solution(int[] A) {
    return 0;
  }

  [Theory]
  [InlineData(new[] { 2, 3, 1, 5 }, 4)]
  [InlineData(new[] { 2, 3, 1, 4, 6, 5, 8 }, 7)]
  public void Test(int[] value, int expected) {
    Assert.Equal(expected, Solution(value));
  }
}
