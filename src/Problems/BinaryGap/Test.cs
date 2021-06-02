public static partial class Test {
  public static bool BinaryGapTest() {
    if (Solution.BinaryGap(9) != 2) {
      return false;
    }

    if (Solution.BinaryGap(529) != 4) {
      return false;
    }

    if (Solution.BinaryGap(20) != 1) {
      return false;
    }

    if (Solution.BinaryGap(15) != 0) {
      return false;
    }

    if (Solution.BinaryGap(32) != 0) {
      return false;
    }

    return true;
  }
}
