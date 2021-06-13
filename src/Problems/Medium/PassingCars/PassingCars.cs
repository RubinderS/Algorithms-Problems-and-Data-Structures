using Xunit;

public class PassingCars {
  public int Solution(int[] A) {
    return 0;
  }

  [Theory]
  [InlineData(new[] { 0, 1, 0, 1, 1 }, 5)]
  public void Test(int value1, int expected) {
    Assert.Equal(expected, value1);
  }
}


