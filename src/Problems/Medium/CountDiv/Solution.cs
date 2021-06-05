using Xunit;

public class CountDiv {
  public int Solution(int A, int B, int K) {
    return (B - A) / K + ((A % K == 0 || B % K == 0) ? 1 : 0);
  }

  [Theory]
  [InlineData(6, 11, 2, 3)]
  public void Test(int value1, int value2, int value3, int expected) {
    Assert.Equal(expected, Solution(value1, value2, value3));
  }
}
