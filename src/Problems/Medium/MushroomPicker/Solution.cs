using Xunit;

public class MushroomPicker {
  public int Solution(int[] A, int K, int M) {
    return 0;
  }

  [Theory]
  [InlineData(new[] { 2, 3, 7, 5, 1, 3, 9 }, 4, 6, 25)]
  public void Test(int[] value1, int value2, int value3, int expected) {
    Assert.Equal(expected, Solution(value1, value2, value3));
  }
}
