using Xunit;

public static partial class Test {
  [Theory]
  [InlineData("abcabcbb", 3)]
  [InlineData("bbbbb", 1)]
  [InlineData("pwwkew", 3)]
  [InlineData("", 0)]
  public static void LongestSubstringWithoutRepeatingTest(string value, int expected) {
    Assert.Equal(expected, Solution.LongestSubstringWithoutRepeating_0(value));
    Assert.Equal(expected, Solution.LongestSubstringWithoutRepeating_1(value));
  }
}
