using Xunit;

public class CyclicRotation {
  public int[] Solution(int[] A, int K) {
    return new int[0];
  }

  [Theory]
  [InlineData(new[] { 3, 8, 9, 7, 6 }, 3, new[] { 9, 7, 6, 3, 8 })]
  [InlineData(new[] { 0, 0, 0 }, 1, new[] { 0, 0, 0 })]
  [InlineData(new[] { 1, 2, 3, 4 }, 4, new[] { 1, 2, 3, 4 })]
  public void Test(int[] value1, int value2, int[] expected) {
    Assert.Equal(expected, Solution(value1, value2));
  }
}
