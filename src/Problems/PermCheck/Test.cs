public static partial class Test {
  public static bool PermCheckTest() {
    var didTestsPass = true;

    if (Solution.PermCheck_0(new int[] { 4, 1, 3, 2 }) != 1) {
      didTestsPass = false;
    }

    if (Solution.PermCheck_0(new int[] { 4, 1, 3 }) != 0) {
      didTestsPass = false;
    }

    if (Solution.PermCheck_1(new int[] { 4, 1, 3, 2 }) != 1) {
      didTestsPass = false;
    }

    if (Solution.PermCheck_1(new int[] { 4, 1, 3 }) != 0) {
      didTestsPass = false;
    }

    return didTestsPass;
  }
}
