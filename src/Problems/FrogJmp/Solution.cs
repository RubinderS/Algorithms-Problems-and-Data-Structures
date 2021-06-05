using Xunit;

public class FrogJmp {
  public int Solution(int X, int Y, int D) {
    if (X >= Y) {
      return 0;
    }

    var numberOfJumps = 0;
    var distance = Y - X;
    numberOfJumps = distance / D + (distance % D != 0 ? 1 : 0);
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
