using System;
using System.Collections.Generic;
using System.Text;

public static partial class Solution {
  public static int LongestSubstringWithoutRepeating_0(string s) {
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

  public static int LongestSubstringWithoutRepeating_1(string s) {
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
}
