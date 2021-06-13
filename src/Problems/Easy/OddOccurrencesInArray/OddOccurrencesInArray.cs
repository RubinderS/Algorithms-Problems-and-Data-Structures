using System.Collections.Generic;
using System.Linq;
using Xunit;

public class OddOccurrencesInArray {
  public int Solution(int[] A) {
    HashSet<int> set = new HashSet<int>();

    foreach (var number in A) {
      if (set.Contains(number)) {
        set.Remove(number);
      } else {
        set.Add(number);
      }
    }

    return set.Count == 1 ? set.ElementAt(0) : 0;
  }

  [Theory]
  [InlineData(new[] { 9, 3, 9, 3, 9, 7, 9 }, 7)]
  public void Test(int[] value, int expected) {
    Assert.Equal(expected, Solution(value));
  }
}
