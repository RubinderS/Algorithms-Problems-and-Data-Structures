using System;
using System.Collections.Generic;
using Xunit;

public class GenomicRangeQuery {
  public int[] Solution_0(String S, int[] P, int[] Q) {
    var result = new int[P.Length];
    var impactFactor = new Dictionary<char, int>() {
      {'A', 1},
      {'C', 2},
      {'G', 3},
      {'T', 4},
    };
    var prevResults = new Dictionary<string, int>();

    for (int i = 0; i < P.Length; i++) {
      var minimalImpact = int.MaxValue;
      var key = String.Concat(P[i], Q[i]);

      if (!prevResults.ContainsKey(key)) {
        for (int j = P[i]; j <= Q[i]; j++) {
          if (impactFactor[S[j]] < minimalImpact) {
            minimalImpact = impactFactor[S[j]];
          }
        }

        result[i] = minimalImpact;
        prevResults[key] = minimalImpact;
      } else {
        result[i] = prevResults[key];
      }
    }

    return result;
  }

  [Theory]
  [InlineData("CAGCCTA", new[] { 2, 5, 0 }, new[] { 4, 5, 6 }, new[] { 2, 4, 1 })]
  public void Test(String value1, int[] value2, int[] value3, int[] expected) {
    Assert.Equal(expected, Solution_0(value1, value2, value3));
  }
}
