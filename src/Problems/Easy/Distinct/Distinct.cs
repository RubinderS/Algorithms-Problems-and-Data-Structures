using Xunit;

public class Distinct {
  public int Solution(int[] A) {
    return 0;
  }

  [Theory]
  [InlineData(new[] { 0, 1, 1, 2, 3, 1 }, 3)]
  public void Test(int[] value1, int expected) {
    Assert.Equal(expected, Solution(value1));
  }
}
