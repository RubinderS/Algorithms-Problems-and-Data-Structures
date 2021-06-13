using Xunit;

public class CountDiv {
  public int Solution_0(int A, int B, int K) {
    var count = 0;

    for (int i = A; i <= B; i++) {
      if (i % K == 0) {
        count++;
      }
    }

    return count;
  }

  public int Solution_1(int A, int B, int K) {
    var firstDivisibleNumber = A % K == 0 ? A : A + (K - A % K);
    var lastDivisibleNumber = B - B % K;

    return ((lastDivisibleNumber - firstDivisibleNumber) / K) + 1;
  }

  [Theory]
  [InlineData(6, 11, 2, 3)]
  public void Test(int value1, int value2, int value3, int expected) {
    Assert.Equal(expected, Solution_0(value1, value2, value3));
    Assert.Equal(expected, Solution_1(value1, value2, value3));
  }
}
