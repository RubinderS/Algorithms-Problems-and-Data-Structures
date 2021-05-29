public static partial class Test {
  public static bool LongestSubstringWithoutRepeatingTest() {
    var didTestsPass = true;

    // LongestSubstringWithoutRepeating0
    if (Solution.LongestSubstringWithoutRepeating0("abcabcbb") != 3) {
      didTestsPass = false;
    }

    if (Solution.LongestSubstringWithoutRepeating0("bbbbb") != 1) {
      didTestsPass = false;
    }

    if (Solution.LongestSubstringWithoutRepeating0("pwwkew") != 3) {
      didTestsPass = false;
    }

    if (Solution.LongestSubstringWithoutRepeating0("") != 0) {
      didTestsPass = false;
    }

    // LongestSubstringWithoutRepeating1
    if (Solution.LongestSubstringWithoutRepeating1("abcabcbb") != 3) {
      didTestsPass = false;
    }

    if (Solution.LongestSubstringWithoutRepeating1("bbbbb") != 1) {
      didTestsPass = false;
    }

    if (Solution.LongestSubstringWithoutRepeating1("pwwkew") != 3) {
      didTestsPass = false;
    }

    if (Solution.LongestSubstringWithoutRepeating1("") != 0) {
      didTestsPass = false;
    }

    return didTestsPass;
  }
}