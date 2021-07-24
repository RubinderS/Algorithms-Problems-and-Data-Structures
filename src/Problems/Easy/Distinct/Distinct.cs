using System.Collections.Generic;
using Xunit;

public class Distinct {
  public int Solution(int[] A) {
    HashSet<int> set = new HashSet<int>();

    foreach (var number in A) {
      set.Add(number);
    }


    return set.Count;
  }

  [Theory]
  [InlineData(new[] { 2, 1, 1, 2, 3, 1 }, 3)]
  public void Test(int[] value, int expected) {
    Assert.Equal(expected, Solution(value));
  }
}
