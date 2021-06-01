public static partial class Test {
  public static bool LongestSubstringWithoutRepeatingTest() {
    var didTestsPass = true;

    // LongestSubstringWithoutRepeating0
    if (Solution.LongestSubstringWithoutRepeating_0("abcabcbb") != 3) {
      didTestsPass = false;
    }

    if (Solution.LongestSubstringWithoutRepeating_0("bbbbb") != 1) {
      didTestsPass = false;
    }

    if (Solution.LongestSubstringWithoutRepeating_0("pwwkew") != 3) {
      didTestsPass = false;
    }

    if (Solution.LongestSubstringWithoutRepeating_0("") != 0) {
      didTestsPass = false;
    }

    // LongestSubstringWithoutRepeating1
    if (Solution.LongestSubstringWithoutRepeating_1("abcabcbb") != 3) {
      didTestsPass = false;
    }

    if (Solution.LongestSubstringWithoutRepeating_1("bbbbb") != 1) {
      didTestsPass = false;
    }

    if (Solution.LongestSubstringWithoutRepeating_1("pwwkew") != 3) {
      didTestsPass = false;
    }

    if (Solution.LongestSubstringWithoutRepeating_1("") != 0) {
      didTestsPass = false;
    }

    return didTestsPass;
  }
}
