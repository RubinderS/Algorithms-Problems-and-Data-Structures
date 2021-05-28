public static partial class Test {
  public static bool LongestSubstringWithoutRepeatingTest() {
    var didTestsPass = true;

    // LongestSubstringWithoutRepeating Test Cases
    if (Solution.LongestSubstringWithoutRepeating("abcabcbb") != 3) {
      didTestsPass = false;
    }

    if (Solution.LongestSubstringWithoutRepeating("bbbbb") != 1) {
      didTestsPass = false;
    }

    if (Solution.LongestSubstringWithoutRepeating("pwwkew") != 3) {
      didTestsPass = false;
    }

    if (Solution.LongestSubstringWithoutRepeating("") != 0) {
      didTestsPass = false;
    }

    return didTestsPass;
  }
}