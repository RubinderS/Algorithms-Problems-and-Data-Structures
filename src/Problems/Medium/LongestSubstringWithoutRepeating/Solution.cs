using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

public class LongestSubstringWithoutRepeating {
  public int Solution_0(string s) {
    var temp = new StringBuilder();
    var longestSubstring = new StringBuilder();

    foreach (var c in s) {
      if (temp.ToString().IndexOf(c) != -1) {
        if (temp.Length >= longestSubstring.Length) {
          longestSubstring.Clear();
          longestSubstring.Append(temp.ToString());
        }

        temp.Clear();
      }

      temp.Append(c);
    }

    return longestSubstring.Length;
  }

  public int Solution_1(string s) {
    if (s == null || s == String.Empty) {
      return 0;
    }

    HashSet<char> set = new HashSet<char>();
    int currentMax = 0,
        i = 0,
        j = 0;

    while (j < s.Length) {
      if (!set.Contains(s[j])) {
        set.Add(s[j++]);
        currentMax = Math.Max(currentMax, j - i);
      } else {
        set.Remove(s[i++]);
      }
    }

    return currentMax;
  }

  [Theory]
  [InlineData("abcabcbb", 3)]
  [InlineData("bbbbb", 1)]
  [InlineData("pwwkew", 3)]
  [InlineData("", 0)]
  public void Test(string value, int expected) {
    Assert.Equal(expected, Solution_0(value));
    Assert.Equal(expected, Solution_1(value));
  }
}
