using Xunit;

public class OddOccurrencesInArray {
  public int Solution(int[] A) {
    var oddOccurrence = 0;
    return oddOccurrence;
  }

  [Theory]
  [InlineData(new[] { 9, 3, 9, 3, 9, 7, 9 }, 7)]
  public void Test(int[] value, int expected) {
    Assert.Equal(expected, Solution(value));
  }
}
