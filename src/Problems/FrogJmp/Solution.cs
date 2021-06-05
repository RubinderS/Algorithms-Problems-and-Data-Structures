using Xunit;

public class FrogJmp {
  public int Solution(int X, int Y, int D) {
    var numberOfJumps = 0;
    return numberOfJumps;
  }

  [Theory]
  [InlineData(10, 85, 30, 3)]
  [InlineData(5, 25, 5, 4)]
  [InlineData(88, 89, 7, 1)]
  [InlineData(65, 65, 7, 0)]
  public void Test(int value1, int value2, int value3, int expected) {
    Assert.Equal(expected, Solution(value1, value2, value3));
  }
}
