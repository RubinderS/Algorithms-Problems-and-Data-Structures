public static partial class Test {
  public static bool FrogRiverOne() {
    var didTestsPass = true;

    if (Solution.FrogRiverOne(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 }) != 6) {
      didTestsPass = false;
    }

    return didTestsPass;
  }
}