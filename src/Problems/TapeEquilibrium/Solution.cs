using Xunit;

public class TapeEquilibrium {
  public int Solution(int[] A) {
    return 0;
  }

  [Theory]
  [InlineData(new[] { 3, 1, 2, 4, 3 }, 1)]
  public void Test(int[] value, int expected) {
    Assert.Equal(expected, Solution(value));
  }
}
