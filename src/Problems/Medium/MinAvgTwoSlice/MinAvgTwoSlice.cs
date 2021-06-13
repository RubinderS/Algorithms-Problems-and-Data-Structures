using Xunit;

public class MinAvgTwoSlice {
  public int Solution(int[] A) {
    return 0;
  }

  [Theory]
  [InlineData(new[] { 4, 2, 2, 5, 1, 5, 8, }, 1)]
  public void Test(int[] value1, int expected) {
    Assert.Equal(expected, Solution(value1));
  }
}
