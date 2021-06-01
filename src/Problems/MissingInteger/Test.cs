public static partial class Test {
  public static bool MissingIntegerTest() {
    var didTestsPass = true;

    if (Solution.MissingInteger(new int[] { 1, 3, 6, 4, 1, 2 }) != 5) {
      didTestsPass = false;
    }

    if (Solution.MissingInteger(new int[] { 1, 2, 3 }) != 4) {
      didTestsPass = false;
    }

    if (Solution.MissingInteger(new int[] { -1, -3 }) != 1) {
      didTestsPass = false;
    }

    return didTestsPass;
  }
}
