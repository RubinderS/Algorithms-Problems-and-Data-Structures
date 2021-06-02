using System.Linq;

public static partial class Test {
  public static bool PermCheckTest() {
    var didTestsPass = true;

    if (Solution.PermCheck(new int[] { 4, 1, 3, 2 }) != 1) {
      didTestsPass = false;
    }

    if (Solution.PermCheck(new int[] { 4, 1, 3 }) != 1) {
      didTestsPass = false;
    }

    return didTestsPass;
  }
}
