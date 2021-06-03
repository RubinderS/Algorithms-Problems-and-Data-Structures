using System.Linq;
using Xunit;

public static partial class Test {
  [Theory]
  [InlineData(5, new[] { 3, 4, 4, 6, 1, 4, 4 }, new[] { 3, 2, 2, 4, 2 })]
  public static void MaxCountersTest(int value1, int[] value2, int[] expected) {
    Assert.Equal(expected, Solution.MaxCounters_0(value1, value2));
  }
}
