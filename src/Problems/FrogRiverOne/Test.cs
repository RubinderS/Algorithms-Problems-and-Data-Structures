public static partial class Test {
  public static bool FrogRiverOne() {
    var didTestsPass = true;

    if (Solution.FrogRiverOne_0(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 }) != 6) {
      didTestsPass = false;
    }

    if (Solution.FrogRiverOne_0(5, new int[] { 1, 3, 1, 4, 2, 3, 4, 4 }) != -1) {
      didTestsPass = false;
    }

    return didTestsPass;
  }
}