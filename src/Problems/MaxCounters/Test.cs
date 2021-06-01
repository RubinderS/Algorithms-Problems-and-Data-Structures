using System.Linq;

public static partial class Test {
  public static bool MaxCountersTest() {
    var didTestsPass = true;

    if (!Enumerable.SequenceEqual(
      Solution.MaxCounters_0(5, new int[] { 3, 4, 4, 6, 1, 4, 4 }),
      new int[] { 3, 2, 2, 4, 2 }
      )) {
      didTestsPass = false;
    }

    return didTestsPass;
  }
}
