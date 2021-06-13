using Xunit;

public class PassingCars {
  public int Solution(int[] A) {
    var nCarsEast = 0;
    var pairs = 0;

    foreach (var direction in A) {
      if (direction == 0) {
        nCarsEast++;
      } else {
        pairs += nCarsEast;

        if (pairs > 1000000000) {
          return -1;
        }
      }
    }


    return pairs;
  }

  [Theory]
  [InlineData(new[] { 0, 1, 0, 1, 1 }, 5)]
  [InlineData(new[] { 0, 0, 0 }, 0)]
  [InlineData(new[] { 1, 1, 1 }, 0)]
  public void Test(int[] value1, int expected) {
    Assert.Equal(expected, Solution(value1));
  }
}
